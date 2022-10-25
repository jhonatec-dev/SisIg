using System;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmSituacao : Form
    {
        //BindingSource bs;
        Status sta = new Status();

        public frmSituacao()
        {
            InitializeComponent();
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
                dtgStatus.RowTemplate.MinimumHeight = Program.heightGrid;
            atualizar();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void atualizar()
        {
            dtgStatus.DataSource = new CrudMembro().listaStatus(Conexao.con);

            txtDesc.Clear();
            sta = new Status();
            sta.id = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgStatus.RowCount > 0)
            {
                sta.id = Convert.ToInt32(dtgStatus.SelectedRows[0].Cells[0].Value);
                sta.desc = dtgStatus.SelectedRows[0].Cells[1].Value.ToString();

                txtDesc.Text = sta.desc;

                txtDesc.Focus();

                lblDesc.Visible = false;

            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
        }

        private void pnBotoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text.TrimStart().TrimStart().Length <= 2)
            {

                MessageBox.Show("Descrição inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDesc.Focus();


            }
            else
            {

                sta.desc = txtDesc.Text.TrimStart().TrimStart();
                new CrudMembro().altStatus(Conexao.con, sta);

                lblDesc.Visible = true;

                atualizar();

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDesc_KeyUp(object sender, KeyEventArgs e)
        {
            lblDesc.Visible = txtDesc.Text.Length == 0;
        }
    }
}
