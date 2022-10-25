using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmSelMes : Form
    {
        public int mes;
        public string nomeMes;
        public int ano;
        bool selMes, selAno;
        bool dinamico;
        public bool chkd = false;
        int op;

        public frmSelMes(bool selMes, bool selAno, bool dinamico = false, int option = 0)
        {
            InitializeComponent();

            this.selAno = selAno;
            this.selMes = selMes;
            this.dinamico = dinamico;
            this.op = option;
        }

        private void chkDinamico_CheckedChanged(object sender, EventArgs e)
        {
            cbMes.Visible = chkDinamico.Checked;
            lblMes.Visible = chkDinamico.Checked;
            this.chkd = chkDinamico.Checked;

            if (chkDinamico.Checked)
            {
                cbAno.DropDownStyle = ComboBoxStyle.DropDown;

            }
            else
            {
                cbAno.DropDownStyle = ComboBoxStyle.DropDownList;
                DataTable dt = new CrudLancamento().anosLanc(Conexao.con);

                if (dt.Rows.Count > 0)
                {
                    cbAno.Items.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cbAno.Items.Add(dt.Rows[i]["Ano"].ToString());
                    }


                }
            }
        }

        private void cbAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmSelMes_Load(object sender, EventArgs e)
        {
            cbMes.Visible = selMes;
            lblMes.Visible = selMes;

            cbAno.Visible = selAno;
            lblAno.Visible = selAno;

            chkDinamico.Visible = dinamico;

            cbMes.SelectedIndex = 0;



            if (selAno)
            {
                DataTable dt = new DataTable();

                if (op == 0)
                    dt = new CrudLancamento().anosLanc(Conexao.con);
                else if (op == 1)
                    dt = new CrudEscola().anosReunioes(Conexao.con);

                if (dt.Rows.Count > 0)
                {
                    cbAno.Items.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cbAno.Items.Add(dt.Rows[i]["Ano"].ToString());
                    }


                    cbAno.SelectedIndex = 0;

                }
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMes_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            e.Graphics.DrawString(cbMes.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void cbAno_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            e.Graphics.DrawString(cbAno.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {


            //tratar dinamico
            if (chkd)
            {

                if (cbMes.SelectedIndex < 0)
                    return;

                if (cbAno.Text.Length < 4)
                    return;

                this.mes = cbMes.SelectedIndex + 1;
                this.ano = Convert.ToInt32(cbAno.Text);
                //extrair ano de uma data (no caso da data minima datetime.minvalue)
                // fazer o mesmo com a max date
                if (this.ano < DateTime.MinValue.Year)
                {
                    MessageBox.Show("Informe um ano maior que " + this.ano, "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbAno.Focus();
                    return;
                }

                if (this.ano > DateTime.MaxValue.Year)
                {
                    MessageBox.Show("Informe um ano menor que " + this.ano, "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbAno.Focus();
                    return;
                }

                this.nomeMes = cbMes.Text;

                DialogResult = DialogResult.OK;
            }

            if (this.selAno && cbAno.SelectedIndex >= 0)
            {
                this.ano = Convert.ToInt32(cbAno.Text);
                DialogResult = DialogResult.OK;

            }


            if (this.selMes && cbMes.SelectedIndex >= 0)
            {
                this.mes = cbMes.SelectedIndex + 1;
                this.nomeMes = cbMes.Text;
                DialogResult = DialogResult.OK;
            }



        }
    }
}
