using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmEscola : Form
    {
        Igreja ig;
        Classe cla = new Classe();


        public frmEscola(Igreja ig)
        {
            InitializeComponent();
            this.ig = ig;
        }

        private void pesquisarAlunos()
        {

            BindingSource bs = new BindingSource();

            bs.DataSource = dtgAlunos.DataSource;

            string nome = txtNomePesq.Text.TrimStart().TrimEnd();

            string strFiltro = " NOME LIKE '%" + nome + "%' ";

            string inativo = (chkInativos.Checked ? "" : " AND INATIVO = 0");


            bs.Filter = strFiltro + inativo;

            dtgAlunos.DataSource = bs;


            gbClasseAlunos.Text = "Alunos - " + dtgAlunos.Rows.Count + " registro(s)";



        }

        private void impFichaPresenca(object sender, EventArgs e)
        {

            string nomeClasse = "";

            //verifica se está selecionado no TreeView, se existe classe, se está selecionado o nivel certo no tvw
            switch (tvwExplorar.SelectedNode.Level)
            {
                case 0:
                    MessageBox.Show("Cadastre uma nova classe, ou selecione uma existente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                    break;
                case 1:
                    nomeClasse = tvwExplorar.SelectedNode.Text;
                    break;
                case 2:
                    nomeClasse = tvwExplorar.SelectedNode.Parent.Text;
                    break;
                default:
                    break;
            }



            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            DataTable dt = new DataTable();

            int idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);

            dt = new CrudEscola().listaAlunos(Conexao.con, idClasse, inativos: false);

            BindingSource bs = new BindingSource();

            bs.DataSource = dt;

            listBS.Add(bs);

            listTotais.Add(dt.Rows.Count);

            listTotais.Add(nomeClasse);

            listTotais.Add(null);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relReuniao);

            frm.ShowDialog();


        }

        private void impFichaNull(object sender, EventArgs e)
        {


            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            //  DataGridView dtgTmp = new DataGridView();

            //    int idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);

            // dtgTmp.DataSource = new CrudEscola().listaAlunos(Conexao.con, idClasse, inativos: false);

            BindingSource bs = new BindingSource();

            // bs.DataSource = dtgTmp.DataSource;

            listBS.Add(bs);

            listTotais.Add("0");

            listTotais.Add("");

            listTotais.Add(true);


            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relReuniao);

            frm.ShowDialog();


        }

        private void impAlunos(object sender, EventArgs e)
        {
            string nomeClasse = "";

            //verifica se está selecionado no TreeView, se existe classe, se está selecionado o nivel certo no tvw
            switch (tvwExplorar.SelectedNode.Level)
            {
                case 0:
                    MessageBox.Show("Cadastre uma nova classe, ou selecione uma existente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                    break;
                case 1:
                    nomeClasse = tvwExplorar.SelectedNode.Text;
                    break;
                case 2:
                    nomeClasse = tvwExplorar.SelectedNode.Parent.Text;
                    break;
                default:
                    break;
            }

            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            BindingSource bs = new BindingSource();

            if ((tvwExplorar.SelectedNode.Level == 2) && (tvwExplorar.SelectedNode.Index == 1))
            {
                bs.DataSource = dtgAlunos.DataSource;

                listTotais.Add(dtgAlunos.Rows.Count.ToString());

            }
            else
            {
                DataTable dt = new DataTable();

                int idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);

                dt = new CrudEscola().listaAlunos(Conexao.con, idClasse, inativos: true);

                bs.DataSource = dt;

                listTotais.Add(dt.Rows.Count);
            }

            listBS.Add(bs);

            listTotais.Add(nomeClasse);

            listTotais.Add(null);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relAlunos);

            frm.ShowDialog();

        }

        private void impProfessores(object sender, EventArgs e)
        {
            string nomeClasse = "";

            //verifica se está selecionado no TreeView, se existe classe, se está selecionado o nivel certo no tvw
            switch (tvwExplorar.SelectedNode.Level)
            {
                case 0:
                    MessageBox.Show("Cadastre uma nova classe, ou selecione uma existente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                    break;
                case 1:
                    nomeClasse = tvwExplorar.SelectedNode.Text;
                    break;
                case 2:
                    nomeClasse = tvwExplorar.SelectedNode.Parent.Text;
                    break;
                default:
                    break;
            }



            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            DataTable dt = new DataTable();

            int idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);

            dt = new CrudEscola().listaProfessores(Conexao.con, idClasse);

            BindingSource bs = new BindingSource();

            bs.DataSource = dt;

            listBS.Add(bs);

            listTotais.Add(dt.Rows.Count);

            listTotais.Add(nomeClasse);

            listTotais.Add(null);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relProfessores);

            frm.ShowDialog();

        }

        private void impReunioes(object sender, EventArgs e)
        {
            string nomeClasse = "";

            //verifica se está selecionado no TreeView, se existe classe, se está selecionado o nivel certo no tvw
            switch (tvwExplorar.SelectedNode.Level)
            {
                case 0:
                    MessageBox.Show("Cadastre uma nova classe, ou selecione uma existente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                    break;
                case 1:
                    nomeClasse = tvwExplorar.SelectedNode.Text;
                    break;
                case 2:
                    nomeClasse = tvwExplorar.SelectedNode.Parent.Text;
                    break;
                default:
                    break;
            }



            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            BindingSource bs = new BindingSource();

            if ((tvwExplorar.SelectedNode.Level == 2) && (tvwExplorar.SelectedNode.Index == 2))
            {
                bs.DataSource = dtgReunioes.DataSource;

                listTotais.Add(dtgReunioes.Rows.Count.ToString());

            }
            else
            {
                DataTable dt = new DataTable();

                int idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);

                dt = new CrudEscola().listaReunioes(Conexao.con, idClasse);

                bs.DataSource = dt;

                listTotais.Add(dt.Rows.Count);
            }

            listBS.Add(bs);

            listTotais.Add(nomeClasse);

            listTotais.Add(null);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relReunioes);

            frm.ShowDialog();

        }

        private void impReunioesChart(object sender, EventArgs e)
        {
            string nomeClasse = "";

            //verifica se está selecionado no TreeView, se existe classe, se está selecionado o nivel certo no tvw
            switch (tvwExplorar.SelectedNode.Level)
            {
                case 0:
                    MessageBox.Show("Cadastre uma nova classe, ou selecione uma existente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                    break;
                case 1:
                    nomeClasse = tvwExplorar.SelectedNode.Text;
                    break;
                case 2:
                    nomeClasse = tvwExplorar.SelectedNode.Parent.Text;
                    break;
                default:
                    break;
            }


            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            BindingSource bs = new BindingSource();

            if ((tvwExplorar.SelectedNode.Level == 2) && (tvwExplorar.SelectedNode.Index == 2))
            {
                bs.DataSource = dtgReunioes.DataSource;

                listTotais.Add(dtgReunioes.Rows.Count.ToString());

            }
            else
            {

                int ano = 0;
                int option = 1;

                frmSelMes frmSel = new frmSelMes(selMes: false, selAno: true, dinamico: false, option: option);

                frmSel.ShowDialog();

                if (frmSel.DialogResult != DialogResult.OK)
                    return;

                ano = frmSel.ano;

                DataTable dt = new DataTable();

                int idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);

                dt = new CrudEscola().listaReunioes(Conexao.con, idClasse, ano);

                bs.DataSource = dt;

                listTotais.Add(dt.Rows.Count);
            }

            listBS.Add(bs);

            listTotais.Add(nomeClasse);

            listTotais.Add(null);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relReunioesChart);

            frm.ShowDialog();

        }

        private void impClasses(object sender, EventArgs e)
        {


            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            DataTable dt = new DataTable();

            int idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);

            dt = new CrudEscola().listaClasses(Conexao.con, true);

            BindingSource bs = new BindingSource();

            bs.DataSource = dt;

            listBS.Add(bs);

            listTotais.Add(dt.Rows.Count);

            //listTotais.Add(nomeClasse);

            listTotais.Add(null);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relClasses);

            frm.ShowDialog();
        }

        private void frmEscola_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
                dtgClasses.RowTemplate.MinimumHeight = Program.heightGrid;
            if (Program.tablet)
                dtgProfessores.RowTemplate.MinimumHeight = Program.heightGrid;
            if (Program.tablet)
                dtgAlunos.RowTemplate.MinimumHeight = Program.heightGrid;
            if (Program.tablet)
                dtgReunioes.RowTemplate.MinimumHeight = Program.heightGrid;

            carregaClasses();

        }

        private void impRelAlunos(object sender, EventArgs e)
        {

            frmSelClasseAno frm = new frmSelClasseAno(ig);

            frm.ShowDialog();

        }

        private void fastCadastro(object sender, EventArgs e)
        {

            Reuniao r = new Reuniao();

            r.id = 0;

            frmReuniao frm = new frmReuniao(r, fast: true, clI: false);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                carregaClasses();
            }


        }

        private void mostrarClassesInativas(object sender, EventArgs e)
        {
            carregaClasses();

        }

        private void Maius_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }

        }

        private void carregaAlunos(int idClasse)
        {

            //ativa GroupBox
            gbClasseAlunos.Visible = true;
            gbClasseAlunos.BringToFront();

            dtgAlunos.DataSource = new CrudEscola().listaAlunos(Conexao.con, idClasse, true);

            dtgAlunos.Columns["IDMembro"].Visible = false;

            //carrega combo alunos
            cbAlunos.DataSource = new CrudMembro().listaMembros(Conexao.con, "WHERE INATIVO = 0 ORDER BY NOME ");
            cbAlunos.DisplayMember = "NOME";
            cbAlunos.ValueMember = "ID";

            cbAlunos.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbAlunos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;


            dtgAlunos.Columns["IdColor"].Visible = false;


            pesquisarAlunos();

            //cores

        }

        private void carregaReunioes(int idClasse)
        {

            //ativa GroupBox
            gbReuniao.Visible = true;
            gbReuniao.BringToFront();

            dtgReunioes.DataSource = new CrudEscola().listaReunioes(Conexao.con, idClasse);

            //filtrar ou nao?
            DataTable dt = new CrudEscola().listaAnosReunioes(Conexao.con, idClasse);
            cbAno.Items.Clear();

            if (dt.Rows.Count > 0)
            {


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbAno.Items.Add(dt.Rows[i]["Ano"].ToString());
                }


            }


            cbAno.Items.Insert(0, "-- SELECIONE --");


            gbReuniao.Text = "Reuniões - " + dtgReunioes.Rows.Count + " registro(s)";

            //filtrar para o ano selecionado
            cbAno.SelectedIndex = cbAno.Items.IndexOf(DateTime.Now.Year.ToString());
            filtrarReunioes();



        }


        private void carregaProfessores(int idClasse)
        {

            //ativa GroupBox
            gbProfessores.Visible = true;
            gbProfessores.BringToFront();

            dtgProfessores.DataSource = new CrudEscola().listaProfessores(Conexao.con, idClasse);

            dtgProfessores.Columns["IdMembro"].Visible = false;

            //carrega combo alunos
            cbProfessores.DataSource = new CrudMembro().listaMembros(Conexao.con, " WHERE INATIVO = 0 ORDER BY NOME ");
            cbProfessores.DisplayMember = "NOME";
            cbProfessores.ValueMember = "ID";

            cbProfessores.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbProfessores.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }

        private void carregaClasses()
        {

            gbClasses.BringToFront();

            cla = new Classe();
            cla.id = 0;
            txtDesc.Clear();

            DataTable dt = new CrudEscola().listaClasses(Conexao.con, inativosMenu.Checked);


            dtgClasses.DataSource = dt;

            dtgClasses.Columns["Ultima"].HeaderText = "Última Reunião";

            tvwExplorar.Nodes.Clear();


            TreeNode root = new TreeNode("Classes", 0, 0);
            tvwExplorar.Nodes.Add(root);



            foreach (DataRow row in dt.Rows)
            {

                TreeNode newNode = new TreeNode(row["Descrição"].ToString(), 5, 5);
                newNode.Tag = row["ID"].ToString();

                TreeNode nChild;
                nChild = new TreeNode("Professores", 1, 1);
                nChild.Tag = row["Id"].ToString();
                newNode.Nodes.Add(nChild);

                nChild = new TreeNode("Alunos", 2, 2);
                nChild.Tag = row["Id"].ToString();
                newNode.Nodes.Add(nChild);

                nChild = new TreeNode("Reuniões", 3, 3);
                nChild.Tag = row["Id"].ToString();
                newNode.Nodes.Add(nChild);

                newNode.Collapse();

                root.Nodes.Add(newNode);

            }

            root.Expand();



        }



        private void frmEscola_Activated(object sender, EventArgs e)
        {


        }

        private void gbTeste_Enter(object sender, EventArgs e)
        {

        }

        private void cadastrarMenu_Click(object sender, EventArgs e)
        {
            carregaClasses();
        }

        private void tvwExplorar_AfterExpand(object sender, TreeViewEventArgs e)
        {

        }

        private void tvwExplorar_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            //expandir Depth 1
            TreeNode node = e.Node;

            if (!node.IsExpanded)
            {
                node.Expand();

                if (node.Level == 2)
                {

                    switch (node.Index)
                    {
                        case 0:
                            carregaProfessores(Convert.ToInt32(node.Tag.ToString()));
                            //professores
                            break;

                        case 1:
                            carregaAlunos(Convert.ToInt32(node.Tag.ToString()));
                            //alunos
                            break;

                        case 2:
                            carregaReunioes(Convert.ToInt32(node.Tag.ToString()));
                            //reunioes
                            break;

                        default:
                            break;
                    }//switch case index


                }//if level


            }
            else
            {


                if (node.Level == 0)
                {


                    carregaClasses();
                }
                else
                    node.Collapse();
            }
        }

        private DataGridView dtFull(DataGridView dt1)
        {


            BindingSource bs = new BindingSource();

            bs.DataSource = dt1.DataSource;

            bs.Filter = "";

            dt1.DataSource = bs.DataSource;

            return (dt1);
        }

        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            if (cbAlunos.SelectedValue == null)
            {
                MessageBox.Show("Selecione um membro válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbAlunos.Focus();
                return;
            }

            int idMembro = Convert.ToInt32(cbAlunos.SelectedValue);

            DataGridView dtTemp = dtFull(dtgAlunos);

            foreach (DataGridViewRow row in dtTemp.Rows)
            {

                if (idMembro == Convert.ToInt32(row.Cells["IdMembro"].Value))
                {
                    MessageBox.Show("O membro " + cbAlunos.Text + " já está matriculado nesta classe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbAlunos.Focus();
                    return;
                }


            }

            new CrudEscola().cadAluno(Conexao.con, Convert.ToInt32(tvwExplorar.SelectedNode.Tag),
                            idMembro);

            MessageBox.Show("Dados salvos com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            carregaAlunos(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));

            cbAlunos.Focus();

        }

        private void editarMenu_Click(object sender, EventArgs e)
        {
            if (dtgClasses.SelectedRows.Count == 0)
                return;



            cla.id = Convert.ToInt32(dtgClasses.SelectedRows[0].Cells["ID"].Value);
            cla.desc = dtgClasses.SelectedRows[0].Cells["Descrição"].Value.ToString();

            txtDesc.Text = cla.desc;

            txtDesc.Focus();


        }

        private void dtgClasses_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgClasses.HitTest(e.X, e.Y);
                dtgClasses.ClearSelection();

                if (hti.RowIndex < 0)
                {
                    editarMenu.Enabled = false;
                    statusMenu.Enabled = false;
                    return;
                }
                else
                {
                    editarMenu.Enabled = true;
                    statusMenu.Enabled = true;

                    dtgClasses.Rows[hti.RowIndex].Selected = true;

                }
            }//if
        }

        private void statusMenu_Click(object sender, EventArgs e)
        {
            if (dtgClasses.SelectedRows.Count == 0)
                return;

            int id = Convert.ToInt32(dtgClasses.SelectedRows[0].Cells["Id"].Value);

            string status = ((Convert.ToBoolean(dtgClasses.SelectedRows[0].Cells["Inativo"].Value)) ? " ATIVAR " : " DESATIVAR ");

            string nome = dtgClasses.SelectedRows[0].Cells["Descrição"].Value.ToString();

            if (MessageBox.Show("Deseja " + status + " a classe " + nome + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                new CrudEscola().altStatusClasse(Conexao.con, id);

                carregaClasses();

            }


        }

        private void dtgAlunos_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgAlunos.HitTest(e.X, e.Y);
                dtgAlunos.ClearSelection();

                if (hti.RowIndex < 0)
                {
                    removerAluno.Enabled =
                        históricoDePontuaçãoToolStripMenuItem.Enabled =
                        pontuarToolStripMenuItem.Enabled =
                        statusAluno.Enabled = false;
                    return;
                }
                else
                {
                    removerAluno.Enabled =
                        históricoDePontuaçãoToolStripMenuItem.Enabled =
                        pontuarToolStripMenuItem.Enabled =
                        statusAluno.Enabled = true;

                    dtgAlunos.Rows[hti.RowIndex].Selected = true;

                }
            }//if
        }

        private void dtgAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusAluno_Click(object sender, EventArgs e)
        {
            if (dtgAlunos.SelectedRows.Count == 0)
                return;

            int id = Convert.ToInt32(dtgAlunos.SelectedRows[0].Cells["Id"].Value);

            string status = ((Convert.ToBoolean(dtgAlunos.SelectedRows[0].Cells["Inativo"].Value)) ? " ATIVAR " : " DESATIVAR ");

            string nome = dtgAlunos.SelectedRows[0].Cells["Nome"].Value.ToString();

            if (MessageBox.Show("Deseja " + status + " o aluno " + nome + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                new CrudEscola().altStatusAluno(Conexao.con, id);

                carregaAlunos(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));

            }
        }

        private void removerAluno_Click(object sender, EventArgs e)
        {
            if (dtgAlunos.SelectedRows.Count == 0)
                return;

            int id = Convert.ToInt32(dtgAlunos.SelectedRows[0].Cells["Id"].Value);

            // string status = ((Convert.ToBoolean(dtgAlunos.SelectedRows[0].Cells["Inativo"].Value)) ? " ATIVAR " : " DESATIVAR ");

            string nome = dtgAlunos.SelectedRows[0].Cells["Nome"].Value.ToString();

            if (MessageBox.Show("Deseja remover o aluno " + nome + "? \n" +
                " Isso implica em remover todos os registros de reuniões para o aluno"
                , "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                new CrudEscola().removeAluno(Conexao.con, id);

                carregaAlunos(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));

            }
        }

        private void cmsProfessores_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            if (cbProfessores.SelectedValue == null)
            {
                MessageBox.Show("Selecione um membro válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbProfessores.Focus();
                return;
            }

            int idMembro = Convert.ToInt32(cbProfessores.SelectedValue);

            DataGridView dtTemp = dtFull(dtgProfessores);

            foreach (DataGridViewRow row in dtTemp.Rows)
            {

                if (idMembro == Convert.ToInt32(row.Cells["IdMembro"].Value))
                {
                    MessageBox.Show("O membro " + cbProfessores.Text + " já está definido como professor nesta classe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbProfessores.Focus();
                    return;
                }


            }

            new CrudEscola().cadProfessor(Conexao.con, Convert.ToInt32(tvwExplorar.SelectedNode.Tag), idMembro);

            MessageBox.Show("Dados salvos com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            carregaProfessores(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));
        }

        private void cbProfessores_Leave(object sender, EventArgs e)
        {
            //se existe fill Membro
            //senao oferece para Cadastrar membro

            if (cbProfessores.Text.Trim() == "")
                return;

            //testes com o conteudo do Combobox

            int id;
            string nome = cbProfessores.Text, nome2;

            foreach (DataRowView drv in cbProfessores.Items)
            {

                //vou passar por todos as linhas da tabela que contem os membros

                nome2 = drv.Row.ItemArray[1].ToString();

                if (nome2.Equals(nome))
                {

                    id = Convert.ToInt32(drv.Row.ItemArray[0].ToString());
                    cbProfessores.SelectedValue = id;
                    break;
                }

            }


            if (cbProfessores.SelectedValue == null)
            {

                if (MessageBox.Show("Membro: " + cbProfessores.Text + " não existe! Desejar realizar o cadastro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Membro m = new Membro();

                    m.id = 0;

                    frmAltMembro frm = new frmAltMembro(m);

                    frm.ShowDialog();

                    //retorno do form

                    carregaProfessores(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));

                }
                else
                {
                    //não quer cadastrar
                    cbProfessores.ResetText();

                }

            }
            else
            {
                //membro existe


            }
        }

        private void cbProfessores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgReunioes_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgReunioes.HitTest(e.X, e.Y);
                dtgReunioes.ClearSelection();

                if (hti.RowIndex < 0)
                {
                    editarReuniao.Enabled =
                        tsChamadaReuniao.Enabled =
                    removerReuniao.Enabled = false;
                    return;
                }
                else
                {
                    editarReuniao.Enabled =
                        tsChamadaReuniao.Enabled =
                    removerReuniao.Enabled = true;

                    dtgReunioes.Rows[hti.RowIndex].Selected = true;

                }
            }//if


        }

        private void cadastrarReuniao_Click(object sender, EventArgs e)
        {

            Reuniao r = new Reuniao();

            r.id = 0;
            r.idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);

            frmReuniao frm = new frmReuniao(r, clI: false);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {

                carregaReunioes(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));
            }


        }

        private void editarReuniao_Click(object sender, EventArgs e)
        {

            if (dtgReunioes.SelectedRows.Count == 0)
                return;

            Reuniao r = new Reuniao();

            //id, idClasse, data, obs, oferta, biblias, visitantes, revistas

            r.id = Convert.ToInt32(dtgReunioes.SelectedRows[0].Cells["Id"].Value);
            r.idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);
            r.data = Convert.ToDateTime(dtgReunioes.SelectedRows[0].Cells["Data"].Value);
            r.biblias = Convert.ToInt32(dtgReunioes.SelectedRows[0].Cells["Biblias"].Value);
            r.revistas = Convert.ToInt32(dtgReunioes.SelectedRows[0].Cells["Revistas"].Value);
            r.visitantes = Convert.ToInt32(dtgReunioes.SelectedRows[0].Cells["Visitantes"].Value);
            r.obs = dtgReunioes.SelectedRows[0].Cells["Observação"].Value.ToString();

            frmReuniao frm = new frmReuniao(r);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {

                carregaReunioes(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));
            }


        }

        private void frmEscola_Deactivate(object sender, EventArgs e)
        {

        }

        private void cbAlunos_Leave(object sender, EventArgs e)
        {
            //se existe fill Membro
            //senao oferece para Cadastrar membro

            if (cbAlunos.Text.Trim() == "")
                return;

            //testes com o conteudo do Combobox

            int id;
            string nome = cbAlunos.Text, nome2;

            foreach (DataRowView drv in cbAlunos.Items)
            {

                //vou passar por todos as linhas da tabela que contem os membros

                nome2 = drv.Row.ItemArray[1].ToString();

                if (nome2.Equals(nome))
                {

                    id = Convert.ToInt32(drv.Row.ItemArray[0].ToString());
                    cbAlunos.SelectedValue = id;
                    break;
                }

            }


            if (cbAlunos.SelectedValue == null)
            {

                if (MessageBox.Show("Membro: " + cbAlunos.Text + " não existe! Desejar realizar o cadastro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Membro m = new Membro();

                    m.id = 0;

                    frmAltMembro frm = new frmAltMembro(m);

                    frm.ShowDialog();

                    //retorno do form

                    carregaAlunos(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));

                }
                else
                {
                    //não quer cadastrar
                    cbAlunos.ResetText();

                }

            }
            else
            {
                //membro existe

            }


        }//fim do procedimento

        private void txtNomePesq_TextChanged(object sender, EventArgs e)
        {
            pesquisarAlunos();
        }

        private void chkInativos_CheckedChanged(object sender, EventArgs e)
        {
            pesquisarAlunos();
        }

        private void gbReunioesFiltro_Enter(object sender, EventArgs e)
        {

        }

        private void filtrarReunioes()
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dtgReunioes.DataSource;

            string strFiltro = "";

            if (cbAno.SelectedIndex < 1)
            {


            }
            else
            {


                int ano = Convert.ToInt32(cbAno.Text);

                string mes = (cbMes.SelectedIndex > 0 ? cbMes.SelectedIndex.ToString() : String.Empty);

                strFiltro = " DATA  >= '01/" + (mes == String.Empty ? "01" : mes) + "/" + ano + "'" +
                                   " AND DATA <= '" +
                                   (mes == String.Empty ? "31" : DateTime.DaysInMonth(ano, Convert.ToInt32(mes)).ToString()) +
                                   "/" + (mes == String.Empty ? "12" : mes) + "/" + cbAno.Text + "'";
            }

            bs.Filter = strFiltro;

            dtgReunioes.DataSource = bs;

            //lblRegistros

            gbReuniao.Text = "Reuniões - " + dtgReunioes.Rows.Count + " registro(s)";
        }

        private void btnFiltrarReuniao_Click(object sender, EventArgs e)
        {
            filtrarReunioes();

        }

        private void removerProfessores_Click(object sender, EventArgs e)
        {

            if (dtgProfessores.SelectedRows.Count == 0)
                return;

            int idProfessor = Convert.ToInt32(dtgProfessores.SelectedRows[0].Cells["Id"].Value);

            string nome = dtgProfessores.SelectedRows[0].Cells["Nome"].Value.ToString();

            if (MessageBox.Show("Deseja remover o professor " + nome + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                new CrudEscola().removeProfessor(Conexao.con, idProfessor);

                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carregaProfessores(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));
            }


        }

        private void removerReuniao_Click(object sender, EventArgs e)
        {
            if (dtgReunioes.SelectedRows.Count == 0)
                return;

            int id = Convert.ToInt32(dtgReunioes.SelectedRows[0].Cells["Id"].Value);

            if (MessageBox.Show("Deseja remover a reunião de ID: " + id + "?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                new CrudEscola().removeReuniao(Conexao.con, id);
                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregaReunioes(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));
            }


        }

        private void tvwExplorar_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void cbAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            frmHome f = (frmHome)this.Owner;

            if (!f.Visible)

                f.aparecer();
        }

        private void frmEscola_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pnSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtDesc.Text.TrimStart().TrimStart().Length <= 2)
            {

                MessageBox.Show("Descrição inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDesc.Focus();


            }
            else
            {

                cla.desc = txtDesc.Text.TrimStart().TrimStart();
                new CrudEscola().alteraClasse(Conexao.con, cla);

                MessageBox.Show("Dados salvos com sucesso",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                carregaClasses();
            }
        }

        private void gbProfessores_Enter(object sender, EventArgs e)
        {

        }

        private void btnPontos_Click(object sender, EventArgs e)
        {

            PontoAluno pt = new PontoAluno();
            pt.id = 0;

            frmPontuar frm = new frmPontuar(pt);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {

                carregaClasses();

            }


        }

        private void históricoDePontuaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dtgAlunos.SelectedRows.Count == 0)
                return;

            Aluno a = new Aluno();

            a.id = Convert.ToInt32(dtgAlunos.SelectedRows[0].Cells["Id"].Value);

            a.nome = dtgAlunos.SelectedRows[0].Cells["Nome"].Value.ToString();

            a.idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);

            a.nomeClasse = tvwExplorar.SelectedNode.Parent.Text;

            frmHistorico frm = new frmHistorico(a);

            frm.ShowDialog();


            carregaAlunos(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));


        }

        private void pontuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgAlunos.SelectedRows.Count == 0)
                return;

            Aluno a = new Aluno();

            a.id = Convert.ToInt32(dtgAlunos.SelectedRows[0].Cells["Id"].Value);

            a.nome = dtgAlunos.SelectedRows[0].Cells["Nome"].Value.ToString();

            a.idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);

            a.nomeClasse = tvwExplorar.SelectedNode.Parent.Text;

            PontoAluno pt = new PontoAluno();

            pt.id = 0;

            frmPontuar frm = new frmPontuar(pt, a);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                carregaAlunos(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));
            }
        }

        private void resetarPontuaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar todo o histórico de pontuação \n" +
                "da classe: " + tvwExplorar.SelectedNode.Parent.Text + "?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                new CrudEscola().resetaPontos(Conexao.con, Convert.ToInt32(tvwExplorar.SelectedNode.Tag));
                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregaAlunos(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));
            }


        }

        private void impimirReuniao_Click(object sender, EventArgs e)
        {

            if (dtgReunioes.SelectedRows.Count == 0)
                return;

            Reuniao r = new Reuniao();

            //id, idClasse, data, obs, oferta, biblias, visitantes, revistas

            r.id = Convert.ToInt32(dtgReunioes.SelectedRows[0].Cells["Id"].Value);
            r.idClasse = Convert.ToInt32(tvwExplorar.SelectedNode.Tag);
            r.data = Convert.ToDateTime(dtgReunioes.SelectedRows[0].Cells["Data"].Value);
            r.biblias = Convert.ToInt32(dtgReunioes.SelectedRows[0].Cells["Biblias"].Value);
            r.revistas = Convert.ToInt32(dtgReunioes.SelectedRows[0].Cells["Revistas"].Value);
            r.visitantes = Convert.ToInt32(dtgReunioes.SelectedRows[0].Cells["Visitantes"].Value);
            r.oferta = Convert.ToDecimal(dtgReunioes.SelectedRows[0].Cells["Oferta"].Value);
            r.obs = dtgReunioes.SelectedRows[0].Cells["Observação"].Value.ToString();

            string nomeClasse = "";


            nomeClasse = tvwExplorar.SelectedNode.Parent.Text;

            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();
            BindingSource bs = new BindingSource();


            //Alunos da reuniao
            DataTable dt = new CrudEscola().listaAlunosReuniao(Conexao.con, r.id);

            bs.DataSource = dt;

            listBS.Add(bs);

            listTotais.Add(dt.Rows.Count.ToString());

            listTotais.Add(nomeClasse);

            listTotais.Add(r.data);

            listTotais.Add(r.biblias);
            listTotais.Add(r.revistas);
            listTotais.Add(r.visitantes);
            listTotais.Add(r.oferta);

            listTotais.Add(r.obs);

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.chamadaReuniao);

            frm.ShowDialog();


        }

        private void cmsReunioes_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cbIdColorAluno_Click(object sender, EventArgs e)
        {

        }

        private void cbIdColorAluno_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dtgAlunos.SelectedRows.Count == 0)
                return;

            int id = Convert.ToInt32(dtgAlunos.SelectedRows[0].Cells["Id"].Value);

            new CrudEscola().alteraColorAluno(Conexao.con, cbIdColorAluno.SelectedIndex, id);



            carregaAlunos(Convert.ToInt32(tvwExplorar.SelectedNode.Tag));

        }

        private Color corAluno(int idcor)
        {

            switch (idcor)
            {

                case 0:
                    return (Color.Black);
                    break;
                case 1:
                    return (Color.Red);
                    break;
                case 2:
                    return (Color.Green);
                    break;

                case 3:
                    return (Color.Brown);
                    break;
                default:
                    return (Color.Black);
                    break;
            }


        }

        private void dtgAlunos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            int idCor = Convert.ToInt32(dtgAlunos.Rows[e.RowIndex].Cells["idColor"].Value.ToString());

            dtgAlunos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = corAluno(idCor), BackColor = Color.White };

        }

        private void menuImp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmEscola_Enter(object sender, EventArgs e)
        {
            frmHome frm = (frmHome)this.MdiParent;

            frm.esconder();

            frm.marcarBotoes(frm.btnEscola);
        }











        // zona de segurança

    }//Classe
}//Namespace
