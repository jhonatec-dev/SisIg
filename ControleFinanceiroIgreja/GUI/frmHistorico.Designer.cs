namespace ControleFinanceiroIgreja.GUI
{
    partial class frmHistorico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorico));
            this.dtgPontos = new System.Windows.Forms.DataGridView();
            this.cmsPontos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPontuar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRemover = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Imprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPontos)).BeginInit();
            this.cmsPontos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPontos
            // 
            this.dtgPontos.AllowUserToAddRows = false;
            this.dtgPontos.AllowUserToDeleteRows = false;
            this.dtgPontos.AllowUserToOrderColumns = true;
            this.dtgPontos.AllowUserToResizeColumns = false;
            this.dtgPontos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgPontos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPontos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgPontos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgPontos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPontos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPontos.ContextMenuStrip = this.cmsPontos;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPontos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPontos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPontos.Location = new System.Drawing.Point(0, 63);
            this.dtgPontos.MultiSelect = false;
            this.dtgPontos.Name = "dtgPontos";
            this.dtgPontos.ReadOnly = true;
            this.dtgPontos.RowHeadersVisible = false;
            this.dtgPontos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPontos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPontos.Size = new System.Drawing.Size(788, 374);
            this.dtgPontos.StandardTab = true;
            this.dtgPontos.TabIndex = 9;
            this.dtgPontos.DoubleClick += new System.EventHandler(this.editarMenu_Click);
            this.dtgPontos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgPontos_MouseDown);
            // 
            // cmsPontos
            // 
            this.cmsPontos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsPontos.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsPontos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarMenu,
            this.tsPontuar,
            this.tsRemover,
            this.toolStripSeparator1,
            this.Imprimir});
            this.cmsPontos.Name = "cmsMembros";
            this.cmsPontos.Size = new System.Drawing.Size(169, 184);
            // 
            // editarMenu
            // 
            this.editarMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.pencil_24;
            this.editarMenu.Name = "editarMenu";
            this.editarMenu.Size = new System.Drawing.Size(168, 38);
            this.editarMenu.Text = "Editar";
            this.editarMenu.Click += new System.EventHandler(this.editarMenu_Click);
            // 
            // tsPontuar
            // 
            this.tsPontuar.Image = global::ControleFinanceiroIgreja.Properties.Resources.compose_24;
            this.tsPontuar.Name = "tsPontuar";
            this.tsPontuar.Size = new System.Drawing.Size(168, 38);
            this.tsPontuar.Text = "Cadastrar";
            this.tsPontuar.Click += new System.EventHandler(this.tsPontuar_Click);
            // 
            // tsRemover
            // 
            this.tsRemover.Image = global::ControleFinanceiroIgreja.Properties.Resources.stop_24;
            this.tsRemover.Name = "tsRemover";
            this.tsRemover.Size = new System.Drawing.Size(168, 38);
            this.tsRemover.Text = "Remover";
            this.tsRemover.Click += new System.EventHandler(this.tsRemover_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // Imprimir
            // 
            this.Imprimir.Image = global::ControleFinanceiroIgreja.Properties.Resources.printer_48_black;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.ShortcutKeyDisplayString = "";
            this.Imprimir.Size = new System.Drawing.Size(168, 38);
            this.Imprimir.Text = "Imprimir";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtClasse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 63);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(350, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "Classe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClasse
            // 
            this.txtClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasse.Location = new System.Drawing.Point(353, 31);
            this.txtClasse.MaxLength = 300;
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.ReadOnly = true;
            this.txtClasse.Size = new System.Drawing.Size(318, 22);
            this.txtClasse.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 32);
            this.txtNome.MaxLength = 300;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(318, 22);
            this.txtNome.TabIndex = 78;
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 437);
            this.Controls.Add(this.dtgPontos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorico";
            this.Text = "Histórico de Pontos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHistorico_Load);
            this.Shown += new System.EventHandler(this.frmHistorico_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPontos)).EndInit();
            this.cmsPontos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPontos;
        public System.Windows.Forms.ContextMenuStrip cmsPontos;
        private System.Windows.Forms.ToolStripMenuItem editarMenu;
        public System.Windows.Forms.ToolStripMenuItem tsPontuar;
        private System.Windows.Forms.ToolStripMenuItem Imprimir;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClasse;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ToolStripMenuItem tsRemover;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}