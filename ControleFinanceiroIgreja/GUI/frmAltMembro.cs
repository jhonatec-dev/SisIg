using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmAltMembro : Form
    {
        private Membro membro;
        Visitantes vis;

        public frmAltMembro(Membro m, Visitantes visitante = null)
        {
            InitializeComponent();
            this.membro = m;
            this.vis = visitante;

        }




        private void rbFem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void carregaHistorico()
        {

            dtgHistorico.DataSource = new CrudMembro().listaHistorico(Conexao.con, this.membro.id);

        }

        private void frmAltMembro_Load(object sender, EventArgs e)
        {
            carregaAdmissao();
            carregaStatus();

            if (Program.tablet)
            {
                tabContato.Font = new Font(tabContato.Font.FontFamily, 16);
            }

            if (vis != null)
            {
                txtNome.Text = vis.nome;
                dtNasc.Value = vis.dtnasc;
                txtCPF.Text = vis.cpf;
                txtRG.Text = vis.rg;
                rbFem.Checked = vis.sexo.Trim().Equals("FEM");
                txtEndereco.Text = vis.endereco;
                txtBairro.Text = vis.bairro;
                txtCidade.Text = vis.cidade;



                cbEstadoCivil.SelectedIndex = cbEstadoCivil.Items.IndexOf(vis.estadoCivil);

                if (vis.estadoCivil == "CASADO")
                {
                    dtCasamento.Value = DateTime.Parse(vis.dtCasamento);
                    dtCasamento.Enabled = true;
                }

                txtTitEleitor.Text = vis.titEleitor;
                txtNomePai.Text = vis.nomePai;
                txtNomeMae.Text = vis.nomeMae;
                txtObs.Text = vis.obs;

                cbUF.Text = vis.uf;
                txtCEP.Text = vis.cep;
                txtTel1.Text = vis.tel1;
                txtTel2.Text = vis.tel2;
                txtEmail.Text = vis.email;

                txtLocalNascimento.Text = vis.localNascimento;
                txtProfissao.Text = vis.profissao;

                return;
            }

            if (membro.id > 0)
            {
                membro = new CrudMembro().getMembro(Conexao.con, membro.id);

                txtNome.Text = membro.nome;
                dtNasc.Value = membro.dtnasc;
                txtCPF.Text = membro.cpf;
                txtRG.Text = membro.rg;
                rbFem.Checked = membro.sexo.Trim().Equals("FEM");
                txtEndereco.Text = membro.endereco;
                txtBairro.Text = membro.bairro;
                txtCidade.Text = membro.cidade;
                lblID.Text = "ID: " + membro.id;

                txtProfissao.Text = membro.profissao;
                txtLocalNascimento.Text = membro.localNascimento;
                txtProcedencia.Text = membro.procedencia;

                gbHistorico.Enabled = true;
                carregaHistorico();


                lblStatus.Visible = true;
                lblID.Visible = true;

                lblHistorico.Visible = false;


                if (membro.inativo)
                {
                    lblStatus.Text = "Membro inativo";

                }
                else
                {
                    lblStatus.Text = "Membro ativo";
                }

                if (membro.dtmembro == "")
                {
                    dtMembro.Visible = false;

                }
                else
                {
                    dtMembro.Value = DateTime.Parse(membro.dtmembro);
                    dtMembro.Visible = true;
                    chkMembro.Checked = true;
                }

                cbEstadoCivil.SelectedIndex = cbEstadoCivil.Items.IndexOf(membro.estadoCivil);

                if (membro.estadoCivil == "CASADO")
                {
                    dtCasamento.Value = DateTime.Parse(membro.dtCasamento);
                    dtCasamento.Enabled = true;
                }

                txtTitEleitor.Text = membro.titEleitor;
                txtNomePai.Text = membro.nomePai;
                txtNomeMae.Text = membro.nomeMae;
                txtObs.Text = membro.obs;

                cbUF.Text = membro.uf;
                txtCEP.Text = membro.cep;
                txtTel1.Text = membro.tel1;
                txtTel2.Text = membro.tel2;
                txtEmail.Text = membro.email;

                //admissao e status
                cbAdmissao.SelectedValue = membro.idAdmissao;
                cbStatus.SelectedValue = membro.idSituacao;
            }
            else
            {
                cbEstadoCivil.SelectedIndex = 0;

            }

            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            if (txtNome.Text.TrimStart().TrimEnd().Length <= 2)
            {
                MessageBox.Show("Nome inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }

            membro.nome = txtNome.Text.TrimStart().TrimEnd();
            membro.dtnasc = dtNasc.Value;
            membro.cpf = txtCPF.Text;
            membro.rg = txtRG.Text;
            membro.sexo = (rbMasc.Checked) ? "MASC" : "FEM";
            membro.endereco = txtEndereco.Text;
            membro.bairro = txtBairro.Text;
            membro.cidade = txtCidade.Text;

            membro.profissao = txtProfissao.Text;
            membro.localNascimento = txtLocalNascimento.Text;
            membro.procedencia = txtProcedencia.Text;

            if (chkMembro.Checked)
            {
                membro.dtmembro = dtMembro.Value.ToShortDateString();

                if (cbAdmissao.SelectedIndex < 0)
                    membro.idAdmissao = 0;
                else
                    membro.idAdmissao = Convert.ToInt32(cbAdmissao.SelectedValue);
            }
            else
            {
                membro.dtmembro = null;
                membro.idAdmissao = 0;
            }


            membro.estadoCivil = cbEstadoCivil.Text;

            if (cbEstadoCivil.SelectedIndex == 1)
            {
                membro.dtCasamento = dtCasamento.Value.ToShortDateString();
            }
            else
                membro.dtCasamento = null;

            membro.titEleitor = txtTitEleitor.Text;
            membro.nomePai = txtNomePai.Text;
            membro.nomeMae = txtNomeMae.Text;
            membro.obs = txtObs.Text;

            membro.uf = cbUF.Text;
            membro.cep = txtCEP.Text;
            membro.tel1 = txtTel1.Text;
            membro.tel2 = txtTel2.Text;
            membro.email = txtEmail.Text;

            //admissao e situacao do membro



            if (cbStatus.SelectedIndex < 0)
                membro.idSituacao = 0;
            else
                membro.idSituacao = Convert.ToInt32(cbStatus.SelectedValue);

            new CrudMembro().alteraMembro(Conexao.con, membro);

            // MessageBox.Show("Dados salvos com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;




        }

        private void chkBatismo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMembro_CheckedChanged(object sender, EventArgs e)
        {
            dtMembro.Visible = chkMembro.Checked;
            cbAdmissao.Enabled = chkMembro.Checked;

            if (chkMembro.Checked && cbAdmissao.Items.Count > 0)
                cbAdmissao.SelectedIndex = 0;

        }

        private void chkCasamento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtBatismo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtMembro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtCasamento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.SelectAll();
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.SelectAll();
        }

        private void txtRG_Enter(object sender, EventArgs e)
        {
            txtRG.SelectAll();
        }

        private void txtEndereco_Enter(object sender, EventArgs e)
        {
            txtEndereco.SelectAll();
        }

        private void txtBairro_Enter(object sender, EventArgs e)
        {
            txtBairro.SelectAll();
        }

        private void txtCidade_Enter(object sender, EventArgs e)
        {
            txtCidade.SelectAll();
        }

        private void txtCEP_Enter(object sender, EventArgs e)
        {
            txtCEP.SelectAll();
        }

        private void txtTel1_Enter(object sender, EventArgs e)
        {
            txtTel1.SelectAll();
        }

        private void txtTel2_Enter(object sender, EventArgs e)
        {
            txtTel2.SelectAll();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.SelectAll();
        }

        private void btnImprimirNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAdmissao_Click(object sender, EventArgs e)
        {
            frmAdmissao frm = new frmAdmissao();

            frm.ShowDialog();

            carregaAdmissao();
        }

        private void carregaAdmissao()
        {
            DataTable dt = new CrudMembro().listaAdmissao(Conexao.con);

            cbAdmissao.DataSource = dt;

            cbAdmissao.DisplayMember = "Descrição";
            cbAdmissao.ValueMember = "ID";

        }

        private void carregaStatus()
        {
            DataTable dt = new CrudMembro().listaSituacao(Conexao.con);

            cbStatus.DataSource = dt;

            cbStatus.DisplayMember = "Descrição";
            cbStatus.ValueMember = "Id";
        }

        private void cbIdAdmissao_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbAdmissao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStatus_Click(object sender, EventArgs e)
        {
            frmSituacao frm = new frmSituacao();

            frm.ShowDialog();

            carregaStatus();
        }

        private void cbIdStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbContato_Enter(object sender, EventArgs e)
        {

        }

        private void gbSecretaria_Enter(object sender, EventArgs e)
        {

        }

        private void cbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

            dtCasamento.Enabled = (cbEstadoCivil.SelectedIndex == 1);


        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtgHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dtgHistorico_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgHistorico.HitTest(e.X, e.Y);
                dtgHistorico.ClearSelection();

                if (hti.RowIndex < 0)
                {
                    tsEditar.Enabled = false;
                    tsRemover.Enabled = false;
                    return;
                }
                else
                {
                    tsEditar.Enabled = true;
                    tsRemover.Enabled = true;

                    dtgHistorico.Rows[hti.RowIndex].Selected = true;

                }

            }
        }

        private void tsCadastrar_Click(object sender, EventArgs e)
        {
            Historico h = new Historico();

            h.id = 0;
            h.idMembro = this.membro.id;
            h.nomeMembro = this.membro.nome;

            frmAltHistorico frm = new frmAltHistorico(h);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                carregaHistorico();
            }



        }

        private void tsEditar_Click(object sender, EventArgs e)
        {

            if (dtgHistorico.SelectedRows.Count == 0)
                return;

            Historico h = new Historico();

            h = new CrudMembro().getHistorico(Conexao.con,
                Convert.ToInt32(dtgHistorico.SelectedRows[0].Cells["Id"].Value));

            frmAltHistorico frm = new frmAltHistorico(h);

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                carregaHistorico();
            }

        }

        private void tsRemover_Click(object sender, EventArgs e)
        {
            if (dtgHistorico.SelectedRows.Count == 0)
                return;

            int id = Convert.ToInt32(dtgHistorico.SelectedRows[0].Cells["ID"].Value);

            if (MessageBox.Show("Deseja remover o histórico de ID " + id + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new CrudMembro().removeHistorico(Conexao.con, id);

                // MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carregaHistorico();

            }
        }

        private void frmAltMembro_Shown(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEstadoCivil_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            e.Graphics.DrawString(cbEstadoCivil.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void cbUF_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            e.Graphics.DrawString(cbUF.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void cbAdmissao_DrawItem(object sender, DrawItemEventArgs e)
        {

            if(cbAdmissao.Items.Count == 0)
            {
                return;
            }

            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();


            string displayValue = cbAdmissao.GetItemText(cbAdmissao.Items[index]);

            e.Graphics.DrawString(displayValue, e.Font, brush, e.Bounds, StringFormat.GenericDefault);

        }

        private void cbStatus_DrawItem(object sender, DrawItemEventArgs e)
        {
            if(cbStatus.Items.Count ==0)
            {
                return;
            }

            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            string displayValue = cbStatus.GetItemText(cbStatus.Items[index]);
            e.Graphics.DrawString(displayValue, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }





        //final duas chaves
    }
}
