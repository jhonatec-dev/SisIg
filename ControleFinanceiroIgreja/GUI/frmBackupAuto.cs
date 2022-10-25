using System;
using System.Windows.Forms;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmBackupAuto : Form
    {

        private int seg = 5;

        public frmBackupAuto()
        {
            InitializeComponent();
        }

        private void frmBackupAuto_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            btnSim.Text = "Sim (" + seg + " s)";
            Application.DoEvents();

            seg--;

            if (seg < 0)
            {
                DialogResult = DialogResult.Yes;
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
