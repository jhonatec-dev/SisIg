using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using ControleFinanceiroIgreja.TAD;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmAltCargoMembro : Form
    {

        CargoMembro cm;



        public frmAltCargoMembro(CargoMembro cargm)
        {
            InitializeComponent();

            this.cm = cargm;

        }

        private void frmAltCargoMembro_Load(object sender, EventArgs e)
        {

            carregaCargos();
            carregaMembros();

            //carregar informações
            if (cm.id != 0)
            {

                cm = new CrudCargos().getCargoOcupado(Conexao.con, cm.id);

                cbMembro.SelectedValue = cm.idMembro;
                cbCargos.SelectedValue = cm.idCargo;

                dtFinal.Value = cm.dtFim;
                dtInicial.Value = cm.dtInicio;


            }



        }

        private void carregaCargos()
        {

            //string strSort = "ORDER BY NOME";

            DataTable dt = new CrudCargos().listaCargos(Conexao.con);

            cbCargos.DataSource = dt;

            cbCargos.DisplayMember = "Descricao";
            cbCargos.ValueMember = "ID";



        }


        private void carregaMembros()
        {

            string strSort = "ORDER BY NOME";

            DataTable dt = new CrudMembro().listaMembros(Conexao.con, strSort);

            cbMembro.DataSource = dt;

            cbMembro.DisplayMember = "Nome";
            cbMembro.ValueMember = "ID";

            cbMembro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMembro.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cbMembro_Leave(object sender, EventArgs e)
        {
            //se existe fill Membro
            //senao oferece para Cadastrar membro

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

                if (MessageBox.Show("Membro: " + cbMembro.Text + " não existe! Desejar realizar o cadastro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Membro m = new Membro();

                    m.id = 0;

                    frmAltMembro frm = new frmAltMembro(m);

                    frm.ShowDialog();

                    //retorno do form

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
                cm.idMembro = Convert.ToInt32(cbMembro.SelectedValue);

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (cbMembro.SelectedValue == null)
            {
                MessageBox.Show("Selecione um membro válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbMembro.Focus();
                return;
            }

            //comparar datas
            DateTime dtIn = dtInicial.Value, dtF = dtFinal.Value;


            if (dtIn >= dtF)
            {

                MessageBox.Show("Data inicial não pode ser maior ou igual à data final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtInicial.Focus();
                return;
            }


            //cm.idMembro = Convert.ToInt32(cbMembro.SelectedValue);
            cm.idCargo = Convert.ToInt32(cbCargos.SelectedValue);
            cm.dtFim = dtF;
            cm.dtInicio = dtIn;

            new CrudCargos().alteraCargoOcupado(Conexao.con, cm);

            //MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbMembro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);

            }


        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCargos_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            string displayValue = cbCargos.GetItemText(cbCargos.Items[e.Index]);
            e.Graphics.DrawString(displayValue, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
    }
}
