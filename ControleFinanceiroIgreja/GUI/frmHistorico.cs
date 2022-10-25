using System;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmHistorico : Form
    {
        Aluno al;


        public frmHistorico(Aluno al)
        {
            InitializeComponent();

            this.al = al;
        }

        private void frmHistorico_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
                dtgPontos.RowTemplate.MinimumHeight = Program.heightGrid;

            carregaPontos();

            txtNome.Text = al.nome;
            txtClasse.Text = al.nomeClasse;

        }

        private void carregaPontos()
        {
            dtgPontos.DataSource = new CrudEscola().listaPontos(Conexao.con, al);


        }

        private void dtgPontos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgPontos.HitTest(e.X, e.Y);
                dtgPontos.ClearSelection();

                if (hti.RowIndex < 0)
                {
                    tsRemover.Enabled = editarMenu.Enabled = false;

                    return;
                }
                else
                {
                    tsRemover.Enabled = editarMenu.Enabled = true;

                    dtgPontos.Rows[hti.RowIndex].Selected = true;

                }
            }//if
        }

        private void tsPontuar_Click(object sender, EventArgs e)
        {
            PontoAluno pt = new PontoAluno();

            pt.id = 0;

            frmPontuar frm = new frmPontuar(pt, this.al);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                carregaPontos();
            }

        }

        private void editarMenu_Click(object sender, EventArgs e)
        {
            if (dtgPontos.SelectedRows.Count == 0)
                return;

            PontoAluno pt = new CrudEscola().getPonto(Conexao.con, Convert.ToInt32(dtgPontos.SelectedRows[0].Cells["Id"].Value));

            pt.idClasse = al.idClasse;
            pt.idClasseMembro = al.id;

            frmPontuar frm = new frmPontuar(pt);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                carregaPontos();
            }


        }

        private void frmHistorico_Shown(object sender, EventArgs e)
        {
            dtgPontos.Columns["Obs"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void tsRemover_Click(object sender, EventArgs e)
        {
            if (dtgPontos.SelectedRows.Count == 0)
                return;

            int id = Convert.ToInt32(dtgPontos.SelectedRows[0].Cells["Id"].Value);

            // string status = ((Convert.ToBoolean(dtgAlunos.SelectedRows[0].Cells["Inativo"].Value)) ? " ATIVAR " : " DESATIVAR ");

            string dt = dtgPontos.SelectedRows[0].Cells["Data"].Value.ToString();

            if (MessageBox.Show("Deseja remover a pontuação do dia " + dt + "? \n",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                new CrudEscola().removePonto(Conexao.con, id);

                carregaPontos();

            }
        }
    }
}
