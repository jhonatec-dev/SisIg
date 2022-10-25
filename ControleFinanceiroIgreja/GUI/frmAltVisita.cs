using System;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.TAD;
using ControleFinanceiroIgreja.DAO;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmAltVisita : Form
    {
        Visitas visitas;

        public frmAltVisita(Visitas v)
        {
            InitializeComponent();

            this.visitas = v;
        }

        private void frmAltVisita_Load(object sender, EventArgs e)
        {
            if (visitas.id == 0)
            {

                cbTipo.SelectedIndex = 0;
                return;
            }
            else
            {


                dtVisita.Value = visitas.data;
                txtObs.Text = visitas.obs;
                cbTipo.SelectedIndex = cbTipo.Items.IndexOf(visitas.tipo);

            }



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            visitas.obs = txtObs.Text;
            visitas.data = dtVisita.Value;
            visitas.tipo = cbTipo.Text;

            new CrudVisitantes().alteraVisita(Conexao.con, visitas);



            DialogResult = DialogResult.OK;


        }

        private void dtVisita_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTipo_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            e.Graphics.DrawString(cbTipo.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
    }
}
