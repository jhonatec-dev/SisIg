using System;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmAltCargo : Form
    {

        Cargo cargo;

        public frmAltCargo(Cargo car)
        {
            InitializeComponent();

            this.cargo = car;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text.TrimStart().TrimStart().Length <= 2)
            {

                MessageBox.Show("Descrição inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDesc.Focus();


            }
            else
            {

                cargo.desc = txtDesc.Text.TrimStart().TrimStart();
                new CrudCargos().alteraCargo(Conexao.con, cargo);


                DialogResult = DialogResult.OK;

                Close();

            }
        }

        private void frmAltCargo_Load(object sender, EventArgs e)
        {
            txtDesc.Text = cargo.desc;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
