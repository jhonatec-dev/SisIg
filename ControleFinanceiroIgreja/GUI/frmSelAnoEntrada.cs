using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmSelAnoEntrada : Form
    {

        public int idCat, ano, mes;
        public string cat, nomeMes;
        bool selMes;

        public frmSelAnoEntrada(bool selMes = false)
        {
            InitializeComponent();
            this.selMes = selMes;
        }

        private void frmSelAnoEntrada_Load(object sender, EventArgs e)
        {
            carregaCat();
            lblMes.Visible = selMes;
            cbMes.Visible = selMes;

            cbMes.SelectedIndex = 0;

        }

        private void carregaCat()
        {

            DataTable dt = new CrudEntrada().listaCatEntrada(Conexao.con);

            cbCategoria.DataSource = dt;

            cbCategoria.DisplayMember = "Descrição";
            cbCategoria.ValueMember = "Id";


            DataTable dt2 = new CrudLancamento().anosLanc(Conexao.con);

            if (dt2.Rows.Count > 0)
            {
                cbAno.Items.Clear();

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    cbAno.Items.Add(dt2.Rows[i]["Ano"].ToString());
                }

                cbAno.SelectedIndex = 0;
            }


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAno_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            e.Graphics.DrawString(cbAno.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void cbMes_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            e.Graphics.DrawString(cbMes.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void cbCategoria_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            string displayValue = cbCategoria.GetItemText(cbCategoria.Items[e.Index]);
            e.Graphics.DrawString(displayValue, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void cbIdCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Categoria nao selecionada
            if (cbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione ou crie uma Categoria de Entrada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategoria.Focus();
                return;
            }

            if (this.selMes && cbMes.SelectedIndex >= 0)
            {
                this.mes = cbMes.SelectedIndex + 1;
                this.nomeMes = cbMes.Text;
                //DialogResult = DialogResult.OK;
            }

            this.idCat = Convert.ToInt32(cbCategoria.SelectedValue);

            if (cbAno.SelectedIndex >= 0)
                this.ano = Convert.ToInt32(cbAno.Text);

            this.cat = cbCategoria.Text;

            DialogResult = DialogResult.OK;

        }
    }
}
