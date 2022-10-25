using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmAltVisitante : Form
    {
        Visitantes visitante;

        public frmAltVisitante(Visitantes vi)
        {
            InitializeComponent();

            this.visitante = vi;
        }

        private void frmAltVisitante_Load(object sender, EventArgs e)
        {

            if (visitante.id > 0)
            {

                visitante = new CrudVisitantes().getVisitante(Conexao.con, visitante.id);

                txtNome.Text = visitante.nome;
                dtNasc.Value = visitante.dtnasc;
                rbFem.Checked = visitante.sexo.Trim().Equals("FEM");
                txtEndereco.Text = visitante.endereco;
                txtBairro.Text = visitante.bairro;
                txtCidade.Text = visitante.cidade;

                cbEstadoCivil.SelectedIndex = cbEstadoCivil.Items.IndexOf(visitante.estadoCivil);

                if (visitante.estadoCivil == "CASADO")
                {
                    dtCasamento.Value = DateTime.Parse(visitante.dtCasamento);
                    dtCasamento.Enabled = true;
                }

                txtObs.Text = visitante.obs;

                cbUF.Text = visitante.uf;
                txtCEP.Text = visitante.cep;
                txtTel1.Text = visitante.tel1;
                txtTel2.Text = visitante.tel2;
                txtEmail.Text = visitante.email;

                txtProfissao.Text = visitante.profissao;
                txtLocalNascimento.Text = visitante.localNascimento;



            }
            else
            {
                cbEstadoCivil.SelectedIndex = 0;
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.TrimStart().TrimEnd().Length <= 2)
            {
                MessageBox.Show("Nome inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            visitante.nome = txtNome.Text.TrimStart().TrimEnd();
            visitante.endereco = txtEndereco.Text;
            visitante.bairro = txtBairro.Text;
            visitante.cidade = txtCidade.Text;
            visitante.cep = txtCEP.Text;
            visitante.dtnasc = dtNasc.Value;
            visitante.sexo = (rbMasc.Checked) ? "MASC" : "FEM";
            visitante.estadoCivil = cbEstadoCivil.Text;

            if (cbEstadoCivil.SelectedIndex == 1)
            {
                visitante.dtCasamento = dtCasamento.Value.ToShortDateString();
            }
            else
                visitante.dtCasamento = null;

            visitante.email = txtEmail.Text;
            visitante.tel1 = txtTel1.Text;
            visitante.tel2 = txtTel2.Text;
            visitante.obs = txtObs.Text;
            visitante.uf = cbUF.Text;
            visitante.profissao = txtProfissao.Text;
            visitante.localNascimento = txtLocalNascimento.Text;

            new CrudVisitantes().alteraVisitante(Conexao.con, visitante);

            DialogResult = DialogResult.OK;

        }




        private void txtNome_Enter(object sender, EventArgs e)
        {

        }

        private void txtEndereco_Enter(object sender, EventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void cmsVisitas_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dtgVisitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstadoCivil.SelectedIndex == 1)
            {
                dtCasamento.Enabled = true;
            }
            else
                dtCasamento.Enabled = false;
        }

        private void dtNasc_ValueChanged_1(object sender, EventArgs e)
        {

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
    }
}
