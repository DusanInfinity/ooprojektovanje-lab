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
    public partial class FormGlavna : Form
    {
        #region Konstruktori
        public FormGlavna()
        {
            InitializeComponent();
        }
        #endregion

        #region Metode
        private void UcitajPodatke()
        {
            if (ListaVozaca.Instanca.SortDelegate != null)
                ListaVozaca.Instanca.SortDelegate.Invoke();
            else
                dgvListaVozaca.DataSource = ListaVozaca.Instanca.ListaSvihVozaca.ToList();

            if (dgvListaVozaca.RowCount > 0)
            {
                btnIzmeniVozaca.Visible = true;
                btnObrisiVozaca.Visible = true;
            }
            else
            {
                btnIzmeniVozaca.Visible = false;
                btnObrisiVozaca.Visible = false;
            }
        }

        #region Sortiranje
        private void SortirajPoImenu()
        {
            List<Vozac> lista = ListaVozaca.Instanca.ListaSvihVozaca.ToList();

            if (lista == null)
                return;

            int br = lista.Count;
            for(int i = 0; i < br-1; i++)
            {
                int min = i;
                for(int j = i+1; j < br; j++)
                {
                    if (lista[min].Ime.CompareTo(lista[j].Ime) > 0)
                        min = j;
                }

                if(min != i)
                {
                    Vozac temp = lista[min];
                    lista[min] = lista[i];
                    lista[i] = temp;
                }
            }

            dgvListaVozaca.DataSource = lista.ToList();
        }

        private void SortirajPoPrezimenu()
        {
            List<Vozac> lista = ListaVozaca.Instanca.ListaSvihVozaca.ToList();
            if (lista == null)
                return;

            int br = lista.Count;
            for (int i = 0; i < br - 1; i++)
            {
                int min = i;
                for (int j = i+1; j < br; j++)
                {
                    if (lista[min].Prezime.CompareTo(lista[j].Prezime) > 0)
                        min = j;
                }
                if (min != i)
                {
                    Vozac temp = lista[min];
                    lista[min] = lista[i];
                    lista[i] = temp;
                }
            }

            dgvListaVozaca.DataSource = lista.ToList();
        }

        private void SortirajPoBrVozackeDozvole()
        {
            List<Vozac> lista = ListaVozaca.Instanca.ListaSvihVozaca.ToList();
            if (lista == null)
                return;

            int br = lista.Count;
            for (int i = 0; i < br - 1; i++)
            {
                int min = i;
                for (int j = i+1; j < br; j++)
                {
                    if (int.Parse(lista[min].BrVozackeDozvole) > int.Parse(lista[j].BrVozackeDozvole))
                        min = j;
                }
                if (min != i)
                {
                    Vozac temp = lista[min];
                    lista[min] = lista[i];
                    lista[i] = temp;
                }
            }

            dgvListaVozaca.DataSource = lista.ToList();
        }
        #endregion
        #endregion

        #region Event handler
        private void Form1_Load(object sender, EventArgs e)
        {
            comboSort.SelectedIndex = 0; // selektovanje prvog u listi kao default-nog izbora

            lblVreme.Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy.");
            tmrVreme.Start(); // postavljanje vremena i aktiviranje tajmera

            // Ucitavanje liste
            UcitajPodatke();
        }

        private void btnDodajVozaca_Click(object sender, EventArgs e)
        {
            FormVozac form = new FormVozac();

            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
                UcitajPodatke();
        }
        private void btnIzmeniVozaca_Click(object sender, EventArgs e)
        {
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;

            int selectedRow = dgvListaVozaca.SelectedRows[0].Index;
            string brVozacke = (string)dgvListaVozaca["BrVozackeDozvole", selectedRow].Value;
            Vozac vozac = ListaVozaca.Instanca.VratiVozaca(brVozacke);

            if(vozac == null)
            {
                MessageBox.Show("Doslo je do greske, izabrani vozac nije pronadjen!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FormVozac form = new FormVozac(vozac);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
                UcitajPodatke();
        }

        private void btnObrisiVozaca_Click(object sender, EventArgs e)
        {
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Da li zaista zelite da obrisete ovog vozaca?", "Brisanje vozaca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvListaVozaca.SelectedRows[0].Index;
            string brVozacke = (string)dgvListaVozaca["BrVozackeDozvole", selectedRow].Value;

            Vozac vozac = ListaVozaca.Instanca.VratiVozaca(brVozacke);

            if(ListaVozaca.Instanca.ObrisiVozaca(vozac))
            {
                MessageBox.Show("Uspesno ste obrisali ovog vozaca!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doslo je do greske prilikom brisanja vozaca!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UcitajPodatke();
        }
        private void tmrVreme_Tick(object sender, EventArgs e)
        {
            lblVreme.Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy.");
        }

        private void FormGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgRes = MessageBox.Show("Da li zaista zelite da ugasite program?", "Gasenje programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgRes == DialogResult.No)
                e.Cancel = true;
        }

        private void comboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboSort.Text == "Broj vozacke dozvole")
                ListaVozaca.Instanca.SortDelegate = SortirajPoBrVozackeDozvole;
            else if(comboSort.Text == "Ime")
                ListaVozaca.Instanca.SortDelegate = SortirajPoImenu;
            else if(comboSort.Text == "Prezime")
                ListaVozaca.Instanca.SortDelegate = SortirajPoPrezimenu;
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            if (ListaVozaca.Instanca.SortDelegate != null)
            {
                ListaVozaca.Instanca.SortDelegate.Invoke();

                MessageBox.Show("Uspesno ste sortirali vozace!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doslo je do greske, niste izabrali nacin za sortiranje!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
        #endregion
    }
}
