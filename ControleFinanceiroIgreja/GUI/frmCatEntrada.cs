using System;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmCatEntrada : Form
    {

        //BindingSource bs;
        CatEntrada cat = new CatEntrada();

        public frmCatEntrada()
        {
            InitializeComponent();
        }

        private void frmCatEntrada_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
                dtgCatEntrada.RowTemplate.MinimumHeight = Program.heightGrid;
            atualizar();


        }

        private void atualizar()
        {
            dtgCatEntrada.DataSource = new CrudEntrada().listaCatEntrada(Conexao.con);

            txtDesc.Clear();
            cat = new CatEntrada();
            cat.id = 0;

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgCatEntrada.RowCount > 0)
            {
                cat.id = Convert.ToInt32(dtgCatEntrada.SelectedRows[0].Cells[0].Value);
                cat.desc = dtgCatEntrada.SelectedRows[0].Cells[1].Value.ToString();

                txtDesc.Text = cat.desc;

                txtDesc.Focus();

                lblDesc.Visible = false;

            }
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

                cat.desc = txtDesc.Text.TrimStart().TrimStart();
                new CrudEntrada().altCatEntrada(Conexao.con, cat);

                // MessageBox.Show("Dados salvos com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                atualizar();

                lblDesc.Visible = true;

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
