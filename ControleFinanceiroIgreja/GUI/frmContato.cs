using System;
using System.Windows.Forms;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmContato : Form
    {
        public frmContato()
        {
            InitializeComponent();
        }


        private void btnYouTube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/Jhonatec");
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://jhonatec.com/");
        }

        private void frmContato_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
