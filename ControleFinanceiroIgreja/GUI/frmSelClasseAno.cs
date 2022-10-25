using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmSelClasseAno : Form
    {
        Igreja ig;

        public frmSelClasseAno(Igreja ig)
        {
            InitializeComponent();
            this.ig = ig;

        }

        private void frmSelClasseAno_Load(object sender, EventArgs e)
        {
            carregaClasses();

            txtAno.Text = DateTime.Now.Year.ToString();
        }


        private void carregaClasses()
        {

            cbClasses.DataSource = new CrudEscola().listaClasses(Conexao.con, true);

            cbClasses.DisplayMember = "Descrição";
            cbClasses.ValueMember = "Id";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!Char.IsNumber(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }

        }

        private void btnGerarRel_Click(object sender, EventArgs e)
        {

            //verifica classe
            if (cbClasses.SelectedIndex == -1)
            {
                MessageBox.Show("Cadastre uma nova classe primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //verifica ano
            if ((txtAno.Text.Length < 4))
            {
                MessageBox.Show("Informe um ano válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAno.Focus();
                return;

            }

            imprimir();

        }

        private void imprimir()
        {
            string nomeClasse = cbClasses.Text;

            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            BindingSource bs = new BindingSource();

            DataGridView dtgTmp = new DataGridView();

            DataTable dt = new DataTable();

            int idClasse = Convert.ToInt32(cbClasses.SelectedValue);
            int ano = Convert.ToInt32(txtAno.Text);

            dt = new CrudEscola().listaAlunosClasse(
                Conexao.con, idClasse: idClasse, ano: ano, inativos: chkInativos.Checked);

            bs.DataSource = dt;

            listTotais.Add(dt.Rows.Count);
            
            listBS.Add(bs);

            listTotais.Add(nomeClasse);

            listTotais.Add(ano);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relAlunosClasse);

            frm.ShowDialog();

        }

    }
}
