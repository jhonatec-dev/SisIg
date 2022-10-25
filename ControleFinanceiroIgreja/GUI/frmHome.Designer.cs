namespace ControleFinanceiroIgreja.GUI
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnMembros = new System.Windows.Forms.Button();
            this.imgsHome = new System.Windows.Forms.ImageList(this.components);
            this.btnDadosIgreja = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnVisitantes = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLancamentos = new System.Windows.Forms.Button();
            this.btnAlteraSenha = new System.Windows.Forms.Button();
            this.btnEscola = new System.Windows.Forms.Button();
            this.btnAniversariantes = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnInicial = new System.Windows.Forms.Panel();
            this.pcInicial = new System.Windows.Forms.PictureBox();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.pnInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcInicial)).BeginInit();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 40;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btnMembros
            // 
            this.btnMembros.FlatAppearance.BorderSize = 0;
            this.btnMembros.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnMembros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMembros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMembros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembros.ImageIndex = 1;
            this.btnMembros.ImageList = this.imgsHome;
            this.btnMembros.Location = new System.Drawing.Point(0, 88);
            this.btnMembros.Margin = new System.Windows.Forms.Padding(0);
            this.btnMembros.Name = "btnMembros";
            this.btnMembros.Size = new System.Drawing.Size(200, 46);
            this.btnMembros.TabIndex = 0;
            this.btnMembros.Text = "Membros";
            this.btnMembros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnMembros, "Membros");
            this.btnMembros.UseVisualStyleBackColor = true;
            this.btnMembros.Click += new System.EventHandler(this.btnMembros_Click);
            // 
            // imgsHome
            // 
            this.imgsHome.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgsHome.ImageStream")));
            this.imgsHome.TransparentColor = System.Drawing.Color.Transparent;
            this.imgsHome.Images.SetKeyName(0, "314-menu.png");
            this.imgsHome.Images.SetKeyName(1, "360-users.png");
            this.imgsHome.Images.SetKeyName(2, "359-users.png");
            this.imgsHome.Images.SetKeyName(3, "557birthdaycake1_100853.png");
            this.imgsHome.Images.SetKeyName(4, "business-color_money-13_icon-icons.com_53448.png");
            this.imgsHome.Images.SetKeyName(5, "310-briefcase.png");
            this.imgsHome.Images.SetKeyName(6, "holybible_bible_book_4252.png");
            this.imgsHome.Images.SetKeyName(7, "308-price tag.png");
            this.imgsHome.Images.SetKeyName(8, "151-id card.png");
            this.imgsHome.Images.SetKeyName(9, "373-locked.png");
            this.imgsHome.Images.SetKeyName(10, "131-star.png");
            // 
            // btnDadosIgreja
            // 
            this.btnDadosIgreja.AutoSize = true;
            this.btnDadosIgreja.FlatAppearance.BorderSize = 0;
            this.btnDadosIgreja.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnDadosIgreja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDadosIgreja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDadosIgreja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosIgreja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDadosIgreja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDadosIgreja.ImageIndex = 7;
            this.btnDadosIgreja.ImageList = this.imgsHome;
            this.btnDadosIgreja.Location = new System.Drawing.Point(0, 424);
            this.btnDadosIgreja.Margin = new System.Windows.Forms.Padding(0);
            this.btnDadosIgreja.Name = "btnDadosIgreja";
            this.btnDadosIgreja.Size = new System.Drawing.Size(200, 46);
            this.btnDadosIgreja.TabIndex = 6;
            this.btnDadosIgreja.Text = "Dados da Igreja";
            this.btnDadosIgreja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDadosIgreja, "Dados da Igreja");
            this.btnDadosIgreja.UseVisualStyleBackColor = true;
            this.btnDadosIgreja.Click += new System.EventHandler(this.dadosDaIgrejaToolStripMenuItem_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.ImageIndex = 8;
            this.btnUsuarios.ImageList = this.imgsHome;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 480);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 46);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnUsuarios, "Usuários");
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // btnVisitantes
            // 
            this.btnVisitantes.FlatAppearance.BorderSize = 0;
            this.btnVisitantes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnVisitantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVisitantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVisitantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitantes.ImageIndex = 2;
            this.btnVisitantes.ImageList = this.imgsHome;
            this.btnVisitantes.Location = new System.Drawing.Point(0, 144);
            this.btnVisitantes.Margin = new System.Windows.Forms.Padding(0);
            this.btnVisitantes.Name = "btnVisitantes";
            this.btnVisitantes.Size = new System.Drawing.Size(200, 46);
            this.btnVisitantes.TabIndex = 1;
            this.btnVisitantes.Text = "Visitantes";
            this.btnVisitantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnVisitantes, "Visitantes");
            this.btnVisitantes.UseVisualStyleBackColor = true;
            this.btnVisitantes.Click += new System.EventHandler(this.btnVisitantes_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.ImageIndex = 10;
            this.btnAbout.ImageList = this.imgsHome;
            this.btnAbout.Location = new System.Drawing.Point(0, 595);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(200, 40);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "     Sobre o SisIg";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAbout, "Sobre o SisIg");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // btnLancamentos
            // 
            this.btnLancamentos.FlatAppearance.BorderSize = 0;
            this.btnLancamentos.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnLancamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLancamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLancamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancamentos.ImageIndex = 4;
            this.btnLancamentos.ImageList = this.imgsHome;
            this.btnLancamentos.Location = new System.Drawing.Point(0, 256);
            this.btnLancamentos.Margin = new System.Windows.Forms.Padding(0);
            this.btnLancamentos.Name = "btnLancamentos";
            this.btnLancamentos.Size = new System.Drawing.Size(200, 46);
            this.btnLancamentos.TabIndex = 3;
            this.btnLancamentos.Text = "FINANCEIRO";
            this.btnLancamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnLancamentos, "Lançamentos");
            this.btnLancamentos.UseVisualStyleBackColor = true;
            this.btnLancamentos.Click += new System.EventHandler(this.btnLancamentos_Click);
            // 
            // btnAlteraSenha
            // 
            this.btnAlteraSenha.FlatAppearance.BorderSize = 0;
            this.btnAlteraSenha.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnAlteraSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAlteraSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlteraSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlteraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlteraSenha.ImageIndex = 9;
            this.btnAlteraSenha.ImageList = this.imgsHome;
            this.btnAlteraSenha.Location = new System.Drawing.Point(0, 536);
            this.btnAlteraSenha.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlteraSenha.Name = "btnAlteraSenha";
            this.btnAlteraSenha.Size = new System.Drawing.Size(200, 46);
            this.btnAlteraSenha.TabIndex = 8;
            this.btnAlteraSenha.Text = "     Alterar Senha";
            this.btnAlteraSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAlteraSenha, "Alterar Senha");
            this.btnAlteraSenha.UseVisualStyleBackColor = true;
            this.btnAlteraSenha.Click += new System.EventHandler(this.meuUsuárioToolStripMenuItem_Click);
            // 
            // btnEscola
            // 
            this.btnEscola.FlatAppearance.BorderSize = 0;
            this.btnEscola.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnEscola.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEscola.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEscola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscola.ImageIndex = 6;
            this.btnEscola.ImageList = this.imgsHome;
            this.btnEscola.Location = new System.Drawing.Point(0, 368);
            this.btnEscola.Margin = new System.Windows.Forms.Padding(0);
            this.btnEscola.Name = "btnEscola";
            this.btnEscola.Size = new System.Drawing.Size(200, 46);
            this.btnEscola.TabIndex = 5;
            this.btnEscola.Text = "Escola Bíblica";
            this.btnEscola.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEscola, "Escola Bíblica");
            this.btnEscola.UseVisualStyleBackColor = true;
            this.btnEscola.Click += new System.EventHandler(this.btnEscola_Click);
            // 
            // btnAniversariantes
            // 
            this.btnAniversariantes.FlatAppearance.BorderSize = 0;
            this.btnAniversariantes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnAniversariantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAniversariantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAniversariantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniversariantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniversariantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAniversariantes.ImageIndex = 3;
            this.btnAniversariantes.ImageList = this.imgsHome;
            this.btnAniversariantes.Location = new System.Drawing.Point(0, 200);
            this.btnAniversariantes.Margin = new System.Windows.Forms.Padding(0);
            this.btnAniversariantes.Name = "btnAniversariantes";
            this.btnAniversariantes.Size = new System.Drawing.Size(200, 46);
            this.btnAniversariantes.TabIndex = 2;
            this.btnAniversariantes.Text = "Aniversariantes";
            this.btnAniversariantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAniversariantes, "Aniversariantes");
            this.btnAniversariantes.UseVisualStyleBackColor = true;
            this.btnAniversariantes.Click += new System.EventHandler(this.btnAniversariantes_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.FlatAppearance.BorderSize = 0;
            this.btnCargos.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.btnCargos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCargos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargos.ImageIndex = 5;
            this.btnCargos.ImageList = this.imgsHome;
            this.btnCargos.Location = new System.Drawing.Point(0, 312);
            this.btnCargos.Margin = new System.Windows.Forms.Padding(0);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(200, 46);
            this.btnCargos.TabIndex = 4;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCargos, "Cargos");
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.ImageIndex = 0;
            this.btnMenu.ImageList = this.imgsHome;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 49);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnMenu, "Menu Principal");
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnInicial
            // 
            this.pnInicial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnInicial.Controls.Add(this.pcInicial);
            this.pnInicial.Location = new System.Drawing.Point(448, 85);
            this.pnInicial.Name = "pnInicial";
            this.pnInicial.Size = new System.Drawing.Size(339, 492);
            this.pnInicial.TabIndex = 67;
            // 
            // pcInicial
            // 
            this.pcInicial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pcInicial.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcInicial.Image = global::ControleFinanceiroIgreja.Properties.Resources.sisig1;
            this.pcInicial.Location = new System.Drawing.Point(210, 0);
            this.pcInicial.Name = "pcInicial";
            this.pcInicial.Size = new System.Drawing.Size(129, 492);
            this.pcInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcInicial.TabIndex = 66;
            this.pcInicial.TabStop = false;
            // 
            // pnBotoes
            // 
            this.pnBotoes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnBotoes.Controls.Add(this.btnMembros);
            this.pnBotoes.Controls.Add(this.btnDadosIgreja);
            this.pnBotoes.Controls.Add(this.btnUsuarios);
            this.pnBotoes.Controls.Add(this.btnVisitantes);
            this.pnBotoes.Controls.Add(this.btnAbout);
            this.pnBotoes.Controls.Add(this.btnLancamentos);
            this.pnBotoes.Controls.Add(this.btnAlteraSenha);
            this.pnBotoes.Controls.Add(this.btnEscola);
            this.pnBotoes.Controls.Add(this.btnAniversariantes);
            this.pnBotoes.Controls.Add(this.btnCargos);
            this.pnBotoes.Controls.Add(this.btnMenu);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBotoes.ForeColor = System.Drawing.Color.White;
            this.pnBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(48, 644);
            this.pnBotoes.TabIndex = 71;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnInicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SisIg";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.Shown += new System.EventHandler(this.frmHome_Shown);
            this.pnInicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcInicial)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            this.pnBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pcInicial;
        private System.Windows.Forms.Panel pnInicial;
        private System.Windows.Forms.Panel pnBotoes;
        public System.Windows.Forms.Button btnMembros;
        public System.Windows.Forms.Button btnDadosIgreja;
        public System.Windows.Forms.Button btnUsuarios;
        public System.Windows.Forms.Button btnVisitantes;
        public System.Windows.Forms.Button btnAbout;
        public System.Windows.Forms.Button btnLancamentos;
        public System.Windows.Forms.Button btnAlteraSenha;
        public System.Windows.Forms.Button btnEscola;
        public System.Windows.Forms.Button btnAniversariantes;
        public System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ImageList imgsHome;
    }
}