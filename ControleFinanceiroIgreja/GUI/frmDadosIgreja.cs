using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmDadosIgreja : Form
    {
        TAD.Igreja ig;

        public frmDadosIgreja(TAD.Igreja igreja)
        {
            InitializeComponent();

            ig = igreja;
        }

        private void btnContato_Click(object sender, EventArgs e)
        {



        }

        private void picIgreja_MouseHover(object sender, EventArgs e)
        {

        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtNome.Text = ig.nome;
            txtCNPJ.Text = ig.cnpj;
            cbUF.Text = ig.uf;
            txtCEP.Text = ig.cep;
            txtEndereco.Text = ig.endereco;
            txtBairro.Text = ig.bairro;
            txtCidade.Text = ig.cidade;
            txtEmail.Text = ig.email;
            txtTel1.Text = ig.tel1;
            txtTel2.Text = ig.tel2;
            txtSede.Text = ig.sede;
            txtSaldoInicial.Text = ig.saldoInicial.ToString();

            txtTit1.Text = ig.tit1;
            txtNome1.Text = ig.assinatura1;
            txtTit2.Text = ig.tit2;
            txtNome2.Text = ig.assinatura2;

            string imgnome = Directory.GetParent(Application.ExecutablePath) + @"\Img\imgLogo.jpg";
            if (File.Exists(imgnome))
                this.imgLogo.Image = Image.FromFile(imgnome);


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //verificar nome da igreja
            if (txtNome.Text.TrimStart().TrimEnd().Length <= 2)
            {

                MessageBox.Show("Nome inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtNome.Focus();

            }
            else
            {
                ig.nome = txtNome.Text.TrimStart().TrimEnd();
                ig.cnpj = txtCNPJ.Text;
                ig.uf = cbUF.Text;
                ig.cep = txtCEP.Text;
                ig.endereco = txtEndereco.Text;
                ig.bairro = txtBairro.Text;
                ig.cidade = txtCidade.Text;
                ig.email = txtEmail.Text;
                ig.tel1 = txtTel1.Text;
                ig.tel2 = txtTel2.Text;
                ig.sede = txtSede.Text;
                ig.tit1 = txtTit1.Text;
                ig.assinatura1 = txtNome1.Text;
                ig.tit2 = txtTit2.Text;
                ig.assinatura2 = txtNome2.Text;

                if ((txtSaldoInicial.Text.Length < 1) || (txtSaldoInicial.Text == ","))
                {

                    MessageBox.Show("Valor inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSaldoInicial.Focus();
                    return;
                }


                ig.saldoInicial = Convert.ToDecimal(txtSaldoInicial.Text);

                new DAO.CrudIgreja().altIgreja(DAO.Conexao.con, ig);

                // MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;

                Close();

            }


        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImg = new OpenFileDialog();


            ofdImg.Filter = "Imagens|*.jpg; *.png; *.jpeg";
            ofdImg.Title = "Escolha sua logomarca";
            ofdImg.ShowDialog();

            string nomeImg = ofdImg.FileName;

            // If the file name is not an empty string open it for saving.
            if (nomeImg != "")
            {


                if (imgLogo.Image != null)
                {
                    imgLogo.Image.Dispose();
                    frmHome frmH = (frmHome)this.Owner;


                }
                imgLogo.Load(nomeImg);

                string pathConfig = Directory.GetParent(Application.ExecutablePath) + @"\Img";

                if (!Directory.Exists(pathConfig))
                {
                    Directory.CreateDirectory(pathConfig);
                }

                string destino = pathConfig + @"\imgLogo.jpg";

                if (File.Exists(destino))
                    File.Delete(destino);

                imgLogo.Image.Save(destino);

            }
        }

        private void btnDirBackup_Click(object sender, EventArgs e)
        {

        }

        private void txtSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSaldoInicial_DoubleClick(object sender, EventArgs e)
        {


        }

        private void txtSaldoInicial_Leave(object sender, EventArgs e)
        {

        }

        private void txtNome_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {

        }

        private void txtNome_Leave(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void imgLogo_MouseHover(object sender, EventArgs e)
        {

        }

        private void imgLogo_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbUF_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.White;
            e.DrawBackground();
            e.Graphics.DrawString(cbUF.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();

        }
    }
}
