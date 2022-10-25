using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmVisitantes : Form
    {
        BindingSource bs;
        Igreja ig;
        Visitantes visitante;
        

        public frmVisitantes(Igreja ig)
        {
            InitializeComponent();
            this.ig = ig;
        }



        private void frmVisitantes_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
                dtgVisitantes.RowTemplate.MinimumHeight = Program.heightGrid;

            if (Program.tablet)
                dtgVisitas.RowTemplate.MinimumHeight = Program.heightGrid;


            atualizar();


        }


        private void ribRelVisNiver_Click(object sender, EventArgs e)
        {
            int mesNiver = 0;
            frmSelMes frm = new frmSelMes(true, false);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                mesNiver = frm.mes;

                List<BindingSource> listBS = new List<BindingSource>();
                List<Object> listTotais = new List<Object>();
                BindingSource bs = new BindingSource();

                DataTable dt = new DAO.CrudVisitantes().aniversariantes(DAO.Conexao.con, mesNiver);

                bs.DataSource = dt;

                listBS.Add(bs);
                listTotais.Add(dt.Rows.Count.ToString());
                listTotais.Add(frm.nomeMes);

                frmVerRelatorio frmR = new frmVerRelatorio(listBS, listTotais,
                   ig, TiposRel.relAniversariantes);

                frmR.ShowDialog();
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }


        public void imprimirSelecionado(object sender, EventArgs e)
        {

            if (dtgVisitantes.Rows.Count == 0)
                return;

            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();



            int idVisitante = Convert.ToInt32(dtgVisitantes.SelectedRows[0].Cells["ID"].Value);

            Visitantes vi = new CrudVisitantes().getVisitante(Conexao.con, idVisitante);

            //criar uma datasource para esse fim
            DataTable dt = new CrudVisitantes().listaVisitas(Conexao.con, idVisitante);

            BindingSource bss = new BindingSource();

            bss.DataSource = dt;

            listBS.Add(bss);

            listTotais.Add(dt.Rows.Count.ToString());
            listTotais.Add(vi);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relVisitas);



            frm.ShowDialog();


        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            atualizar();
        }

        private void impFichaNull(object sender, EventArgs e)
        {

            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            BindingSource bs = new BindingSource();

            listBS.Add(bs);


            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.fichaNovoVisitante);

            frm.ShowDialog();
        }


        public void atualizar()
        {

            dtgVisitantes.DataSource = new DAO.CrudVisitantes().listaVisitantes(DAO.Conexao.con);

            dtgVisitantes.ClearSelection();

            bs = new BindingSource();
            bs.DataSource = dtgVisitantes.DataSource;

            string nm = txtPesquisa.Text.TrimStart().TrimEnd();

            bs.Filter = "NOME LIKE '%" + nm + "%'";

            dtgVisitantes.DataSource = bs;

            lblReg.Text = dtgVisitantes.Rows.Count + " registro(s)";

            //dtgVisitantes.Rows[0].Selected = false;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Visitantes vi = new Visitantes();

            vi.id = 0;

            frmAltVisitante frm = new frmAltVisitante(vi);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                dtgVisitantes.DataSource = new DAO.CrudVisitantes().listaVisitantes(DAO.Conexao.con);
                atualizar();
            }




        }

        private void dtgVisitantes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgVisitantes.HitTest(e.X, e.Y);
                dtgVisitantes.ClearSelection();

                if (hti.RowIndex < 0)
                {
                    editarMenu.Enabled = false;
                    removerMenu.Enabled = false;

                    return;
                }
                else
                {
                    editarMenu.Enabled = true;
                    removerMenu.Enabled = true;


                    dtgVisitantes.Rows[hti.RowIndex].Selected = true;

                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgVisitantes.SelectedRows.Count == 0)
                return;


            Visitantes vi = new Visitantes();

            vi.id = Convert.ToInt32(dtgVisitantes.SelectedRows[0].Cells[0].Value);


            //chamar form para edição

            frmAltVisitante alt = new frmAltVisitante(vi);

            alt.ShowDialog();

            if (alt.DialogResult == DialogResult.OK)
            {
                dtgVisitantes.DataSource = new DAO.CrudVisitantes().listaVisitantes(DAO.Conexao.con);
                atualizar();

            }

            alt.Dispose();



        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dtgVisitantes.SelectedRows.Count == 0)
                return;


            int id = Convert.ToInt32(dtgVisitantes.SelectedRows[0].Cells[0].Value);

            if (MessageBox.Show("Tem certeza que deseja remover o visitante: " +
                            dtgVisitantes.SelectedRows[0].Cells[1].Value + " ?",
                            "Confirme", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new CrudVisitantes().removeVisitante(DAO.Conexao.con, id);

                MessageBox.Show("Dados salvos com sucesso!", "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dtgVisitantes.DataSource = new DAO.CrudVisitantes().listaVisitantes(DAO.Conexao.con);
                atualizar();

            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            listBS.Add(this.bs);
            listTotais.Add(dtgVisitantes.Rows.Count.ToString());

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relVisitantes);

            frm.ShowDialog();
        }

        private void frmVisitantes_Activated(object sender, EventArgs e)
        {
            txtPesquisa.Focus();

            txtPesquisa.Clear();
            atualizar();


        }

        private void listarVisitasMenu_Click(object sender, EventArgs e)
        {



        }

        private void dtgVisitantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Cell contente click" + e.RowIndex);
        }

        private void frmVisitantes_Deactivate(object sender, EventArgs e)
        {

        }

        private void gbVisitas_Enter(object sender, EventArgs e)
        {

        }

        private void gbVisitantes_Enter(object sender, EventArgs e)
        {

        }

        private void dtgVisitas_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgVisitas.HitTest(e.X, e.Y);
                dtgVisitas.ClearSelection();

                if (hti.RowIndex < 0)
                {
                    editarVisitas.Enabled = false;
                    removerVisitas.Enabled = false;
                    return;
                }
                else
                {
                    editarVisitas.Enabled = true;
                    removerVisitas.Enabled = true;

                    dtgVisitas.Rows[hti.RowIndex].Selected = true;

                }
            }
        }

        private void editarVisitas_Click(object sender, EventArgs e)
        {
            if (dtgVisitas.SelectedRows.Count == 0)
                return;


            Visitas vi = new Visitas();

            vi.id = Convert.ToInt32(dtgVisitas.SelectedRows[0].Cells["ID"].Value);
            vi.idVisitante = visitante.id;
            vi.data = Convert.ToDateTime(dtgVisitas.SelectedRows[0].Cells["Data"].Value);
            vi.tipo = dtgVisitas.SelectedRows[0].Cells["Tipo"].Value.ToString();
            vi.obs = dtgVisitas.SelectedRows[0].Cells["Obs"].Value.ToString();


            //chamar form para edição

            frmAltVisita alt = new frmAltVisita(vi);

            alt.ShowDialog();

            if (alt.DialogResult == DialogResult.OK)
            {

                atualizacomId();
            }

            alt.Dispose();
        }

        private void cadastrarVisitas_Click(object sender, EventArgs e)
        {
            Visitas vi = new Visitas();

            vi.id = 0;
            vi.idVisitante = this.visitante.id;

            frmAltVisita frm = new frmAltVisita(vi);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {


                atualizacomId();
            }
        }


        private void atualizacomId()
        {

            //atualiza os dados e seleciona o grid de visitantes com o id já em uso
            atualizar();

            //dtgVisitas.DataSource = new CrudVisitantes().listaVisitas(Conexao.con, visitante.id);

            foreach (DataGridViewRow row in dtgVisitantes.Rows)
            {

                if (Convert.ToInt32(row.Cells["ID"].Value) == visitante.id)
                {

                    row.Selected = true;
                    dtgVisitantes.CurrentCell = row.Cells[1];
                   
                    break;


                }

            }


        }

        private void removerVisitas_Click(object sender, EventArgs e)
        {
            if (dtgVisitas.SelectedRows.Count == 0)
                return;


            int id = Convert.ToInt32(dtgVisitas.SelectedRows[0].Cells[0].Value);

            if (MessageBox.Show("Tem certeza que deseja remover a visita de ID: " +
                            dtgVisitas.SelectedRows[0].Cells["ID"].Value + " ?",
                            "Confirme", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new DAO.CrudVisitantes().removeVisita(DAO.Conexao.con, id);

                MessageBox.Show("Dados salvos com sucesso!", "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                atualizacomId();
            }
        }

        private void cadastrarComoMembroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dtgVisitantes.SelectedRows.Count == 0)
                return;


            int id = (Int32)dtgVisitantes.SelectedRows[0].Cells["ID"].Value;

            Visitantes vis = new CrudVisitantes().getVisitante(Conexao.con, id);

            Membro m = new Membro();

            m.id = 0;

            frmAltMembro frm = new frmAltMembro(m, vis);

            frm.ShowDialog();


        }

        private void frmVisitantes_Shown(object sender, EventArgs e)
        {
            //dtgVisitantes.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void dtgVisitantes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void frmVisitantes_Enter(object sender, EventArgs e)
        {
            frmHome frm = (frmHome)this.MdiParent;
            frm.esconder();
            frm.marcarBotoes(frm.btnVisitantes);
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            lblPesq.Visible = txtPesquisa.Text.Length == 0;
        }

        private void menuImp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            imprimirToolStripMenuItem.Image = ControleFinanceiroIgreja.Properties.Resources.printer_48;
        }

        private void imprimirToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            imprimirToolStripMenuItem.Image = ControleFinanceiroIgreja.Properties.Resources.printer_48_black;
        }

        private void dtgVisitantes_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;


        }

        private void dtgVisitantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgVisitantes.SelectedRows.Count == 0)
            {
                txtNome.Clear();
                dtgVisitas.DataSource = null;
                gbVisitas.Enabled = false;
                return;

            }


           
            visitante = new Visitantes();

            visitante.id = Convert.ToInt32(dtgVisitantes.SelectedRows[0].Cells["Id"].Value);
            visitante.nome = dtgVisitantes.SelectedRows[0].Cells["Nome"].Value.ToString();
            gbVisitas.Enabled = true;

            txtNome.Text = visitante.nome;
            dtgVisitas.DataSource = new CrudVisitantes().listaVisitas(Conexao.con, visitante.id);



        }
    }
}
