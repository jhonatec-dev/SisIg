namespace ControleFinanceiroIgreja.GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnLoading = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnIgreja = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblIgreja = new System.Windows.Forms.Label();
            this.btnMostrarSenha = new System.Windows.Forms.Button();
            this.pcIgreja = new System.Windows.Forms.PictureBox();
            this.imgsLogin = new System.Windows.Forms.ImageList(this.components);
            this.pnLoading.SuspendLayout();
            this.pnIgreja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIgreja)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLoading
            // 
            this.pnLoading.Controls.Add(this.pbLoading);
            this.pnLoading.Location = new System.Drawing.Point(12, 169);
            this.pnLoading.Name = "pnLoading";
            this.pnLoading.Size = new System.Drawing.Size(431, 65);
            this.pnLoading.TabIndex = 4;
            this.pnLoading.Visible = false;
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(80, 33);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(275, 23);
            this.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbLoading.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoEllipsis = true;
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.SystemColors.Control;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSenha.Location = new System.Drawing.Point(187, 105);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(61, 20);
            this.lblSenha.TabIndex = 68;
            this.lblSenha.Text = "Senha";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.ImageIndex = 0;
            this.btnLogin.ImageList = this.imgsLogin;
            this.btnLogin.Location = new System.Drawing.Point(322, 174);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(119, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnIgreja
            // 
            this.pnIgreja.BackColor = System.Drawing.SystemColors.Control;
            this.pnIgreja.Controls.Add(this.txtSenha);
            this.pnIgreja.Controls.Add(this.btnMostrarSenha);
            this.pnIgreja.Controls.Add(this.lblSenha);
            this.pnIgreja.Controls.Add(this.txtUsuario);
            this.pnIgreja.Controls.Add(this.lblUser);
            this.pnIgreja.Controls.Add(this.lblErro);
            this.pnIgreja.Controls.Add(this.lblIgreja);
            this.pnIgreja.Controls.Add(this.btnLogin);
            this.pnIgreja.Controls.Add(this.pcIgreja);
            this.pnIgreja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnIgreja.Location = new System.Drawing.Point(2, 2);
            this.pnIgreja.Name = "pnIgreja";
            this.pnIgreja.Size = new System.Drawing.Size(451, 217);
            this.pnIgreja.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSenha.Location = new System.Drawing.Point(187, 125);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(195, 22);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario.Location = new System.Drawing.Point(186, 80);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(196, 22);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblUser
            // 
            this.lblUser.AutoEllipsis = true;
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.Control;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(187, 60);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(71, 20);
            this.lblUser.TabIndex = 69;
            this.lblUser.Text = "Usuário";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblErro
            // 
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(184, 150);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(241, 23);
            this.lblErro.TabIndex = 69;
            this.lblErro.Text = "* Descrição do erro";
            this.lblErro.Visible = false;
            // 
            // lblIgreja
            // 
            this.lblIgreja.AutoEllipsis = true;
            this.lblIgreja.BackColor = System.Drawing.Color.Transparent;
            this.lblIgreja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgreja.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIgreja.Location = new System.Drawing.Point(183, 9);
            this.lblIgreja.Name = "lblIgreja";
            this.lblIgreja.Size = new System.Drawing.Size(242, 52);
            this.lblIgreja.TabIndex = 67;
            this.lblIgreja.Text = "Usuário fghasuifhsiugh uigh wigh iwufg uqidg iqug q";
            this.lblIgreja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMostrarSenha
            // 
            this.btnMostrarSenha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMostrarSenha.BackColor = System.Drawing.SystemColors.Control;
            this.btnMostrarSenha.FlatAppearance.BorderSize = 0;
            this.btnMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarSenha.ImageIndex = 1;
            this.btnMostrarSenha.ImageList = this.imgsLogin;
            this.btnMostrarSenha.Location = new System.Drawing.Point(395, 94);
            this.btnMostrarSenha.Name = "btnMostrarSenha";
            this.btnMostrarSenha.Size = new System.Drawing.Size(46, 44);
            this.btnMostrarSenha.TabIndex = 2;
            this.btnMostrarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarSenha.UseVisualStyleBackColor = false;
            this.btnMostrarSenha.Click += new System.EventHandler(this.btnMostrarSenha_Click);
            // 
            // pcIgreja
            // 
            this.pcIgreja.BackColor = System.Drawing.Color.White;
            this.pcIgreja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcIgreja.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcIgreja.Image = global::ControleFinanceiroIgreja.Properties.Resources.templo;
            this.pcIgreja.Location = new System.Drawing.Point(0, 0);
            this.pcIgreja.Name = "pcIgreja";
            this.pcIgreja.Size = new System.Drawing.Size(177, 217);
            this.pcIgreja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcIgreja.TabIndex = 66;
            this.pcIgreja.TabStop = false;
            // 
            // imgsLogin
            // 
            this.imgsLogin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgsLogin.ImageStream")));
            this.imgsLogin.TransparentColor = System.Drawing.Color.Transparent;
            this.imgsLogin.Images.SetKeyName(0, "059-success.png");
            this.imgsLogin.Images.SetKeyName(1, "021-view.png");
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(455, 221);
            this.Controls.Add(this.pnIgreja);
            this.Controls.Add(this.pnLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SisIg - Bem vindo!";
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.pnLoading.ResumeLayout(false);
            this.pnIgreja.ResumeLayout(false);
            this.pnIgreja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIgreja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLoading;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnIgreja;
        public System.Windows.Forms.PictureBox pcIgreja;
        private System.Windows.Forms.Label lblIgreja;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnMostrarSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ImageList imgsLogin;
    }
}