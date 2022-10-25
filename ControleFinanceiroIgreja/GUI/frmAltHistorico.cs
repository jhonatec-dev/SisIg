using System;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmAltHistorico : Form
    {

        Historico hs;


        public frmAltHistorico(Historico hs)
        {
            InitializeComponent();

            this.hs = hs;

        }

        private void frmAltHistorico_Load(object sender, EventArgs e)
        {
            this.Text += " " + hs.nomeMembro;
            if (hs.id > 0)
            {

                txtDesc.Text = hs.desc;
                dtData.Value = hs.data;

            }
            else
            {
                dtData.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            hs.data = dtData.Value;
            hs.desc = txtDesc.Text;

            new CrudMembro().altHistorico(Conexao.con, hs);

            //MessageBox.Show("Dados salvos com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
