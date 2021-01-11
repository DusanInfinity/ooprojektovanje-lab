using LAB5_Karte.Properties;
using Podaci;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace LAB5_Karte
{
    public partial class GlavniProzor : Form
    {
        private Igra _igra = new Igra(0, 0);
        private List<byte> _izabraneKarteZaZamenu = new List<byte>(3);
        public GlavniProzor()
        {
            InitializeComponent();
        }

        private void GlavniProzor_Load(object sender, System.EventArgs e)
        {
            OtvoriFormuZaUlog();
        }

        private void OtvoriFormuZaUlog()
        {
            FormaUlog form = new FormaUlog(_igra);
            DialogResult dlgRes = form.ShowDialog();

            if (dlgRes == DialogResult.OK)
                AzurirajPodatkeIPokreniIgru();
            else
            {
                _igra = null;
                Close();
            }
        }

        private void AzurirajPodatkeIPokreniIgru()
        {
            if (_igra.BrPoena < _igra.Ulog)
            {
                DialogResult result = MessageBox.Show($"Nemate dovoljno poena za ulog!\nDa li zelite da pokrenete novu igru?", "Nedovoljan broj poena", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    OtvoriFormuZaUlog();
                else
                {
                    _igra = null;
                    Close();
                }

                return;
            }
            _igra.PokreniIgru();

            AzurirajLabele();
            AzurirajKarte();
        }

        private void AzurirajLabele()
        {
            lblPoeni.Text = $"Poeni: {_igra.BrPoena}";
            lblUlog.Text = $"Ulog: {_igra.Ulog}";
        }

        private void AzurirajKarte()
        {
            if (_igra.IzabraneKarte.Count != 5)
                return;
            ResourceManager rm = Resources.ResourceManager;

            pbPrvaKarta.Image = (Bitmap)rm.GetObject(_igra.IzabraneKarte[0].Slika);
            pbDrugaKarta.Image = (Bitmap)rm.GetObject(_igra.IzabraneKarte[1].Slika);
            pbTrecaKarta.Image = (Bitmap)rm.GetObject(_igra.IzabraneKarte[2].Slika);
            pbCetvrtaKarta.Image = (Bitmap)rm.GetObject(_igra.IzabraneKarte[3].Slika);
            pbPetaKarta.Image = (Bitmap)rm.GetObject(_igra.IzabraneKarte[4].Slika);
        }

        private void VratiKarteNaPocetnuPoz()
        {
            if (_izabraneKarteZaZamenu.Count == 0)
                return;

            if (_izabraneKarteZaZamenu.Contains(0))
                pbPrvaKarta.Location = new System.Drawing.Point(pbPrvaKarta.Location.X, pbPrvaKarta.Location.Y + 10);
            if (_izabraneKarteZaZamenu.Contains(1))
                pbDrugaKarta.Location = new System.Drawing.Point(pbDrugaKarta.Location.X, pbDrugaKarta.Location.Y + 10);
            if (_izabraneKarteZaZamenu.Contains(2))
                pbTrecaKarta.Location = new System.Drawing.Point(pbTrecaKarta.Location.X, pbTrecaKarta.Location.Y + 10);
            if (_izabraneKarteZaZamenu.Contains(3))
                pbCetvrtaKarta.Location = new System.Drawing.Point(pbCetvrtaKarta.Location.X, pbCetvrtaKarta.Location.Y + 10);
            if (_izabraneKarteZaZamenu.Contains(4))
                pbPetaKarta.Location = new System.Drawing.Point(pbPetaKarta.Location.X, pbPetaKarta.Location.Y + 10);

            _izabraneKarteZaZamenu = new List<byte>(3);
        }

        private void NastaviIgru()
        {
            ZameniKarte();
            VratiKarteNaPocetnuPoz();

            Tuple<string, int> ishod = _igra.VratiIshod();
            int dobioPoena = ishod.Item2 * _igra.Ulog;

            if (ishod.Item1 != "/")
            {
                _igra.BrPoena += dobioPoena;
                MessageBox.Show($"Cestitamo!\n\n{ishod.Item1}\n\nOsvojili ste {dobioPoena} poena!", "POBEDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Nazalost, izgubili ste ulozene poene.", "PORAZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AzurirajPodatkeIPokreniIgru();
        }


        #region Eventi
        private void btnNastavi_Click(object sender, System.EventArgs e)
        {
            NastaviIgru();
        }
        private void karta_Click(object sender, EventArgs e)
        {
            if (!(sender is System.Windows.Forms.PictureBox pb))
                return;

            byte index = (byte)(pb == pbPrvaKarta ? 0 : pb == pbDrugaKarta ? 1 : pb == pbTrecaKarta ? 2 : pb == pbCetvrtaKarta ? 3 : pb == pbPetaKarta ? 4 : 5);
            if (index == 5)
                return;


            if (_izabraneKarteZaZamenu.Contains(index))
            {
                pb.Location = new System.Drawing.Point(pb.Location.X, pb.Location.Y + 10);
                _izabraneKarteZaZamenu.Remove(index);
                return;
            }

            if (_izabraneKarteZaZamenu.Count >= 3)
            {
                MessageBox.Show("Mozete zameniti max. 3 karte!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pb.Location = new System.Drawing.Point(pb.Location.X, pb.Location.Y - 10);
            _izabraneKarteZaZamenu.Add(index);
        }

        private void ZameniKarte()
        {
            if (_izabraneKarteZaZamenu.Count == 0)
                return;

            foreach (byte index in _izabraneKarteZaZamenu)
                _igra.ZameniKartu(index);

            AzurirajKarte();
        }
        #endregion


    }
}
