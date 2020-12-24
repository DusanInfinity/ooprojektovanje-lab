using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci;
using System.IO;

namespace LAB4
{
    public partial class FormVozac : Form
    {
        #region Property
        public Vozac VozacObj { get; set; } = null;
        public List<Kategorija> Kategorije { get; set; } = new List<Kategorija>();
        public List<Kategorija> Zabrane { get; set; } = new List<Kategorija>();
        private string _imagePath = string.Empty;
        #endregion

        #region Konstruktori
        public FormVozac()
        {
            InitializeComponent();
            pbSlika.Image = Properties.Resources.DefaultProfileV2;
        }

        public FormVozac(Vozac vozac)
            : this()
        {
            VozacObj = vozac;
            txtIme.Text = vozac.Ime;
            txtPrezime.Text = vozac.Prezime;
            dtpDatumRodjenja.Value = vozac.DatumRodjenja;
            dtpVazenjeOd.Value = vozac.VazenjeDozvoleOd;
            dtpVazenjeDo.Value = vozac.VazenjeDozvoleDo;
            txtBrVozackeDozvole.Text = vozac.BrVozackeDozvole;
            txtMestoIzdavanja.Text = vozac.MestoIzdavanja;
            cbPol.SelectedIndex = vozac.Pol == true ? 0 : 1;
            _imagePath = File.Exists(vozac.ImgPath) ? vozac.ImgPath : string.Empty; // Provera da li fajl postoji, mozda je obrisan u medjuvremenu, da ne bi pukao program ovo menjamo
            Kategorije = vozac.Kategorije.ToList();
            Zabrane = vozac.Zabrane.ToList();
        }
        #endregion

        #region Metode
        private bool IsValidInput()
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Niste uneli ime vozaca!", "GRESKA", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Niste uneli prezime vozaca!", "GRESKA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpVazenjeOd.Value >= dtpVazenjeDo.Value)
            {
                MessageBox.Show("Niste uneli validan datum vazenja dozvole!", "GRESKA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(txtBrVozackeDozvole.Text))
            {
                MessageBox.Show("Niste uneli broj vozacke dozvole!", "GRESKA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Niste uneli mesto izdavanja!", "GRESKA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(_imagePath))
            {
                MessageBox.Show("Niste dodali sliku vozaca!", "GRESKA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dgvKategorije.Rows.Count < 1)
            {
                MessageBox.Show("Niste dodali nijednu kategoriju!", "GRESKA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool Izmeni()
        {
            Vozac vozac = new Vozac(txtIme.Text, txtPrezime.Text, dtpDatumRodjenja.Value, dtpVazenjeOd.Value, dtpVazenjeDo.Value, txtBrVozackeDozvole.Text, txtMestoIzdavanja.Text, cbPol.SelectedIndex == 0, _imagePath, Kategorije, Zabrane);

            // Za svaki slucaj prosledjujemo i stari br vozacke dozvole, jer ce mozda i on da se izmeni
            return ListaVozaca.Instanca.IzmeniVozaca(VozacObj.BrVozackeDozvole, vozac);
        }

        public bool DodajKategoriju(Kategorija novaKat)
        {
            foreach(Kategorija k in Kategorije)
            {
                if (k.KategorijaOznaka == novaKat.KategorijaOznaka)
                    return false;
            }

            Kategorije.Add(novaKat);
            return true;
        }

        public bool DodajZabranu(Kategorija zabrana)
        {
            bool pronadjeno = false;
            foreach (Kategorija k in Kategorije)
            {
                if (k.KategorijaOznaka == zabrana.KategorijaOznaka)
                {
                    pronadjeno = true;
                    break;
                }
            }
            if (!pronadjeno)
                return false;

            // Provera da li postoji vec zabrana za tu kategoriju
            foreach (Kategorija z in Zabrane)
            {
                if (z.KategorijaOznaka == zabrana.KategorijaOznaka)
                {
                    return false;
                }
            }

            Zabrane.Add(zabrana);
            return true;
        }

        private void UcitajPodatke()
        {
            dgvKategorije.DataSource = Kategorije.ToList();
            if (dgvKategorije.RowCount > 0)
            {
                btnObrisiKategoriju.Visible = true;
                btnDodajZabranu.Visible = true;
            }
            else
            {
                btnDodajZabranu.Visible = false; // ne mozemo da dodajemo zabranu ako uopste vozac nema dozvolu ni za jednu kategoriju
                btnObrisiKategoriju.Visible = false;
            }

            dgvZabrane.DataSource = Zabrane.ToList();
            if (dgvZabrane.RowCount > 0)
                btnObrisiZabranu.Visible = true;
            else
                btnObrisiZabranu.Visible = false;
        }

        #endregion

        #region Event handlers
        private void FormVozac_Load(object sender, EventArgs e)
        {
            cbPol.SelectedIndex = 0; // izabran prvi
            UcitajPodatke();

            // Prikaz slike
            if (_imagePath != string.Empty)
            {
                pbSlika.Image = Image.FromFile(_imagePath);
            }
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            FormKatZabr form = new FormKatZabr(this, "Kategorija");

            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
                UcitajPodatke();
        }

        private void btnDodajZabranu_Click(object sender, EventArgs e)
        {
            FormKatZabr form = new FormKatZabr(this, Kategorije);

            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
                UcitajPodatke();
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtBrVozackeDozvole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
                return;

            if(VozacObj == null)
            {
                Vozac vozac = new Vozac(txtIme.Text, txtPrezime.Text, dtpDatumRodjenja.Value, dtpVazenjeOd.Value, dtpVazenjeDo.Value, txtBrVozackeDozvole.Text, txtMestoIzdavanja.Text, cbPol.SelectedIndex == 0, _imagePath, Kategorije, Zabrane);

                if (!ListaVozaca.Instanca.Dodaj(vozac))
                {
                    MessageBox.Show("Broj vozacke dozvole koji ste uneli vec postoji u bazi!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Uspesno ste dodali novog vozaca!",
                                    "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!Izmeni())
                {
                    MessageBox.Show("Doslo je do greske, pokusajte ponovo!",
                                    "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Uspesno ste izmenili vozaca!",
                                    "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            VozacObj = null;
            Kategorije = null;
            Zabrane = null;
            _imagePath = string.Empty;
            Close();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li zaista zelite da zatvorite prozor?", "Zatvaranje prozora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.No)
                return;

            VozacObj = null;
            Kategorije = null;
            Zabrane = null;
            _imagePath = string.Empty;
            Close();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnObrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (dgvKategorije.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Da li zaista zelite da obrisete ovu kategoriju?", "Brisanje kategorije", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvKategorije.SelectedRows[0].Index;
            Podaci.Kategorije kategorija = (Podaci.Kategorije)dgvKategorije["KategorijaOznaka", selectedRow].Value;

            foreach(Kategorija kat in Kategorije.ToList())
            {
                if(kat.KategorijaOznaka == kategorija)
                {
                    Kategorije.Remove(kat);
                    // Vrsimo proveru da li igrac ima i zabranu za ovu kategoriju, jer ne moze da ima zabranu a da uopste ne poseduje ni dozvolu
                    foreach(Kategorija zabrana in Zabrane.ToList())
                    {
                        if (zabrana.KategorijaOznaka == kat.KategorijaOznaka)
                            Zabrane.Remove(zabrana);
                    }
                    UcitajPodatke();
                    MessageBox.Show("Uspesno ste obrisali kategoriju!",
                                    "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Ovaj deo koda nikad ne bi trebalo da se izvrsi
            MessageBox.Show("Doslo je do greske, izabrana kategorija nije pronadjena!",
                                   "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnObrisiZabranu_Click(object sender, EventArgs e)
        {
            if (dgvZabrane.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Da li zaista zelite da obrisete ovu zabranu?", "Brisanje zabrane", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvZabrane.SelectedRows[0].Index;
            Podaci.Kategorije kategorija = (Podaci.Kategorije)dgvZabrane["KategorijaOznaka", selectedRow].Value;

            foreach (Kategorija kat in Zabrane.ToList())
            {
                if (kat.KategorijaOznaka == kategorija)
                {
                    Zabrane.Remove(kat);
                    UcitajPodatke();
                    MessageBox.Show("Uspesno ste obrisali zabranu!",
                                    "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Ovaj deo koda nikad ne bi trebalo da se izvrsi
            MessageBox.Show("Doslo je do greske, izabrana zabrana nije pronadjena!",
                                   "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *png)|*.jpg; *.jpeg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                pbSlika.Image = Image.FromFile(fileName);
                _imagePath = fileName;
            }
        }

        #endregion
    }
}
