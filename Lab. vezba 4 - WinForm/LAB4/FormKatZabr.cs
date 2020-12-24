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

namespace LAB4
{
    public partial class FormKatZabr : Form
    {
        #region Property
        private Form _parent = null;
        #endregion

        #region Konstruktori
        public FormKatZabr()
        {
            InitializeComponent();
        }

        public FormKatZabr(Form parent, string naslov) 
            : this()
        {
            this._parent = parent;
            this.Text = naslov;

            if(naslov == "Kategorija")
            {
                foreach (Kategorije kat in Enum.GetValues(typeof(Kategorije)))
                    cbKategorija.Items.Add(kat.ToString());
                cbKategorija.SelectedIndex = 0;
            }
        }

        public FormKatZabr(Form parent, List<Kategorija> listaKategorija) 
            : this(parent, "Zabrana")
        {
            foreach(Kategorija kat in listaKategorija)
                cbKategorija.Items.Add(kat.KategorijaOznaka.ToString());
            cbKategorija.SelectedIndex = 0;
        }
        #endregion

        #region Metode
        private bool IsValidInput()
        {
            if (dtpDatumOd.Value >= dtpDatumDo.Value)
            {
                MessageBox.Show("Niste uneli validan datum vazenja!", "GRESKA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        #endregion

        #region Event handler
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!IsValidInput() || 
                !(_parent is FormVozac formVozac))
                return;

            if(this.Text == "Kategorija")
            {
                Kategorija kategorija = new Kategorija()
                {
                    KategorijaOznaka = (Kategorije)cbKategorija.SelectedIndex,
                    DatumOd = dtpDatumOd.Value,
                    DatumDo = dtpDatumDo.Value
                };
                if(!formVozac.DodajKategoriju(kategorija))
                {
                    MessageBox.Show("Vozac vec poseduje dozvolu za ovu kategoriju!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"Uspesno ste dodali dozvolu za {kategorija.KategorijaOznaka} kategoriju ovom vozacu!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(this.Text == "Zabrana")
            {
                if(!Enum.TryParse(cbKategorija.Text, out Kategorije izabranaKat))
                {
                    MessageBox.Show($"Izabrana kategorija nije validna! ({cbKategorija.Text})", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Kategorija kategorija = new Kategorija()
                {
                    KategorijaOznaka = izabranaKat,
                    DatumOd = dtpDatumOd.Value,
                    DatumDo = dtpDatumDo.Value
                };
                if (!formVozac.DodajZabranu(kategorija))
                {
                    MessageBox.Show("Vozac ne poseduje dozvolu za ovu kategoriju ili zabrana za ovu kategoriju vec postoji!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"Uspesno ste dodali zabranu za {kategorija.KategorijaOznaka} kategoriju ovom vozacu!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doslo je do greske, pokusajte ponovo!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Close();
            DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
