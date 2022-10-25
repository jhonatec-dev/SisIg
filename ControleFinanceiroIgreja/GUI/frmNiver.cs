using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmNiver : Form
    {
        Igreja ig;
        Membro mem = new Membro();
        string desc = "da semana";

        public frmNiver(Igreja ig)
        {
            InitializeComponent();
            this.ig = ig;
        }


        private void dtgMembros_DoubleClick(object sender, EventArgs e)
        {
            if (dtgMembros.SelectedRows.Count > 0)
            {



                mem.id = (Int32)dtgMembros.SelectedRows[0].Cells["ID"].Value;
                mem.nome = dtgMembros.SelectedRows[0].Cells["Nome"].Value.ToString();


                //chamar form para edição

                frmAltMembro altm = new frmAltMembro(mem);

                altm.ShowDialog();
                /*
                if (altm.DialogResult == DialogResult.OK)
                {
                    if (frmP.ribNiverAno.Checked)
                    {
                        frmP.ribNiverAno.Checked = false;
                        ano(sender, new EventArgs());
                    }
                    else if (frmP.ribNiverMes.Checked)
                    {
                        frmP.ribNiverMes.Checked = false;
                        mes(sender, new EventArgs());
                    }
                    else
                    {
                        semana(sender, new EventArgs());
                    }

                }*/


            }
        }

        private void frmNiver_Load(object sender, EventArgs e)
        {



            


        }

        private void imprimir(object sender, EventArgs e)
        {
            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            BindingSource bs = new BindingSource();
            BindingSource bs2 = new BindingSource();


            bs.DataSource = dtgMembros.DataSource;

            listBS.Add(bs);

            bs2.DataSource = dtgVisitantes.DataSource;

            listBS.Add(bs2);

            listTotais.Add(dtgMembros.RowCount + dtgVisitantes.RowCount);

            listTotais.Add(desc);

            frmVerRelatorio frmR = new frmVerRelatorio(listBS, listTotais,
               ig, TiposRel.niverDin);

            frmR.ShowDialog();

        }

        private void ano(object sender, EventArgs e)
        {
            desc = "do ano";

            DateTime dt = DateTime.Now; DateTime dt2 = DateTime.Now;


            dt = new DateTime(dt.Year, 1, 1);


            dt2 = new DateTime(dt2.Year, 12, 31);

            dtgVisitantes.DataSource = new CrudVisitantes().niverDinamico(Conexao.con, dt, dt2);
            dtgMembros.DataSource = new CrudMembro().niverDinamico(Conexao.con, dt, dt2);

            //brincar com o fundo
            btnMes.BackColor = btnSemana.BackColor = panel1.BackColor;
            btnAno.BackColor = Color.FromArgb(0, 122, 204);

            removeColunas();

        }

        private void mes(object sender, EventArgs e)
        {
            desc = "do mês";

            DateTime dt = DateTime.Now; DateTime dt2 = DateTime.Now;

            dt = dt.AddDays(-dt.Day + 1);

            dt2 = dt.AddDays(DateTime.DaysInMonth(dt2.Year, dt2.Month) - 1);

            dtgVisitantes.DataSource = new CrudVisitantes().niverDinamico(Conexao.con, dt, dt2);
            dtgMembros.DataSource = new CrudMembro().niverDinamico(Conexao.con, dt, dt2);

            //brincar com o fundo
            btnAno.BackColor = btnSemana.BackColor = panel1.BackColor;
            btnMes.BackColor = Color.FromArgb(0, 122, 204);

            removeColunas();


        }

        private void semana(object sender, EventArgs e)
        {

            desc = "da semana";

            DateTime dt = DateTime.Now;
            DateTime dt2 = DateTime.Now;


            while (dt.DayOfWeek != DayOfWeek.Monday)
            {
                dt = dt.AddDays(-1);

            }

            while (dt2.DayOfWeek != DayOfWeek.Sunday)
            {
                dt2 = dt2.AddDays(1);

            }


            dtgVisitantes.DataSource = new CrudVisitantes().niverDinamico(Conexao.con, dt, dt2);
            dtgMembros.DataSource = new CrudMembro().niverDinamico(Conexao.con, dt, dt2);
            removeColunas();


            dtgMembros.Columns["Nome"].AutoSizeMode =
                dtgVisitantes.Columns["Nome"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            //brincar com o fundo
            btnAno.BackColor = btnMes.BackColor = panel1.BackColor;
            btnSemana.BackColor = Color.FromArgb(0, 122, 204);

            
            

        }

        private void removeColunas()
        {

            dtgMembros.Columns.RemoveAt(dtgMembros.Columns["DtNiver"].Index);
            dtgVisitantes.Columns.RemoveAt(dtgVisitantes.Columns["DtNiver"].Index);
            Application.DoEvents();
                

        }

        private void dtgVisitantes_DoubleClick(object sender, EventArgs e)
        {
            if (dtgVisitantes.SelectedRows.Count == 0)
                return;


            Visitantes vi = new Visitantes();

            vi.id = (Int32)dtgVisitantes.SelectedRows[0].Cells[0].Value;


            //chamar form para edição

            frmAltVisitante alt = new frmAltVisitante(vi);

            alt.ShowDialog();

            if (alt.DialogResult == DialogResult.OK)
            {

                //if (frmP.ribNiverAno.Checked)
                //{
                //    frmP.ribNiverAno.Checked = false;
                //    ano(sender, new EventArgs());
                //}
                //else if (frmP.ribNiverMes.Checked)
                //{
                //    frmP.ribNiverMes.Checked = false;
                //    mes(sender, new EventArgs());
                //}
                //else
                //{
                //    semana(sender, new EventArgs());
                //}

            }


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void frmNiver_Activated(object sender, EventArgs e)
        {

        }

        private void frmNiver_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmNiver_Enter(object sender, EventArgs e)
        {
            frmHome frm = (frmHome)this.MdiParent;
            frm.esconder();
            frm.marcarBotoes(frm.btnAniversariantes);
        }

        private void menuImp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmNiver_Shown(object sender, EventArgs e)
        {
            semana(sender, new EventArgs());
        }
    }
}
