using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmSelAnoMembro : Form
    {

        public int idMembro = 0, ano;
        public string nomeMembro;

        public frmSelAnoMembro()
        {
            InitializeComponent();
        }

        private void frmSelAnoMembro_Load(object sender, EventArgs e)
        {
            carregaCat();
        }

        private void carregaCat()
        {

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


            string strSort = "ORDER BY NOME";

            dt2 = new CrudMembro().listaMembros(Conexao.con, strSort);

            cbMembro.DataSource = dt2;

            cbMembro.DisplayMember = "Nome";
            cbMembro.ValueMember = "ID";

            cbMembro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMembro.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbMembro.SelectedIndex = 0;


        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (idMembro == 0)
            {
                MessageBox.Show("Selecione um membro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMembro.Focus();
                return;
            }


            if (cbAno.SelectedIndex >= 0)
                ano = Convert.ToInt32(cbAno.Text);

            nomeMembro = cbMembro.Text;

            DialogResult = DialogResult.OK;

        }

        private void cbMembro_Leave(object sender, EventArgs e)
        {
            if (cbMembro.Text.Trim() == "")
                return;

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

                MessageBox.Show("Membro '" + cbMembro.Text + "' não cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //não quer cadastrar
                cbMembro.ResetText();
                idMembro = 0;

            }
            else
            {
                //membro existe
                idMembro = Convert.ToInt32(cbMembro.SelectedValue);

            }

        }

        private void cbMembro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
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

        private void btnMembro_Click(object sender, EventArgs e)
        {

        }
    }
}
