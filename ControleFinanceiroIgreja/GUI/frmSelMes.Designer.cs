namespace ControleFinanceiroIgreja.GUI
{
    partial class frmSelMes
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
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkDinamico = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMes
            // 
            this.cbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(7, 67);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(193, 27);
            this.cbMes.TabIndex = 55;
            this.cbMes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbMes_DrawItem);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(6, 44);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(42, 20);
            this.lblMes.TabIndex = 54;
            this.lblMes.Text = "Mês";
            // 
            // cbAno
            // 
            this.cbAno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(7, 125);
            this.cbAno.MaxLength = 4;
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(193, 27);
            this.cbAno.TabIndex = 57;
            this.cbAno.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbAno_DrawItem);
            this.cbAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAno_KeyPress);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(6, 102);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(41, 20);
            this.lblAno.TabIndex = 56;
            this.lblAno.Text = "Ano";
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(7, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(193, 30);
            this.btnOk.TabIndex = 58;
            this.btnOk.Text = "Gerar Relatório";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkDinamico
            // 
            this.chkDinamico.AutoSize = true;
            this.chkDinamico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDinamico.Location = new System.Drawing.Point(7, 7);
            this.chkDinamico.Name = "chkDinamico";
            this.chkDinamico.Size = new System.Drawing.Size(102, 24);
            this.chkDinamico.TabIndex = 59;
            this.chkDinamico.Text = "Dinâmico";
            this.toolTip1.SetToolTip(this.chkDinamico, "Permite selecionar um mês/ano inicial\r\nPor exemplo: se você seleciona Dezembro/20" +
        "15 \r\no relatório começará em dezembro de 2015 \r\ne terminará em novembro de 2016 " +
        "\r\n(período de 12 meses)\r\n");
            this.chkDinamico.UseVisualStyleBackColor = true;
            this.chkDinamico.Visible = false;
            this.chkDinamico.CheckedChanged += new System.EventHandler(this.chkDinamico_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Dicas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.chkDinamico);
            this.panel1.Controls.Add(this.lblMes);
            this.panel1.Controls.Add(this.cbMes);
            this.panel1.Controls.Add(this.cbAno);
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 225);
            this.panel1.TabIndex = 60;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::ControleFinanceiroIgreja.Properties.Resources.close;
            this.btnFechar.Location = new System.Drawing.Point(185, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 38);
            this.btnFechar.TabIndex = 61;
            this.btnFechar.TabStop = false;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmSelMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(229, 229);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelMes";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecione o mês/ano desejados";
            this.Load += new System.EventHandler(this.frmSelMes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkDinamico;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
    }
}