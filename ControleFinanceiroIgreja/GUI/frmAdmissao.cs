using System;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmAdmissao : Form
    {
        BindingSource bs;
        Admissao adm = new Admissao();

        public frmAdmissao()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {

        }

        private void atualizar()
        {
            dtgAdmissao.DataSource = new DAO.CrudMembro().listaAdmissao(DAO.Conexao.con);

            adm = new Admissao();
            adm.id = 0;
            txtDesc.Clear();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgAdmissao.RowCount > 0)
            {

                adm.id = Convert.ToInt32(dtgAdmissao.SelectedRows[0].Cells[0].Value);
                adm.desc = dtgAdmissao.SelectedRows[0].Cells[1].Value.ToString();

                txtDesc.Text = adm.desc;

                txtDesc.Focus();

                lblDesc.Visible = false;

            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAdmissao_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
                dtgAdmissao.RowTemplate.MinimumHeight = Program.heightGrid;
            dtgAdmissao.DataSource = new CrudMembro().listaAdmissao(Conexao.con);
            //atualizar();
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

                adm.desc = txtDesc.Text.TrimStart().TrimStart();
                new CrudMembro().altAdmissao(Conexao.con, adm);

                lblDesc.Visible = true;

                atualizar();

            }
        }

        private void txtDesc_KeyUp(object sender, KeyEventArgs e)
        {
            lblDesc.Visible = txtDesc.Text.Length == 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
