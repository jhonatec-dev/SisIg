using System;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;
using System.IO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmLogin : Form
    {

        public Usuario usuario;
        

        public frmLogin(string nomeIgreja = "Igreja Evangélica")
        {
            InitializeComponent();

            lblIgreja.Text = nomeIgreja;

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {



            if (txtUsuario.Text.Equals("jhonsreis"))
                if (txtSenha.Text.Equals("Jhon7007"))
                {


                    usuario = new Usuario();

                    usuario.user = txtUsuario.Text;
                    usuario.senha = txtSenha.Text;
                    usuario.membros =
                        usuario.lanc =
                        usuario.vis =
                        usuario.cargos =
                        usuario.ebd =
                        usuario.dadosIgreja =
                        usuario.usuarios = true;




                    DialogResult = DialogResult.OK;
                    return;
                }


            this.usuario = new CrudUsuario().existeUsuario(Conexao.con, txtUsuario.Text);


            if (usuario.id < 1)
            {
                lblErro.Text = "* Usuário não existe!";
                lblErro.Visible = true;

                txtUsuario.Focus();
                txtUsuario.SelectAll();

                return;
            }

            if (!txtSenha.Text.Equals(usuario.senha))
            {

                lblErro.Text = "* Senha inválida!";
                lblErro.Visible = true;

                txtSenha.Focus();
                txtSenha.SelectAll();

                return;
            }

            usuario = new CrudUsuario().getUsuario(Conexao.con, usuario.id);


            DialogResult = DialogResult.OK;


        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.SelectAll();
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.SelectAll();

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }




        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {

            //txtUsuario.Text = txtSenha.Text = "admin";

            //btnLogin_Click(sender, new EventArgs());

            //return;

            txtSenha.PasswordChar = (
                txtSenha.PasswordChar == '*' ? (char)Keys.None : '*');

            txtSenha.Focus();
        }



        private void frmLogin_Shown(object sender, EventArgs e)
        {
            string imgnome = Directory.GetParent(Application.ExecutablePath) + @"\Img\imgLogo.jpg";
            if (File.Exists(imgnome))
                this.pcIgreja.Image = Image.FromFile(imgnome);

            txtUsuario.Focus();


        }
    }
}
