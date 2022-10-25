using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmMembros : Form
    {

        BindingSource bs;
        public Membro mem = new Membro();
        bool selecionar;
        Igreja ig;
        List<Status> listStatus = new List<Status>();
        bool boolInativos = false;


        public frmMembros(bool sel, Igreja ig)
        {
            InitializeComponent();

            this.ig = ig;
            selecionar = sel;

        }


        private void carregaStatus()
        {
            DataTable dt = new CrudMembro().listaSituacao(Conexao.con);
            this.listStatus.Clear();
            cbSituacao.Items.Clear();

            cbSituacao.Items.Add("----------------");


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Status st = new Status();

                st.id = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                st.desc = dt.Rows[i]["Descrição"].ToString();
                listStatus.Add(st);
                cbSituacao.Items.Add(st.id + " - " + st.desc);

            }

        }

        public void atualizar()
        {



            bs = new BindingSource();
            bs.DataSource = dtgMembros.DataSource;

            string nome, estadoCivil = "", situacao = "", inativo = " AND INATIVO = 0";

            nome = txtPesquisa.Text.TrimStart().TrimEnd();

            if (cbEstadoCivil.SelectedIndex > 0)
                estadoCivil = " AND ESTADOCIVIL = '" + cbEstadoCivil.Text + "' ";

            if (cbSituacao.SelectedIndex > 0)
                situacao = " AND SITUACAO = '" + listStatus[cbSituacao.SelectedIndex - 1].desc + "' ";

            if (boolInativos)
                inativo = "";

            bs.Filter = @"Nome like '%" + nome + @"%' " + estadoCivil + situacao + inativo;
            dtgMembros.DataSource = bs;

            lblReg.Text = dtgMembros.Rows.Count.ToString() + Environment.NewLine + "registro(s)";

            txtPesquisa.Focus();
        }

        private void frmMembros_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
                dtgMembros.RowTemplate.MinimumHeight = Program.heightGrid;
            //menuImp.Renderer = new DarkGrayRenderer();

            //positiion
            /*
            this.Left = this.Owner.Left + 48;
            this.Top = this.Owner.Top + 60;
            this.Width = this.Owner.Width - 49;
            this.Height = this.Owner.Height - 60;*/

            dtgMembros.DataSource = new DAO.CrudMembro().listaMembros(DAO.Conexao.con, "ORDER BY NOME");

            atualizar();
            carregaStatus();


        }



        public void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgMembros.SelectedRows.Count == 0)
                return;


            Membro mem = new Membro();

            mem.id = (Int32)dtgMembros.SelectedRows[0].Cells["Id"].Value;

            //chamar form para edição

            frmAltMembro altm = new frmAltMembro(mem);


            altm.ShowDialog();

            //atualizar tabela

            if (altm.DialogResult == DialogResult.OK)
            {
                dtgMembros.DataSource = new DAO.CrudMembro().listaMembros(DAO.Conexao.con);
                atualizar();
            }


        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            atualizar();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (dtgMembros.SelectedRows.Count == 0)
                return;

            int id = Convert.ToInt32(dtgMembros.SelectedRows[0].Cells["ID"].Value);

            string strStatus = "DESATIVAR";

            if ((bool)dtgMembros.SelectedRows[0].Cells["Inativo"].Value == true)
            {
                strStatus = "ATIVAR";
            }

            if (MessageBox.Show("Tem certeza que deseja " + strStatus + " o membro " +
                            dtgMembros.SelectedRows[0].Cells["Nome"].Value + " ?",
                            "Confirme", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new DAO.CrudMembro().statusMembro(DAO.Conexao.con, id);

                MessageBox.Show("Dados salvos com sucesso!", "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                dtgMembros.DataSource = new DAO.CrudMembro().listaMembros(DAO.Conexao.con);
                atualizar();

            }

        }

        private void chkInativos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgMembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgMembros_DoubleClick(object sender, EventArgs e)
        {
            if (dtgMembros.SelectedRows.Count > 0)
            {



                mem.id = Convert.ToInt32(dtgMembros.SelectedRows[0].Cells["ID"].Value);
                mem.nome = dtgMembros.SelectedRows[0].Cells["Nome"].Value.ToString();

                if (selecionar)
                {
                    DialogResult = DialogResult.OK;

                    Close();

                    return;
                }


                //chamar form para edição

                frmAltMembro altm = new frmAltMembro(mem);

                altm.ShowDialog();

                //atualizar tabela

                if (altm.DialogResult == DialogResult.OK)
                {
                    dtgMembros.DataSource = new DAO.CrudMembro().listaMembros(DAO.Conexao.con);
                    atualizar();
                }
            }
        }

       

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dtgMembros_MouseDown(object sender, MouseEventArgs e)
        {
            pnFiltro.Visible = false;
            
            
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgMembros.HitTest(e.X, e.Y);
                dtgMembros.ClearSelection();

                if (hti.RowIndex < 0)
                {
                    editarMenu.Enabled =
                    statusMenu.Enabled =
                    tsImpSel.Enabled = false;

                    statusMenu.Text = "Ativar/Desativar";
                    return;
                }
                else
                {
                    editarMenu.Enabled =
                        tsImpSel.Enabled =
                         statusMenu.Enabled = true;

                   

                    dtgMembros.Rows[hti.RowIndex].Selected = true;

                    statusMenu.Text = (bool)dtgMembros.SelectedRows[0].Cells["Inativo"].Value ? "Ativar" : "Desativar" ;

                }
            }//if
        }


        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizar();
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER ---> DOUBLE CLICK DTG
            //SETA ---> KEYDOWN DTG
            if (e.KeyCode == Keys.Enter)
            {
                dtgMembros_DoubleClick(sender, e);
            }
            else if (dtgMembros.Rows.Count > 0)
            {

                if (e.KeyCode == Keys.Down)
                {

                    if (dtgMembros.CurrentRow.Index < dtgMembros.Rows.Count - 1)
                        dtgMembros.CurrentCell = dtgMembros.Rows[dtgMembros.CurrentRow.Index + 1].Cells[0];

                }

                if (e.KeyCode == Keys.Up)
                {
                    if (dtgMembros.CurrentRow.Index > 0)
                        dtgMembros.CurrentCell = dtgMembros.Rows[dtgMembros.CurrentRow.Index - 1].Cells[0];
                    return;
                }
            }

        }

        private void dtgMembros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtgMembros_DoubleClick(sender, e);
            }
            else
            {
                /* if (e.KeyCode != Keys.Tab)
                 {
                     txtPesquisa_KeyDown(sender, e);
                 }*/
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Up))
            {

                e.KeyChar = (char)Keys.None;


            }

            if ((!Char.IsLetterOrDigit(e.KeyChar)) && (!Char.IsControl(e.KeyChar)) && (!Char.IsWhiteSpace(e.KeyChar)))
            {

                ttError.Show("Caractere inválido", txtPesquisa, 850);
                e.Handled = true;
            }

            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        public void cadastrarMenu_Click(object sender, EventArgs e)
        {

            Membro m = new Membro();

            m.id = 0;

            frmAltMembro frm = new frmAltMembro(m);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                dtgMembros.DataSource = new DAO.CrudMembro().listaMembros(DAO.Conexao.con, "ORDER BY NOME");
                atualizar();
            }


        }

        private void frmMembros_Activated(object sender, EventArgs e)
        {

            txtPesquisa.Focus();

            txtPesquisa.Clear();
            atualizar();

            frmHome f = (frmHome)this.MdiParent;

            f.esconder();

        }


        private void frmMembros_Shown_1(object sender, EventArgs e)
        {
            dtgMembros.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //incrementar heigt linhas do grid

        }




        private void frmMembros_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmMembros_FormClosed(object sender, FormClosedEventArgs e)
        {


        }


        private void frmMembros_Enter(object sender, EventArgs e)
        {
            frmHome frm = (frmHome)this.MdiParent;
            frm.esconder();
            frm.marcarBotoes(frm.btnMembros);
        }

       

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void cbEstadoCivil_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.White;
            e.DrawBackground();
            e.Graphics.DrawString(cbEstadoCivil.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void cbSituacao_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.White;
            e.DrawBackground();
            e.Graphics.DrawString(cbSituacao.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

      
        private void btnFiltros_Click(object sender, EventArgs e)
        {
            pnFiltro.Location = new Point(25, 25);
            pnFiltro.Visible = true;


        }

        private void btnAplicaFiltro_Click(object sender, EventArgs e)
        {
            pnFiltro.Visible = false;
            txtPesquisa.Focus();
        }

        private void chkInativos_CheckedChanged_1(object sender, EventArgs e)
        {
            boolInativos = chkInativos.Checked;
            atualizar();
        }

        private void tsImpSel_Click(object sender, EventArgs e)
        {
            if (dtgMembros.SelectedRows.Count == 0)
                return;


            Membro membro = new Membro();

            membro.id = Convert.ToInt32(dtgMembros.SelectedRows[0].Cells[0].Value);

            membro = new CrudMembro().getMembro(Conexao.con, membro.id);

            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            DataTable dtHistorico = new CrudMembro().listaHistorico(Conexao.con, membro.id);

            BindingSource bs = new BindingSource();

            bs.DataSource = dtHistorico;

            // membro.admissao = cbAdmissao.Text;
            // membro.status = cbStatus.Text;

            listBS.Add(bs);


            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.fichaMembro, membro);

            frm.ShowDialog();
            frm.ShowDialog();
        }

        private void tsImpFicha_Click(object sender, EventArgs e)
        {
            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            BindingSource bs = new BindingSource();



            listBS.Add(bs);


            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.fichaNovoMembro);

            frm.ShowDialog();
        }

        private void tsImpGrafSexo_Click(object sender, EventArgs e)
        {
            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            BindingSource bs = new BindingSource();

            DataTable dt = new DAO.CrudMembro().membrosSexos(DAO.Conexao.con);

            bs.DataSource = dt;

            listBS.Add(bs);
            listTotais.Add("2");

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
               ig, TiposRel.relSexos);

            frm.ShowDialog();
        }

        private void tsImpAniversariantes_Click(object sender, EventArgs e)
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

                DataTable dt = new DAO.CrudMembro().aniversariantes(DAO.Conexao.con, mesNiver);

                bs.DataSource = dt;

                listBS.Add(bs);
                listTotais.Add(dt.Rows.Count.ToString());
                listTotais.Add(frm.nomeMes);

                frmVerRelatorio frmR = new frmVerRelatorio(listBS, listTotais,
                   ig, TiposRel.relAniversariantes);

                frmR.ShowDialog();
            }
        }

        private void tsImpLista_Click(object sender, EventArgs e)
        {
            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            listBS.Add(this.bs);
            listTotais.Add(dtgMembros.Rows.Count.ToString());

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relMembros);



            frm.ShowDialog();
        }

        private void tsImpGrafSitu_Click(object sender, EventArgs e)
        {
            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            BindingSource bs = new BindingSource();

            DataTable dt = new DAO.CrudMembro().RelatorioMembros(DAO.Conexao.con);

            bs.DataSource = dt;

            listBS.Add(bs);

            //recuperar da linha do datatable 
            //total - batizados - membros - casados - inativos
            DataTable data = new DAO.CrudMembro().RelatorioQtdeMembros(DAO.Conexao.con);
            string total, membros, casados, inativos, solteiros, viuvos, divorciados, outros;

            total = data.Rows[0]["TOTAL"].ToString();
            membros = data.Rows[0]["Membros"].ToString();
            casados = data.Rows[0]["Casados"].ToString();
            solteiros = data.Rows[0]["Solteiros"].ToString();
            divorciados = data.Rows[0]["Divorciados"].ToString();
            viuvos = data.Rows[0]["Viuvos"].ToString();
            outros = data.Rows[0]["Outros"].ToString();
            inativos = data.Rows[0]["Inativos"].ToString();

            listTotais.Add(total);
            listTotais.Add(membros);
            listTotais.Add(casados);
            listTotais.Add(inativos);
            listTotais.Add(solteiros);
            listTotais.Add(divorciados);
            listTotais.Add(viuvos);
            listTotais.Add(outros);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
               ig, TiposRel.relQtdeMembros);

            frm.ShowDialog();
        }
    }//Class

    class DarkGrayRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = Color.FromArgb(10, 10, 10);
            using (SolidBrush brush = new SolidBrush(c))
                e.Graphics.FillRectangle(brush, rc);
        }
    }
}//Namespace
