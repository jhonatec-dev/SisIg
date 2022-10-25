using System;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (dtgUsuarios.SelectedRows.Count < 1)
            {
                return;
            }

            if (MessageBox.Show("Deseja remover o usuário: " +
                    dtgUsuarios.SelectedRows[0].Cells["Usuário"].Value.ToString(),
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes)
            {

                int id = Convert.ToInt32(dtgUsuarios.SelectedRows[0].Cells["ID"].Value);
                new CrudUsuario().removeUsuario(Conexao.con, id);



                atualizar();
            }


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();

            us.id = 0;


            frmAltUsuario frm = new frmAltUsuario(us);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {


                atualizar();


            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (dtgUsuarios.SelectedRows.Count < 1)
            {
                return;
            }


            Usuario us = new Usuario();
            int id = Convert.ToInt32(dtgUsuarios.SelectedRows[0].Cells["ID"].Value);

            us = new CrudUsuario().getUsuario(Conexao.con, id);

            frmAltUsuario frm = new frmAltUsuario(us);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                atualizar();
            }


        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
                dtgUsuarios.RowTemplate.MinimumHeight = Program.heightGrid;

            atualizar();
        }

        private void atualizar()
        {

            dtgUsuarios.DataSource = new CrudUsuario().listaUsuarios(Conexao.con);


            dtgUsuarios.Columns["Senha"].Visible = false;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
