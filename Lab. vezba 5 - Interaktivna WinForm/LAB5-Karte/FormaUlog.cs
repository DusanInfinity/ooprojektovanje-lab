using Podaci;
using System.Windows.Forms;

namespace LAB5_Karte
{
    public partial class FormaUlog : Form
    {
        private Igra _igra;
        public FormaUlog()
        {
            InitializeComponent();
        }

        public FormaUlog(Igra igra)
            : this()
        {
            _igra = igra;
        }

        private void btnPokreniIgru_Click(object sender, System.EventArgs e)
        {
            if (numPoeni.Value < 1 || numPoeni.Value > 100000)
            {
                MessageBox.Show("Broj poena moze biti od 1 do 100000!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numUlog.Value < 1 || numUlog.Value > 100000)
            {
                MessageBox.Show("Ulog moze biti od 1 do 100000!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numPoeni.Value < numUlog.Value)
            {
                MessageBox.Show("Ulog mora da bude manji ili jednak broju poena!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _igra.BrPoena = (int)numPoeni.Value;
            _igra.Ulog = (int)numUlog.Value;
            _igra = null;
            Close();
            DialogResult = DialogResult.OK;
        }
    }
}
