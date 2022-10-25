using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmPontuar : Form
    {
        PontoAluno pt;
        Aluno alu;

        public frmPontuar(PontoAluno pt, Aluno alu = null)
        {
            InitializeComponent();
            this.pt = pt;
            this.alu = alu;
        }

        private void frmPontuar_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
            {
                numPt.Font = new Font(FontFamily.GenericSansSerif, 16);
            }

            carregaClasses();

            if (pt.id > 0)
            {
                cbClasse.SelectedValue = pt.idClasse;

                carregaAlunos(pt.idClasse);

                cbAluno.SelectedValue = pt.idClasseMembro;

                cbAluno.Enabled = cbClasse.Enabled = false;

                numPt.Value = pt.qtde;
                dtData.Value = pt.data;
                txtObs.Text = pt.obs;

            }
            else if (alu != null)
            {
                cbClasse.SelectedValue = alu.idClasse;

                carregaAlunos(alu.idClasse);

                cbAluno.SelectedValue = alu.id;

                cbAluno.Enabled = cbClasse.Enabled = false;
            }


        }

        private void carregaClasses()
        {

            DataTable dt = new CrudEscola().listaClasses(Conexao.con, false);


            cbClasse.DataSource = dt;

            cbClasse.DisplayMember = "Descrição";
            cbClasse.ValueMember = "Id";

        }

        private void carregaAlunos(int idClasse)
        {

            //ativa GroupBox
            cbAluno.Enabled = true;

            cbAluno.DataSource = new CrudEscola().listaAlunos(Conexao.con, idClasse, true);

            cbAluno.DisplayMember = "NOME";
            cbAluno.ValueMember = "Id";


        }

        private void cbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAluno.DataSource = null;

        }

        private void cbClasse_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            pt.idClasseMembro = Convert.ToInt32(cbAluno.SelectedValue);
            pt.qtde = Convert.ToInt32(numPt.Value);
            pt.data = dtData.Value;
            pt.obs = txtObs.Text;

            new CrudEscola().altPontosAluno(Conexao.con, pt);

            MessageBox.Show("Dados salvos com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;

        }

        private void cbAluno_Enter(object sender, EventArgs e)
        {

        }

        private void cbClasse_Leave(object sender, EventArgs e)
        {
            if (cbClasse.SelectedValue != null)
            {
                int idC = Convert.ToInt32(cbClasse.SelectedValue);

                carregaAlunos(idC);
            }
        }

        private void numPt_Enter(object sender, EventArgs e)
        {
            numPt.Select(0, numPt.Value.ToString().Length);
        }
    }
}
