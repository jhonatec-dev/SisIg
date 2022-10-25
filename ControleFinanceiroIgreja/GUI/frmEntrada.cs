using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;
using System.Runtime.InteropServices;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmEntrada : Form
    {
        Entrada ent;
        int ano, mes;
        bool auto;

        [DllImport("uxtheme", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public extern static Int32 SetWindowTheme(IntPtr hWnd,
                     String textSubAppName, String textSubIdList);

        public frmEntrada(Entrada entrada, int ano, int mes, bool auto = false)
        {
            InitializeComponent();

            SetWindowTheme(this.dtData.Handle, "", "");
            Invalidate();

            ent = entrada;
            this.ano = ano;
            this.mes = mes;
            this.auto = auto;


        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            frmCatEntrada fcat = new frmCatEntrada();

            fcat.ShowDialog();

            carregaCat();

        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            carregaCat();

            if (auto)
            {
                txtValor.Text = ent.valor.ToString();
                dtData.Value = ent.data;
                txtObs.Text = ent.obs;

                cbMembro.SelectedIndex = -1;

                cbMembro.Enabled = false;
                dtData.Enabled = false;
                txtValor.Enabled = false;
            }
            else
            if (ent.id != 0)
            {

                cbCategoria.SelectedValue = ent.idcat;

                txtValor.Text = ent.valor.ToString();
                dtData.Value = ent.data;
                txtObs.Text = ent.obs;

                //selecionar membro baseado no id
                cbMembro.SelectedValue = ent.idmembro;

                chkLote.Enabled = false;



            }
            else if (ano != 0)
            {
                dtData.Value = DateTime.Parse("01/" + this.mes + "/" + this.ano);

                cbMembro.ResetText();
                cbMembro.SelectedIndex = -1;
            }
            else
            {
                dtData.Value = DateTime.Now;
            }


        }


        private void carregaCat()
        {

            DataTable dt = new CrudEntrada().listaCatEntrada(Conexao.con);

            cbCategoria.DataSource = dt;

            cbCategoria.DisplayMember = "Descrição";

            cbCategoria.ValueMember = "ID";



            string strSort = " WHERE INATIVO = 0 ORDER BY NOME";

            dt = new CrudMembro().listaMembros(Conexao.con, strSort);

            cbMembro.DataSource = dt;

            cbMembro.DisplayMember = "Nome";
            cbMembro.ValueMember = "ID";

            cbMembro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMembro.AutoCompleteSource = AutoCompleteSource.ListItems;


        }

        private void cbIdCat_SelectedIndexChanged(object sender, EventArgs e)
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
                MessageBox.Show("Selecione ou crie uma Categoria de Entrada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategoria.Focus();
                return;
            }

            if ((txtValor.Text.Length < 1) || (txtValor.Text == ","))
            {

                MessageBox.Show("Valor inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }


            ent.valor = Convert.ToDecimal(txtValor.Text);

            if (ent.valor <= 0)
            {
                MessageBox.Show("Valor deve ser maior que 0 (zero)!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }

            ent.idcat = Convert.ToInt32(cbCategoria.SelectedValue);
            ent.obs = txtObs.Text;
            ent.data = dtData.Value;

            new CrudEntrada().altEntrada(Conexao.con, ent);

            MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();


        }


        private void txtValor_Enter(object sender, EventArgs e)
        {
            txtValor.SelectAll();
        }

        private void dtData_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dtData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void frmEntrada_Activated(object sender, EventArgs e)
        {

        }

        private void frmEntrada_Enter(object sender, EventArgs e)
        {
        }

        private void txtValor_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtValor_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtValor_MouseUp(object sender, MouseEventArgs e)
        {

        }



        private void cbMembro_Leave(object sender, EventArgs e)
        {

            //se existe fill Membro
            //senao oferece para Cadastrar membro

            if (cbMembro.Text.Trim() == "")
            {
                ent.idmembro = 0;
                return;
            }

            //testes com o conteudo do Combobox

            int id;
            string nome = cbMembro.Text, nome2;

            foreach (DataRowView drv in cbMembro.Items)
            {

                //vou passar por todos as linhas da tabela que contem os membros

                nome2 = drv.Row.ItemArray[1].ToString();

                if (nome2.Equals(nome))
                {

                    id = Convert.ToInt32(drv.Row.ItemArray[0].ToString());
                    cbMembro.SelectedValue = id;
                    break;
                }

            }


            if (cbMembro.SelectedValue == null)
            {

                if (MessageBox.Show("Membro: " + cbMembro.Text + " não existe! Desejar realizar o cadastro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Membro m = new Membro();

                    m.id = 0;

                    frmAltMembro frm = new frmAltMembro(m);

                    frm.ShowDialog();

                    //retorno do form

                    if (frm.DialogResult == DialogResult.OK)
                    {

                        string strSort = " WHERE INATIVO = 0 ORDER BY NOME";

                        DataTable dt = new CrudMembro().listaMembros(Conexao.con, strSort);

                        cbMembro.DataSource = dt;

                        cbMembro.DisplayMember = "Nome";
                        cbMembro.ValueMember = "ID";

                        cbMembro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        cbMembro.AutoCompleteSource = AutoCompleteSource.ListItems;
                    }

                    cbMembro.ResetText();
                    cbMembro.Focus();

                    return;

                }
                else
                {
                    //não quer cadastrar
                    cbMembro.ResetText();
                }

            }
            else
            {
                //membro existe
                ent.idmembro = Convert.ToInt32(cbMembro.SelectedValue);

            }



        }

        private void cbMembro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Select Value = " + cbMembro.SelectedValue + " Item = " + cbMembro.SelectedItem +
                " index = " + cbMembro.SelectedIndex);
        }

        private void cbMembro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Char f = e.KeyChar

            if (e.KeyChar == (char)Keys.Enter)
            {

            }

            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);

            }

        }

        private void cbMembro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbMembro_Leave(this, new EventArgs());
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbMembro_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
            string displayValue = cbCategoria.GetItemText(cbCategoria.Items[index]);
            e.Graphics.DrawString(displayValue, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void frmEntrada_Shown(object sender, EventArgs e)
        {

        }

        private void chkLote_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
