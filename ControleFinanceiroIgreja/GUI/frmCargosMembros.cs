using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmCargosMembros : Form
    {

        BindingSource bs = new BindingSource();
        Igreja ig;

        public frmCargosMembros(Igreja ig)
        {
            InitializeComponent();

            this.ig = ig;
        }


        private void filtrar(object sender, EventArgs e)
        {

            if ((txtAno.Text.Length < 4) && (txtAno.Text.Length > 0))
            {

                MessageBox.Show("Informe um ano válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAno.Focus();
                return;
            }

            int ano;

            if (txtAno.Text == "")
            {

                ano = 0;
            }
            else
            {

                ano = Convert.ToInt32(txtAno.Text);


            }



            dtgCargosOcup.DataSource = new CrudCargos().listaCargosOcupados(Conexao.con, ano);

            this.bs.DataSource = dtgCargosOcup.DataSource;




        }

        private void imprimir(object sender, EventArgs e)
        {

            List<BindingSource> listBS = new List<BindingSource>();
            List<Object> listTotais = new List<Object>();

            listBS.Add(this.bs);
            listTotais.Add(dtgCargosOcup.Rows.Count.ToString());

            if ((txtAno.Text != "") && (txtAno.TextLength == 4))
                listTotais.Add("Ativos no ano: " + txtAno.Text);
            else
                listTotais.Add("");

            frmVerRelatorio frm = new frmVerRelatorio(listBS, listTotais,
                ig, TiposRel.relCargos);

            frm.ShowDialog();
        }


        private void frmCargosMembros_Load(object sender, EventArgs e)
        {
            if (Program.tablet)
                dtgCargos.RowTemplate.MinimumHeight = Program.heightGrid;
            if (Program.tablet)
                dtgCargosOcup.RowTemplate.MinimumHeight = Program.heightGrid;

            carregaCargos();
            carregaCargosOcupados();
            this.bs.DataSource = dtgCargosOcup.DataSource;


        }



        private void carregaCargosOcupados()
        {

            dtgCargosOcup.DataSource = new CrudCargos().listaCargosOcupados(Conexao.con);


        }

        private void carregaCargos()
        {

            dtgCargos.DataSource = new CrudCargos().listaCargos(Conexao.con);




        }

        private void cadastrarMenu_Click(object sender, EventArgs e)
        {

            Cargo ca = new Cargo();

            ca.id = 0;

            frmAltCargo frm = new frmAltCargo(ca);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {

                carregaCargos();
            }


        }

        private void editarMenu_Click(object sender, EventArgs e)
        {

            if (dtgCargos.SelectedRows.Count == 0)
                return;

            Cargo ca = new Cargo();

            ca.id = Convert.ToInt32(dtgCargos.SelectedRows[0].Cells["ID"].Value);
            ca.desc = dtgCargos.SelectedRows[0].Cells["Descricao"].Value.ToString();



            frmAltCargo frm = new frmAltCargo(ca);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {

                carregaCargos();
                carregaCargosOcupados();
            }

        }

        private void cbCargos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {

                e.KeyChar = Char.ToUpper(e.KeyChar);

            }

        }

        private void dtgCargos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgCargos.HitTest(e.X, e.Y);
                dtgCargos.ClearSelection();

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

                    dtgCargos.Rows[hti.RowIndex].Selected = true;

                }


            }
        }

        private void removerMenu_Click(object sender, EventArgs e)
        {
            if (dtgCargos.SelectedRows.Count == 0)
                return;

            string desc = dtgCargos.SelectedRows[0].Cells["Descricao"].Value.ToString();

            if (MessageBox.Show("Deseja remover o cargo '" + desc + "'?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int id = Convert.ToInt32(dtgCargos.SelectedRows[0].Cells["ID"].Value);

                new CrudCargos().removeCargo(Conexao.con, id);

                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carregaCargos();
                carregaCargosOcupados();

            }





        }

        private void dtgCargosOcup_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgCargosOcup.HitTest(e.X, e.Y);
                dtgCargosOcup.ClearSelection();

                if (hti.RowIndex < 0)
                {
                    editarOcupados.Enabled = false;
                    removerOcupados.Enabled = false;
                    return;
                }
                else
                {
                    editarOcupados.Enabled = true;
                    removerOcupados.Enabled = true;

                    dtgCargosOcup.Rows[hti.RowIndex].Selected = true;

                }


            }
        }

        private void cadastrarOcupados_Click(object sender, EventArgs e)
        {

            if (dtgCargos.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre primeiro algum cargo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CargoMembro cm = new CargoMembro();

            cm.id = 0;


            frmAltCargoMembro frm = new frmAltCargoMembro(cm);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {

                carregaCargosOcupados();
            }



        }

        private void editarOcupados_Click(object sender, EventArgs e)
        {

            if (dtgCargosOcup.SelectedRows.Count == 0)
                return;

            CargoMembro cm = new CargoMembro();

            cm.id = Convert.ToInt32(dtgCargosOcup.SelectedRows[0].Cells["Id"].Value);

            frmAltCargoMembro frm = new frmAltCargoMembro(cm);


            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {

                carregaCargosOcupados();
            }


        }

        private void frmCargosMembros_Activated(object sender, EventArgs e)
        {



        }

        private void removerOcupados_Click(object sender, EventArgs e)
        {
            if (dtgCargosOcup.SelectedRows.Count == 0)
                return;

            string desc = dtgCargosOcup.SelectedRows[0].Cells["Descricao"].Value.ToString();
            string nome = dtgCargosOcup.SelectedRows[0].Cells["Membro"].Value.ToString();

            if (MessageBox.Show("Deseja remover o cargo '" + desc + "' do membro '" + nome + "'?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int id = Convert.ToInt32(dtgCargosOcup.SelectedRows[0].Cells["ID"].Value);

                new CrudCargos().removeCargoOcupado(Conexao.con, id);

                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carregaCargosOcupados();

            }
        }

        private void frmCargosMembros_Deactivate(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void frmCargosMembros_Shown(object sender, EventArgs e)
        {

            dtgCargosOcup.Columns["Membro"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void tsAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void impFichaNull(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void impFichaSelecionado(object sender, EventArgs e)
        {

        }

        private void ribRelMemNiver_Click(object sender, EventArgs e)
        {

        }

        private void ribRelMemSexo_Click(object sender, EventArgs e)
        {

        }

        private void ribRelMemQtde_Click(object sender, EventArgs e)
        {

        }

        private void frmCargosMembros_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void frmCargosMembros_Enter(object sender, EventArgs e)
        {
            frmHome frm = (frmHome)this.MdiParent;

            frm.esconder();

            frm.marcarBotoes(frm.btnCargos);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAno_KeyUp(object sender, KeyEventArgs e)
        {
            lblDesc.Visible = txtAno.Text.Length == 0;
        }
    }
}
