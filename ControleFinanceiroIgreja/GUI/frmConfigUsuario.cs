using System;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmConfigUsuario : Form
    {
        Usuario user;

        public frmConfigUsuario(Usuario u)
        {
            InitializeComponent();

            this.user = u;

        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar =
                txtConfirmarSenha.PasswordChar = (
                txtSenha.PasswordChar == '*' ? (char)Keys.None : '*');
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (user.user.Equals("jhonsreis"))
            {
                DialogResult = DialogResult.OK;
                return;
            }

            //senha errada
            if (txtSenha.Text.Length < 3)
            {
                lblErro.Text = "A senha deve conter pelo menos 3 caracteres!";
                lblErro.Visible = true;

                txtSenha.Focus();
                txtSenha.SelectAll();
                return;
            }

            //senhas nao conferem
            if (!txtSenha.Text.Equals(txtConfirmarSenha.Text))
            {
                lblErro.Text = "Senhas não conferem!";
                lblErro.Visible = true;

                txtSenha.Focus();
                txtSenha.SelectAll();
                return;
            }

            user.senha = txtSenha.Text;

            new CrudUsuario().alteraUsuario(Conexao.con, user);

            DialogResult = DialogResult.OK;

        }

        private void frmConfigUsuario_Load(object sender, EventArgs e)
        {

            if (!user.user.Equals("jhonsreis"))
            {

                txtConfirmarSenha.Text =
                                txtSenha.Text = user.senha;
            }

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void cbTemaRibbon_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbCorRibbon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            lblSenha.Visible = txtSenha.Text.Length == 0;
        }

        private void txtConfirmarSenha_KeyUp(object sender, KeyEventArgs e)
        {
            lblConfirmar.Visible = txtConfirmarSenha.Text.Length == 0;
        }
    }
}
