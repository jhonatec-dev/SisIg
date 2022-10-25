namespace ControleFinanceiroIgreja.GUI
{
    partial class frmCargosMembros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargosMembros));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbCargosOc = new System.Windows.Forms.GroupBox();
            this.dtgCargosOcup = new System.Windows.Forms.DataGridView();
            this.cmsCargosOcupados = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarOcupados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastrarOcupados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.removerOcupados = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCargos = new System.Windows.Forms.GroupBox();
            this.dtgCargos = new System.Windows.Forms.DataGridView();
            this.cmsCargos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastrarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.menuImp = new System.Windows.Forms.MenuStrip();
            this.tsImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCargosOc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargosOcup)).BeginInit();
            this.cmsCargosOcupados.SuspendLayout();
            this.gbCargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargos)).BeginInit();
            this.cmsCargos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuImp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24747F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.75253F));
            this.tableLayoutPanel1.Controls.Add(this.gbCargosOc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbCargos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 378);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbCargosOc
            // 
            this.gbCargosOc.Controls.Add(this.dtgCargosOcup);
            this.gbCargosOc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCargosOc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargosOc.Location = new System.Drawing.Point(183, 3);
            this.gbCargosOc.Name = "gbCargosOc";
            this.gbCargosOc.Size = new System.Drawing.Size(703, 372);
            this.gbCargosOc.TabIndex = 1;
            this.gbCargosOc.TabStop = false;
            this.gbCargosOc.Text = "Cargos ocupados";
            // 
            // dtgCargosOcup
            // 
            this.dtgCargosOcup.AllowUserToAddRows = false;
            this.dtgCargosOcup.AllowUserToDeleteRows = false;
            this.dtgCargosOcup.AllowUserToOrderColumns = true;
            this.dtgCargosOcup.AllowUserToResizeColumns = false;
            this.dtgCargosOcup.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgCargosOcup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCargosOcup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgCargosOcup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgCargosOcup.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgCargosOcup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgCargosOcup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCargosOcup.ContextMenuStrip = this.cmsCargosOcupados;
            this.dtgCargosOcup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCargosOcup.Location = new System.Drawing.Point(3, 18);
            this.dtgCargosOcup.MultiSelect = false;
            this.dtgCargosOcup.Name = "dtgCargosOcup";
            this.dtgCargosOcup.ReadOnly = true;
            this.dtgCargosOcup.RowHeadersVisible = false;
            this.dtgCargosOcup.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCargosOcup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCargosOcup.Size = new System.Drawing.Size(697, 351);
            this.dtgCargosOcup.TabIndex = 9;
            this.dtgCargosOcup.DoubleClick += new System.EventHandler(this.editarOcupados_Click);
            this.dtgCargosOcup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgCargosOcup_MouseDown);
            // 
            // cmsCargosOcupados
            // 
            this.cmsCargosOcupados.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsCargosOcupados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarOcupados,
            this.toolStripSeparator3,
            this.cadastrarOcupados,
            this.toolStripSeparator4,
            this.removerOcupados});
            this.cmsCargosOcupados.Name = "cmsMembros";
            this.cmsCargosOcupados.Size = new System.Drawing.Size(141, 130);
            // 
            // editarOcupados
            // 
            this.editarOcupados.Image = global::ControleFinanceiroIgreja.Properties.Resources.pencil_24;
            this.editarOcupados.Name = "editarOcupados";
            this.editarOcupados.Size = new System.Drawing.Size(140, 38);
            this.editarOcupados.Text = "Editar";
            this.editarOcupados.Click += new System.EventHandler(this.editarOcupados_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
            // 
            // cadastrarOcupados
            // 
            this.cadastrarOcupados.Image = global::ControleFinanceiroIgreja.Properties.Resources.compose_24;
            this.cadastrarOcupados.Name = "cadastrarOcupados";
            this.cadastrarOcupados.Size = new System.Drawing.Size(140, 38);
            this.cadastrarOcupados.Text = "Cadastrar";
            this.cadastrarOcupados.Click += new System.EventHandler(this.cadastrarOcupados_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(137, 6);
            // 
            // removerOcupados
            // 
            this.removerOcupados.Image = global::ControleFinanceiroIgreja.Properties.Resources.stop_24;
            this.removerOcupados.Name = "removerOcupados";
            this.removerOcupados.Size = new System.Drawing.Size(140, 38);
            this.removerOcupados.Text = "Remover";
            this.removerOcupados.Click += new System.EventHandler(this.removerOcupados_Click);
            // 
            // gbCargos
            // 
            this.gbCargos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbCargos.Controls.Add(this.dtgCargos);
            this.gbCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargos.Location = new System.Drawing.Point(3, 3);
            this.gbCargos.Name = "gbCargos";
            this.gbCargos.Size = new System.Drawing.Size(174, 372);
            this.gbCargos.TabIndex = 0;
            this.gbCargos.TabStop = false;
            this.gbCargos.Text = "Cargos";
            // 
            // dtgCargos
            // 
            this.dtgCargos.AllowUserToAddRows = false;
            this.dtgCargos.AllowUserToDeleteRows = false;
            this.dtgCargos.AllowUserToOrderColumns = true;
            this.dtgCargos.AllowUserToResizeColumns = false;
            this.dtgCargos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgCargos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgCargos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgCargos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCargos.ContextMenuStrip = this.cmsCargos;
            this.dtgCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCargos.Location = new System.Drawing.Point(3, 18);
            this.dtgCargos.MultiSelect = false;
            this.dtgCargos.Name = "dtgCargos";
            this.dtgCargos.ReadOnly = true;
            this.dtgCargos.RowHeadersVisible = false;
            this.dtgCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCargos.Size = new System.Drawing.Size(168, 351);
            this.dtgCargos.TabIndex = 10;
            this.dtgCargos.DoubleClick += new System.EventHandler(this.editarMenu_Click);
            this.dtgCargos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgCargos_MouseDown);
            // 
            // cmsCargos
            // 
            this.cmsCargos.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsCargos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarMenu,
            this.toolStripSeparator1,
            this.cadastrarMenu,
            this.toolStripSeparator2,
            this.removerMenu});
            this.cmsCargos.Name = "cmsMembros";
            this.cmsCargos.Size = new System.Drawing.Size(141, 130);
            // 
            // editarMenu
            // 
            this.editarMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.pencil_24;
            this.editarMenu.Name = "editarMenu";
            this.editarMenu.Size = new System.Drawing.Size(140, 38);
            this.editarMenu.Text = "Editar";
            this.editarMenu.Click += new System.EventHandler(this.editarMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // cadastrarMenu
            // 
            this.cadastrarMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.compose_24;
            this.cadastrarMenu.Name = "cadastrarMenu";
            this.cadastrarMenu.Size = new System.Drawing.Size(140, 38);
            this.cadastrarMenu.Text = "Cadastrar";
            this.cadastrarMenu.Click += new System.EventHandler(this.cadastrarMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // removerMenu
            // 
            this.removerMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.stop_24;
            this.removerMenu.Name = "removerMenu";
            this.removerMenu.Size = new System.Drawing.Size(140, 38);
            this.removerMenu.Text = "Remover";
            this.removerMenu.Click += new System.EventHandler(this.removerMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuImp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 54);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.lblDesc);
            this.panel2.Controls.Add(this.txtAno);
            this.panel2.Location = new System.Drawing.Point(11, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 36);
            this.panel2.TabIndex = 98;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.AutoSize = true;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Image = global::ControleFinanceiroIgreja.Properties.Resources.filtrar_24;
            this.btnFiltrar.Location = new System.Drawing.Point(143, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(82, 28);
            this.btnFiltrar.TabIndex = 97;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.filtrar);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(9, 9);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(92, 16);
            this.lblDesc.TabIndex = 95;
            this.lblDesc.Text = "Digite o ano";
            this.lblDesc.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.ForeColor = System.Drawing.Color.White;
            this.txtAno.Location = new System.Drawing.Point(7, 5);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(130, 22);
            this.txtAno.TabIndex = 96;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsAno_KeyPress);
            this.txtAno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAno_KeyUp);
            // 
            // menuImp
            // 
            this.menuImp.AutoSize = false;
            this.menuImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuImp.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuImp.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuImp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsImprimir});
            this.menuImp.Location = new System.Drawing.Point(835, 0);
            this.menuImp.Name = "menuImp";
            this.menuImp.Size = new System.Drawing.Size(54, 54);
            this.menuImp.TabIndex = 94;
            this.menuImp.Text = "menuStrip1";
            // 
            // tsImprimir
            // 
            this.tsImprimir.AutoSize = false;
            this.tsImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tsImprimir.Image = global::ControleFinanceiroIgreja.Properties.Resources.printer_48;
            this.tsImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsImprimir.Name = "tsImprimir";
            this.tsImprimir.Size = new System.Drawing.Size(54, 48);
            this.tsImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsImprimir.Click += new System.EventHandler(this.imprimir);
            // 
            // frmCargosMembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 432);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargosMembros";
            this.Text = "Cargos";
            this.Activated += new System.EventHandler(this.frmCargosMembros_Activated);
            this.Deactivate += new System.EventHandler(this.frmCargosMembros_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCargosMembros_FormClosed);
            this.Load += new System.EventHandler(this.frmCargosMembros_Load);
            this.Shown += new System.EventHandler(this.frmCargosMembros_Shown);
            this.Enter += new System.EventHandler(this.frmCargosMembros_Enter);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbCargosOc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargosOcup)).EndInit();
            this.cmsCargosOcupados.ResumeLayout(false);
            this.gbCargos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargos)).EndInit();
            this.cmsCargos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuImp.ResumeLayout(false);
            this.menuImp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbCargosOc;
        private System.Windows.Forms.GroupBox gbCargos;
        private System.Windows.Forms.DataGridView dtgCargosOcup;
        private System.Windows.Forms.ContextMenuStrip cmsCargos;
        private System.Windows.Forms.ToolStripMenuItem editarMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem removerMenu;
        private System.Windows.Forms.DataGridView dtgCargos;
        private System.Windows.Forms.ContextMenuStrip cmsCargosOcupados;
        private System.Windows.Forms.ToolStripMenuItem editarOcupados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cadastrarOcupados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem removerOcupados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuImp;
        private System.Windows.Forms.ToolStripMenuItem tsImprimir;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel panel2;
    }
}