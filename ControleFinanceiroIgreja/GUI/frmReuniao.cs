using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmReuniao : Form
    {

        Reuniao reu;
        bool fast, classesInativas, alunosInativos;

        public frmReuniao(Reuniao reuniao, bool fast = false, bool clI = false, bool alI = false)
        {
            InitializeComponent();

            this.reu = reuniao;
            this.fast = fast;
            this.classesInativas = clI;
            this.alunosInativos = alI;
        }

        private void carregaAlunos(int idCla)
        {

            //carrega Alunos exceto os inativos

            dtgAlunos.Columns.Clear();

            dtgAlunos.DataSource = new CrudEscola().listaAlunos(Conexao.con, idCla, alunosInativos);

            dtgAlunos.Columns["ID"].Visible = false;
            dtgAlunos.Columns.Remove("IdMembro");
            dtgAlunos.Columns.Remove("Presenças");
            dtgAlunos.Columns.Remove("Faltas");
            dtgAlunos.Columns.Remove("Inativo");
            dtgAlunos.Columns.Remove("Pontos");

            DataGridViewCheckBoxColumn coluna = new DataGridViewCheckBoxColumn();

            coluna.Name = "Presente";

            coluna.HeaderText = "Presente";

            coluna.ReadOnly = false;

            dtgAlunos.Columns.Add(coluna);

            dtgAlunos.ReadOnly = false;
            dtgAlunos.Columns["Nome"].ReadOnly = true;

            dtgAlunos.Sort(dtgAlunos.Columns["Nome"], ListSortDirection.Ascending);


            foreach (DataGridViewRow row in dtgAlunos.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Presente"];
                chk.Value = !(chk.Value == null ? false : (bool)chk.Value); //because chk.Value is initialy null
            }

            // dtgAlunos.Columns["Presente"].DefaultCellStyle.Font = new Font("Arial", 30);

            dtgAlunos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }

        private void frmReuniao_Load(object sender, EventArgs e)
        {

            if (Program.tablet)
                dtgAlunos.RowTemplate.MinimumHeight = Program.heightGrid;

            carregaClasses();

            if (cbClasses.SelectedIndex == -1)
            {
                MessageBox.Show("Cadastre uma nova classe primeiro!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            cbClasses.Enabled = fast;


            if (reu.id != 0)
            {

                cbClasses.SelectedValue = reu.idClasse;

                //reuniao existe
                numBiblias.Value = reu.biblias;
                numRevistas.Value = reu.revistas;
                numVisitantes.Value = reu.visitantes;
                dtData.Value = reu.data;
                txtOferta.Text = reu.oferta.ToString();

                txtObs.Text = reu.obs;

                //carregaAlunos

                dtgAlunos.Columns.Clear();

                dtgAlunos.DataSource = new CrudEscola().listaAlunosReuniao(Conexao.con, reu.id);

                dtgAlunos.Columns.Remove("Id");

                dtgAlunos.Columns["IdClasseMembros"].Name = "Id";

                dtgAlunos.Columns["Id"].Visible = false;

                dtgAlunos.ReadOnly = false;

                dtgAlunos.Columns["Nome"].ReadOnly = true;
                dtgAlunos.Columns["idColor"].Visible = false;

            }
            else
            {
                if (fast)
                    reu.idClasse = Convert.ToInt32(cbClasses.SelectedValue);
                else
                    cbClasses.SelectedValue = reu.idClasse;

                carregaAlunos(reu.idClasse);
            }



        }

        private void numBiblias_ValueChanged(object sender, EventArgs e)
        {

        }

        private void carregaClasses()
        {

            cbClasses.DataSource = new CrudEscola().listaClasses(Conexao.con, classesInativas);

            cbClasses.DisplayMember = "Descrição";
            cbClasses.ValueMember = "Id";

        }

        private void txtOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {

                e.KeyChar = ',';

            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtOferta_Enter(object sender, EventArgs e)
        {
            txtOferta.SelectAll();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            reu.data = dtData.Value;
            reu.biblias = Convert.ToInt32(numBiblias.Value);
            reu.revistas = Convert.ToInt32(numRevistas.Value);
            reu.visitantes = Convert.ToInt32(numVisitantes.Value);
            reu.idClasse = Convert.ToInt32(cbClasses.SelectedValue);
            reu.obs = txtObs.Text;

            if ((txtOferta.Text.Length < 1) || (txtOferta.Text == ","))
            {

                reu.oferta = 0;
            }
            else
            {
                reu.oferta = Convert.ToDecimal(txtOferta.Text);
            }



            DataTable dt = new DataTable();

            // Header columns
            foreach (DataGridViewColumn column in dtgAlunos.Columns)
            {

                DataColumn dc = new DataColumn(column.Name.ToString());
                dt.Columns.Add(dc);


            }

            // Data cells
            for (int i = 0; i < dtgAlunos.Rows.Count; i++)
            {
                DataGridViewRow row = dtgAlunos.Rows[i];
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dtgAlunos.Columns.Count; j++)
                {
                    dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                }
                dt.Rows.Add(dr);
            }

            dt.Columns.Remove("Nome");
            dt.Columns.Remove("IdColor");

            new CrudEscola().altReuniao(Conexao.con, reu, dt);

            if (reu.oferta > 0)
            {

                if (MessageBox.Show("Dados salvos com sucesso!\n" +
                    "Deseja lançar no financeiro a oferta da reunião?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entrada en = new Entrada();
                    en.id = 0;
                    en.valor = reu.oferta;
                    en.data = reu.data;
                    en.obs = "OFERTA DA CLASSE " + cbClasses.Text;

                    frmEntrada frm = new frmEntrada(en, 0, 0, true);

                    frm.ShowDialog();

                }

            }
            else

                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;

        }

        private void numBiblias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gbClasseAlunos_Enter(object sender, EventArgs e)
        {

        }

        private void mostrarAlunosInativosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.alunosInativos = !this.alunosInativos;

            carregaAlunos(Convert.ToInt32(cbClasses.SelectedValue));

        }

        private void marcarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgAlunos.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Presente"];
                chk.Value = true; //because chk.Value is initialy null
            }
        }

        private void desmarcarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgAlunos.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Presente"];
                chk.Value = false; //because chk.Value is initialy null
            }
        }

        private void dtData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtgAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCheckBoxCell cell = this.dtgAlunos.CurrentCell as DataGridViewCheckBoxCell;

            if (cell != null && !cell.ReadOnly)
            {
                cell.Value = cell.Value == null || !((bool)cell.Value);
                this.dtgAlunos.RefreshEdit();
                this.dtgAlunos.NotifyCurrentCellDirty(true);
            }


        }

        private void dtgAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgAlunos.RefreshEdit();
        }

        private void frmReuniao_Shown(object sender, EventArgs e)
        {
            dtgAlunos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dtgAlunos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            int idCor = Convert.ToInt32(dtgAlunos.Rows[e.RowIndex].Cells["idColor"].Value.ToString());

            dtgAlunos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = corAluno(idCor), BackColor = Color.White };

        }


        private Color corAluno(int idcor)
        {

            switch (idcor)
            {

                case 0:
                    return (Color.Black);
                    
                case 1:
                    return (Color.Red);
                    
                case 2:
                    return (Color.Green);
                    

                case 3:
                    return (Color.Brown);
                    
                default:
                    return (Color.Black);
                    
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

            //carrega alunos com idClasse nova

            try
            {
                carregaAlunos(Convert.ToInt32(cbClasses.SelectedValue));
            }
            catch (Exception)
            {


            }


        }
    }
}
