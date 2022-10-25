using System;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmAltUsuario : Form
    {

        Usuario user;
        bool bTodos = false;

        public frmAltUsuario(Usuario us)
        {
            InitializeComponent();

            this.user = us;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Equals("jhonsreis"))
            {
                MessageBox.Show("Usuário já está em uso pelo Administrador do Sistema!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtUsuario.Focus();
                txtUsuario.SelectAll();
                return;
            }

            //conferir se o usuario ja existe no banco
            if ((user.id == 0) && (new CrudUsuario().existeUsuario(Conexao.con, txtUsuario.Text).id > 0))
            {
                MessageBox.Show("Usuário já está em uso no Sistema!",
                                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtUsuario.Focus();
                txtUsuario.SelectAll();
                return;
            }


            //senha errada
            if (txtSenha.Text.Length < 3)
            {
                MessageBox.Show("A senha deve conter pelo menos 3 caracteres!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtSenha.Focus();
                txtSenha.SelectAll();
                return;
            }

            //senhas nao conferem
            if (!txtSenha.Text.Equals(txtConfirmarSenha.Text))
            {
                MessageBox.Show("Senhas não conferem!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtSenha.Focus();
                txtSenha.SelectAll();
                return;
            }


            user.user = txtUsuario.Text;
            user.senha = txtSenha.Text;
            user.membros = chkListaPermissoes.GetItemChecked(0);
            user.lanc = chkListaPermissoes.GetItemChecked(1);
            user.cargos = chkListaPermissoes.GetItemChecked(2);
            user.ebd = chkListaPermissoes.GetItemChecked(3);
            user.vis = chkListaPermissoes.GetItemChecked(4);
            user.dadosIgreja = chkListaPermissoes.GetItemChecked(5);
            user.usuarios = chkListaPermissoes.GetItemChecked(6);


            //Envia para o banco...
            new CrudUsuario().alteraUsuario(Conexao.con, user);

            //fecha

            DialogResult = DialogResult.OK;


        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {

            txtSenha.PasswordChar =
                txtConfirmarSenha.PasswordChar = (
                txtSenha.PasswordChar == '*' ? (char)Keys.None : '*');

        }

        private void frmAltUsuario_Load(object sender, EventArgs e)
        {

            if (user.id != 0)
            {
                txtUsuario.Text = user.user;
                txtSenha.Text = user.senha;
                txtConfirmarSenha.Text = user.senha;

                chkListaPermissoes.SetItemChecked(0, user.membros);
                chkListaPermissoes.SetItemChecked(1, user.lanc);
                chkListaPermissoes.SetItemChecked(2, user.cargos);
                chkListaPermissoes.SetItemChecked(3, user.ebd);
                chkListaPermissoes.SetItemChecked(4, user.vis);
                chkListaPermissoes.SetItemChecked(5, user.dadosIgreja);
                chkListaPermissoes.SetItemChecked(6, user.usuarios);
            }


        }

        private void chkListaPermissoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkListaPermissoes_DoubleClick(object sender, EventArgs e)
        {
            bTodos = !bTodos;
            for (int i = 0; i < chkListaPermissoes.Items.Count; i++)
            {
                chkListaPermissoes.SetItemChecked(i, bTodos);
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
