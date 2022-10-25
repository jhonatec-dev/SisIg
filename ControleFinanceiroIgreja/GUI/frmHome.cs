using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControleFinanceiroIgreja.DAO;
using System.IO;
using ControleFinanceiroIgreja.TAD;
using System.Diagnostics;
using System.Linq;

namespace ControleFinanceiroIgreja.GUI
{
    public partial class frmHome : Form
    {
        public Igreja ig;
        public Usuario user;
        public bool fechar = false;
        private bool mouseIsDown = false;
        private Point firstPoint;
        private List<Button> listaBotoes = new List<Button>();

        public frmHome()
        {
            InitializeComponent();


        }



        protected override void WndProc(ref Message message)
        {
           
            
            
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    //if (command == SC_MOVE)
                      //  return;
                    break;
            }

            base.WndProc(ref message);
        
            
            
            }

        private void frmHome_Load(object sender, EventArgs e)
        {


            pnInicial.Dock = DockStyle.Fill;
            pnInicial.BringToFront();

            this.Refresh();
            Application.DoEvents();
            pnBotoes.Left = 0;
            pnBotoes.Top = pnBotoes.Width = 48;
            pnBotoes.Height = this.Height - 48;

            try
            {
                Conexao.conectar();

                ig = new CrudIgreja().lerIgreja(Conexao.con);
                frmLogin frmL = new frmLogin(ig.nome);



                frmL.ShowDialog();



                //dialog result....
                if (frmL.DialogResult != DialogResult.OK)
                {

                    Application.Exit();
                    return;
                }

                this.user = frmL.usuario;

                login();

                //ig = new CrudIgreja().lerIgreja(Conexao.con);
                this.Text = ig.nome;

                pnInicial.Visible = false;



                listaBotoes.Add(btnMembros);
                listaBotoes.Add(btnVisitantes);
                listaBotoes.Add(btnAniversariantes);
                listaBotoes.Add(btnLancamentos);
                listaBotoes.Add(btnDadosIgreja);
                listaBotoes.Add(btnEscola);
                listaBotoes.Add(btnCargos);
                listaBotoes.Add(btnAbout);
                listaBotoes.Add(btnAlteraSenha);
                listaBotoes.Add(btnUsuarios);

            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
            //Microsoft.Win32.SystemEvents.DisplaySettingsChanged +=  new System.EventHandler(displaySettingsChanged);
        }


        // Event handler for the system's DisplaySettingsChanged event.
        // Detect and then compare the height and width of the screen.
        private void displaySettingsChanged(object sender, EventArgs e)
        {
            Rectangle theScreenRect = Screen.GetBounds(this);

            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }


        private void btnMembros_Click(object sender, EventArgs e)
        {

            marcarBotoes(btnMembros);

            foreach (Form f in this.MdiChildren)
            {


                if (f.GetType() == typeof(frmMembros))
                {
                    f.BringToFront();
                    return;
                }
                else
                    f.Close();

            }


            frmMembros frm = new frmMembros(false, ig);


            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();




        }

        public void marcarBotoes(Button btnMarcado)
        {


            foreach (Button btn in listaBotoes)
            {

                if (btn == btnMarcado)
                {
                    btn.BackColor = Color.FromArgb(100,100,100) ;
                }
                else
                {
                    btn.BackColor = pnBotoes.BackColor;
                }


            }

        }

        private void btnLancamentos_Click(object sender, EventArgs e)
        {
            marcarBotoes(btnLancamentos);

            foreach (Form f in this.MdiChildren)
            {


                if (f.GetType() == typeof(frmLancamentos))
                {
                    f.BringToFront();
                    return;
                }
                else
                    f.Close();

            }


            frmLancamentos frm = new frmLancamentos(ig);

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }


        private void btnVisitantes_Click(object sender, EventArgs e)
        {
            marcarBotoes(btnVisitantes);
            foreach (Form f in this.MdiChildren)
            {


                if (f.GetType() == typeof(frmVisitantes))
                {
                    f.BringToFront();
                    return;
                }
                else
                    f.Close();

            }


            frmVisitantes frm = new frmVisitantes(ig);

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void btnEscola_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função em atualização, aguarde o lançamento final.");
            return;

            marcarBotoes(btnEscola);

            foreach (Form f in this.MdiChildren)
            {


                if (f.GetType() == typeof(frmEscola))
                {
                    f.BringToFront();
                    return;
                }
                else
                    f.Close();

            }


            frmEscola frm = new frmEscola(ig);

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            marcarBotoes(btnCargos);

            foreach (Form f in this.MdiChildren)
            {


                if (f.GetType() == typeof(frmCargosMembros))
                {
                    f.BringToFront();
                    return;
                }
                else
                    f.Close();

            }


            frmCargosMembros frm = new frmCargosMembros(ig);

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnAniversariantes_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Em breve!");
            //return;


            marcarBotoes(btnAniversariantes);
            foreach (Form f in this.MdiChildren)
            {


                if (f.GetType() == typeof(frmNiver))
                {
                    f.BringToFront();
                    return;
                }
                else
                    f.Close();

            }


            frmNiver frm = new frmNiver(ig);

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = Directory.GetParent(Application.ExecutablePath) + @"\Data\LocalDBTool.exe";


            if (File.Exists(file))
            {

                // Use ProcessStartInfo class.
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;
                startInfo.FileName = file;
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.Arguments = " /nada ";
                startInfo.Verb = "runas";

                System.Diagnostics.Process.Start(startInfo);

            }

            fechar = true;

            Application.Exit();
        }

        private void dadosDaIgrejaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marcarBotoes(btnDadosIgreja);
            if (!user.dadosIgreja)
                return;

            frmDadosIgreja config = new frmDadosIgreja(this.ig);

            esconder();

            config.ShowDialog();

            if (config.DialogResult == DialogResult.OK)
            {
                ig = new CrudIgreja().lerIgreja(Conexao.con);
                this.Text = ig.nome;
                Application.DoEvents();
            }

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            marcarBotoes(btnUsuarios);

            frmUsuarios frm = new frmUsuarios();

            esconder();

            frm.ShowDialog();



        }

        private void meuUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marcarBotoes(btnAlteraSenha);

            frmConfigUsuario frm = new frmConfigUsuario(user);

            esconder();
            frm.ShowDialog();

        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = Directory.GetParent(Application.ExecutablePath) + @"\Data\LocalDBTool.exe";


            if (File.Exists(file))
                System.Diagnostics.Process.Start(file);

            this.fechar = true;

            Application.Exit();

        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            if ((this.user != null) && (!fechar))
            {
                frmBackupAuto frmB = new frmBackupAuto();
                pnInicial.Dock = DockStyle.Fill;
                pnInicial.BringToFront();

                pnInicial.Visible = true;

                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                this.Refresh();
                Application.DoEvents();
                frmB.ShowDialog();

                switch (frmB.DialogResult)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        pnInicial.Visible = false;

                        e.Cancel = true;
                        return;

                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:

                        string file = Directory.GetParent(Application.ExecutablePath) + @"\Data\LocalDBTool.exe";

                        string arqIni = Directory.GetParent(Application.ExecutablePath) + @"\Data\ubq.ini";
                        string dirbkp = "";

                        if (File.Exists(arqIni))
                        {
                            StreamReader st = new StreamReader(arqIni);

                            List<string> linhas = new List<string>();



                            while (!st.EndOfStream)
                            {
                                string linha = st.ReadLine();

                                linhas.Add(linha);

                                if (linha.Contains("BackupDir="))
                                {
                                    dirbkp = linha.Replace("BackupDir=", "");
                                }
                            }


                            st.Close();

                            st.Dispose();

                        }

                        if (File.Exists(file))
                        {

                            // Use ProcessStartInfo class.
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.CreateNoWindow = false;
                            startInfo.UseShellExecute = false;
                            startInfo.FileName = file;
                            startInfo.WindowStyle = ProcessWindowStyle.Normal;
                            if (dirbkp.Length > 0)
                                startInfo.Arguments = " /bkp \"" + dirbkp + "\"";
                            else
                                startInfo.Arguments = " /bkp";
                            startInfo.Verb = "runas";

                            System.Diagnostics.Process.Start(startInfo);

                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }

    */
            try
            {
                if (Conexao.con != null)
                    if (Conexao.con.State == ConnectionState.Open)
                    Conexao.con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marcarBotoes(btnAbout);

            frmContato frm = new frmContato();
            pnInicial.Dock = DockStyle.Fill;
            pnInicial.BringToFront();

            pnInicial.Visible = true;


            this.Refresh();
            Application.DoEvents();
            esconder();
            frm.ShowDialog();


            pnInicial.Visible = false;
            Application.DoEvents();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin frmL = new frmLogin(this.ig.nome);
            pnInicial.Dock = DockStyle.Fill;
            pnInicial.BringToFront();

            pnInicial.Visible = true;

            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            this.Refresh();
            Application.DoEvents();
            frmL.ShowDialog();

            //dialog result....
            if (frmL.DialogResult == DialogResult.OK)
            {

                this.user = frmL.usuario;
                login();
                pnInicial.Visible = false;
            }
            else
            {
                fechar = true;
                Application.Exit();
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        public void aparecer()
        {
            
            pnBotoes.Width = 200;
        }

        public void esconder()
        {
            pnBotoes.Width = 48;
          

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void frmHome_Shown(object sender, EventArgs e)
        {

            pnBotoes.BringToFront();

        }

        private void login()
        {
            // lblUser.Text = user.user;

            btnMembros.Enabled = user.membros;
            btnVisitantes.Enabled = user.vis;
            btnLancamentos.Enabled = user.lanc;
            btnEscola.Enabled = user.ebd;
            btnCargos.Enabled = user.cargos;
            btnDadosIgreja.Enabled = user.dadosIgreja;
            btnUsuarios.Enabled = user.usuarios;

        }

        private void pnBotoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_MouseHover(object sender, EventArgs e)
        {
        }

  

        private void pnIgreja_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void pnIgreja_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void pnIgreja_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void lblDesc1_Click(object sender, EventArgs e)
        {

        }

        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnBotoes.Width == 48)
                aparecer();
            else
                esconder();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
