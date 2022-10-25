using System;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmCatSaida : Form
    {
        BindingSource bs;
        CatSaida cat;


        public frmCatSaida()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {

        }

        private void atualizar()
        {
            dtgCatSaida.DataSource = new CrudSaida().listaCatSaida(Conexao.con);

            txtDesc.Clear();
            cat = new CatSaida();
            cat.id = 0;
        }

        private void frmCatSaida_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
                dtgCatSaida.RowTemplate.MinimumHeight = Program.heightGrid;

            atualizar();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgCatSaida.RowCount > 0)
            {

                cat.id = Convert.ToInt32(dtgCatSaida.SelectedRows[0].Cells[0].Value);
                cat.desc = dtgCatSaida.SelectedRows[0].Cells[1].Value.ToString();

                txtDesc.Text = cat.desc;

                txtDesc.Focus();


                lblDesc.Visible = false;

            }
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

                cat.desc = txtDesc.Text.TrimStart().TrimStart();
                new CrudSaida().altCatSaida(Conexao.con, cat);

                lblDesc.Visible = true;

                atualizar();

            }
        }

        private void dtgCatSaida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
