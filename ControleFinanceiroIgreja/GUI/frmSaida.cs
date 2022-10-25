using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmSaida : Form
    {
        Saida sai;
        int ano; int mes;

        public frmSaida(Saida s, int ano, int mes)
        {
            InitializeComponent();

            this.sai = s;
            this.ano = ano;
            this.mes = mes;

        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            frmCatSaida fcat = new frmCatSaida();

            fcat.ShowDialog();

            carregaCat();
        }

        private void carregaCat()
        {

            DataTable dt = new CrudSaida().listaCatSaida(Conexao.con);

            cbCategoria.DataSource = dt;

            cbCategoria.DisplayMember = "Descrição";
            cbCategoria.ValueMember = "ID";



        }

        private void cbIdSaida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Categoria nao selecionada
            if (cbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione ou crie uma Categoria de Saída!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategoria.Focus();
                return;
            }

            if ((txtValor.Text.Length < 1) || (txtValor.Text == ","))
            {

                MessageBox.Show("Valor inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }


            sai.valor = Convert.ToDecimal(txtValor.Text);

            if (sai.valor <= 0)
            {
                MessageBox.Show("Valor deve ser maior que 0 (zero)!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }

            sai.idCat = Convert.ToInt32(cbCategoria.SelectedValue);
            sai.obs = txtObs.Text;
            sai.data = dtData.Value;

            new CrudSaida().altSaida(Conexao.con, sai);


            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmSaida_Load(object sender, EventArgs e)
        {
            carregaCat();

            if (sai.id != 0)
            {
                cbCategoria.SelectedValue = sai.idCat;
                txtValor.Text = sai.valor.ToString();
                dtData.Value = sai.data;
                txtObs.Text = sai.obs;
                chkLote.Enabled = false;
            }
            else if (ano != 0)
            {
                dtData.Value = DateTime.Parse("01/" + this.mes + "/" + this.ano);
            }
            else
            {
                dtData.Value = DateTime.Now;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValor_Enter(object sender, EventArgs e)
        {
            txtValor.SelectAll();
        }

        private void dtData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_MouseDown(object sender, MouseEventArgs e)
        {
            txtValor.SelectAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCategoria_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (cbCategoria.Items.Count == 0)
            {
                return;
            }

            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            string displayValue = cbCategoria.GetItemText(cbCategoria.Items[e.Index]);
            e.Graphics.DrawString(displayValue, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
    }
}
