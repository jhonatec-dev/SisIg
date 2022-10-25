namespace ControleFinanceiroIgreja.GUI
{
    partial class frmMembros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsMembros = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cadastrarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsImpSel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsImpFicha = new System.Windows.Forms.ToolStripMenuItem();
            this.tsImpLista = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsImpAniversariantes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsImpGraficos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsImpGrafSexo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsImpGrafSitu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.pnControles = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.imgsMembros = new System.Windows.Forms.ImageList(this.components);
            this.lblReg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ttError = new System.Windows.Forms.ToolTip(this.components);
            this.dtgMembros = new System.Windows.Forms.DataGridView();
            this.pnFiltro = new System.Windows.Forms.Panel();
            this.btnAplicaFiltro = new System.Windows.Forms.Button();
            this.chkInativos = new System.Windows.Forms.CheckBox();
            this.cmsMembros.SuspendLayout();
            this.pnControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMembros)).BeginInit();
            this.pnFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMembros
            // 
            this.cmsMembros.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsMembros.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsMembros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarMenu,
            this.editarMenu,
            this.statusMenu,
            this.toolStripSeparator2,
            this.tsImprimir,
            this.toolStripSeparator6});
            this.cmsMembros.Name = "cmsMembros";
            this.cmsMembros.Size = new System.Drawing.Size(201, 174);
            this.cmsMembros.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cadastrarMenu
            // 
            this.cadastrarMenu.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarMenu.Image")));
            this.cadastrarMenu.Name = "cadastrarMenu";
            this.cadastrarMenu.Size = new System.Drawing.Size(200, 34);
            this.cadastrarMenu.Text = "Cadastrar";
            this.cadastrarMenu.Click += new System.EventHandler(this.cadastrarMenu_Click);
            // 
            // editarMenu
            // 
            this.editarMenu.Image = ((System.Drawing.Image)(resources.GetObject("editarMenu.Image")));
            this.editarMenu.Name = "editarMenu";
            this.editarMenu.Size = new System.Drawing.Size(200, 34);
            this.editarMenu.Text = "Editar";
            this.editarMenu.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // statusMenu
            // 
            this.statusMenu.Image = ((System.Drawing.Image)(resources.GetObject("statusMenu.Image")));
            this.statusMenu.Name = "statusMenu";
            this.statusMenu.ShortcutKeyDisplayString = "";
            this.statusMenu.Size = new System.Drawing.Size(200, 34);
            this.statusMenu.Text = "Ativar/Desativar";
            this.statusMenu.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // tsImprimir
            // 
            this.tsImprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsImpSel,
            this.tsImpFicha,
            this.tsImpLista,
            this.toolStripSeparator5,
            this.tsImpAniversariantes,
            this.toolStripSeparator7,
            this.tsImpGraficos});
            this.tsImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsImprimir.Image")));
            this.tsImprimir.Name = "tsImprimir";
            this.tsImprimir.Size = new System.Drawing.Size(200, 34);
            this.tsImprimir.Text = "Imprimir";
            // 
            // tsImpSel
            // 
            this.tsImpSel.Image = ((System.Drawing.Image)(resources.GetObject("tsImpSel.Image")));
            this.tsImpSel.Name = "tsImpSel";
            this.tsImpSel.Size = new System.Drawing.Size(216, 34);
            this.tsImpSel.Text = "Selecionado";
            this.tsImpSel.Click += new System.EventHandler(this.tsImpSel_Click);
            // 
            // tsImpFicha
            // 
            this.tsImpFicha.Image = ((System.Drawing.Image)(resources.GetObject("tsImpFicha.Image")));
            this.tsImpFicha.Name = "tsImpFicha";
            this.tsImpFicha.Size = new System.Drawing.Size(216, 34);
            this.tsImpFicha.Text = "Ficha para cadastro";
            this.tsImpFicha.Click += new System.EventHandler(this.tsImpFicha_Click);
            // 
            // tsImpLista
            // 
            this.tsImpLista.Image = ((System.Drawing.Image)(resources.GetObject("tsImpLista.Image")));
            this.tsImpLista.Name = "tsImpLista";
            this.tsImpLista.Size = new System.Drawing.Size(216, 34);
            this.tsImpLista.Text = "Lista de Membros";
            this.tsImpLista.Click += new System.EventHandler(this.tsImpLista_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(213, 6);
            // 
            // tsImpAniversariantes
            // 
            this.tsImpAniversariantes.Image = ((System.Drawing.Image)(resources.GetObject("tsImpAniversariantes.Image")));
            this.tsImpAniversariantes.Name = "tsImpAniversariantes";
            this.tsImpAniversariantes.Size = new System.Drawing.Size(216, 34);
            this.tsImpAniversariantes.Text = "Aniversariantes";
            this.tsImpAniversariantes.Click += new System.EventHandler(this.tsImpAniversariantes_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(213, 6);
            // 
            // tsImpGraficos
            // 
            this.tsImpGraficos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsImpGrafSexo,
            this.tsImpGrafSitu});
            this.tsImpGraficos.Image = ((System.Drawing.Image)(resources.GetObject("tsImpGraficos.Image")));
            this.tsImpGraficos.Name = "tsImpGraficos";
            this.tsImpGraficos.Size = new System.Drawing.Size(216, 34);
            this.tsImpGraficos.Text = "Gráficos";
            // 
            // tsImpGrafSexo
            // 
            this.tsImpGrafSexo.Image = ((System.Drawing.Image)(resources.GetObject("tsImpGrafSexo.Image")));
            this.tsImpGrafSexo.Name = "tsImpGrafSexo";
            this.tsImpGrafSexo.Size = new System.Drawing.Size(192, 34);
            this.tsImpGrafSexo.Text = "Por sexo";
            this.tsImpGrafSexo.Click += new System.EventHandler(this.tsImpGrafSexo_Click);
            // 
            // tsImpGrafSitu
            // 
            this.tsImpGrafSitu.Image = ((System.Drawing.Image)(resources.GetObject("tsImpGrafSitu.Image")));
            this.tsImpGrafSitu.Name = "tsImpGrafSitu";
            this.tsImpGrafSitu.Size = new System.Drawing.Size(192, 34);
            this.tsImpGrafSitu.Text = "Por situação";
            this.tsImpGrafSitu.Click += new System.EventHandler(this.tsImpGrafSitu_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(197, 6);
            // 
            // pnControles
            // 
            this.pnControles.BackColor = System.Drawing.SystemColors.Control;
            this.pnControles.Controls.Add(this.txtPesquisa);
            this.pnControles.Controls.Add(this.btnFiltros);
            this.pnControles.Controls.Add(this.lblReg);
            this.pnControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControles.ForeColor = System.Drawing.Color.White;
            this.pnControles.Location = new System.Drawing.Point(0, 0);
            this.pnControles.Name = "pnControles";
            this.pnControles.Padding = new System.Windows.Forms.Padding(5);
            this.pnControles.Size = new System.Drawing.Size(644, 48);
            this.pnControles.TabIndex = 9;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPesquisa.Location = new System.Drawing.Point(55, 10);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtPesquisa.MaxLength = 300;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(479, 29);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            this.txtPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyUp);
            // 
            // btnFiltros
            // 
            this.btnFiltros.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFiltros.ImageIndex = 1;
            this.btnFiltros.ImageList = this.imgsMembros;
            this.btnFiltros.Location = new System.Drawing.Point(5, 5);
            this.btnFiltros.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(46, 38);
            this.btnFiltros.TabIndex = 88;
            this.ttError.SetToolTip(this.btnFiltros, "Filtros de pesquisa");
            this.btnFiltros.UseVisualStyleBackColor = true;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // imgsMembros
            // 
            this.imgsMembros.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgsMembros.ImageStream")));
            this.imgsMembros.TransparentColor = System.Drawing.Color.Transparent;
            this.imgsMembros.Images.SetKeyName(0, "324-search.png");
            this.imgsMembros.Images.SetKeyName(1, "178-controls.png");
            // 
            // lblReg
            // 
            this.lblReg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblReg.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblReg.Location = new System.Drawing.Point(558, 5);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(81, 38);
            this.lblReg.TabIndex = 72;
            this.lblReg.Text = "123456gf\r\n hgdjkgh\r\n djfgh df";
            this.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 89;
            this.label3.Text = "Situação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 88;
            this.label2.Text = "Estado Civil";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.BackColor = System.Drawing.SystemColors.Window;
            this.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCivil.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "----------------",
            "SOLTEIRO",
            "CASADO",
            "VIÚVO",
            "DIVORCIADO",
            "OUTRO"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(147, 6);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(162, 24);
            this.cbEstadoCivil.TabIndex = 68;
            this.cbEstadoCivil.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbEstadoCivil_DrawItem);
            this.cbEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.cbSituacao_SelectedIndexChanged);
            // 
            // cbSituacao
            // 
            this.cbSituacao.BackColor = System.Drawing.SystemColors.Window;
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSituacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(147, 38);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(162, 24);
            this.cbSituacao.TabIndex = 70;
            this.cbSituacao.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbSituacao_DrawItem);
            this.cbSituacao.SelectedIndexChanged += new System.EventHandler(this.cbSituacao_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(219, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(219, 6);
            // 
            // dtgMembros
            // 
            this.dtgMembros.AllowUserToAddRows = false;
            this.dtgMembros.AllowUserToDeleteRows = false;
            this.dtgMembros.AllowUserToOrderColumns = true;
            this.dtgMembros.AllowUserToResizeColumns = false;
            this.dtgMembros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgMembros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMembros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgMembros.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgMembros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMembros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMembros.ContextMenuStrip = this.cmsMembros;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMembros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgMembros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMembros.Location = new System.Drawing.Point(0, 48);
            this.dtgMembros.MultiSelect = false;
            this.dtgMembros.Name = "dtgMembros";
            this.dtgMembros.ReadOnly = true;
            this.dtgMembros.RowHeadersVisible = false;
            this.dtgMembros.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMembros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMembros.Size = new System.Drawing.Size(644, 386);
            this.dtgMembros.StandardTab = true;
            this.dtgMembros.TabIndex = 8;
            this.dtgMembros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMembros_CellContentClick);
            this.dtgMembros.DoubleClick += new System.EventHandler(this.dtgMembros_DoubleClick);
            this.dtgMembros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgMembros_KeyDown);
            this.dtgMembros.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgMembros_MouseDown);
            // 
            // pnFiltro
            // 
            this.pnFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFiltro.Controls.Add(this.btnAplicaFiltro);
            this.pnFiltro.Controls.Add(this.chkInativos);
            this.pnFiltro.Controls.Add(this.label3);
            this.pnFiltro.Controls.Add(this.cbEstadoCivil);
            this.pnFiltro.Controls.Add(this.label2);
            this.pnFiltro.Controls.Add(this.cbSituacao);
            this.pnFiltro.Location = new System.Drawing.Point(45, 98);
            this.pnFiltro.Name = "pnFiltro";
            this.pnFiltro.Size = new System.Drawing.Size(317, 138);
            this.pnFiltro.TabIndex = 10;
            this.pnFiltro.Visible = false;
            // 
            // btnAplicaFiltro
            // 
            this.btnAplicaFiltro.Location = new System.Drawing.Point(234, 107);
            this.btnAplicaFiltro.Name = "btnAplicaFiltro";
            this.btnAplicaFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnAplicaFiltro.TabIndex = 92;
            this.btnAplicaFiltro.Text = "Fechar";
            this.btnAplicaFiltro.UseVisualStyleBackColor = true;
            this.btnAplicaFiltro.Click += new System.EventHandler(this.btnAplicaFiltro_Click);
            // 
            // chkInativos
            // 
            this.chkInativos.AutoSize = true;
            this.chkInativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInativos.Location = new System.Drawing.Point(6, 76);
            this.chkInativos.Name = "chkInativos";
            this.chkInativos.Size = new System.Drawing.Size(121, 20);
            this.chkInativos.TabIndex = 91;
            this.chkInativos.Text = "Mostrar Inativos";
            this.chkInativos.UseVisualStyleBackColor = true;
            this.chkInativos.CheckedChanged += new System.EventHandler(this.chkInativos_CheckedChanged_1);
            // 
            // frmMembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 434);
            this.ControlBox = false;
            this.Controls.Add(this.pnFiltro);
            this.Controls.Add(this.dtgMembros);
            this.Controls.Add(this.pnControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMembros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Membros";
            this.Activated += new System.EventHandler(this.frmMembros_Activated);
            this.Load += new System.EventHandler(this.frmMembros_Load);
            this.Enter += new System.EventHandler(this.frmMembros_Enter);
            this.cmsMembros.ResumeLayout(false);
            this.pnControles.ResumeLayout(false);
            this.pnControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMembros)).EndInit();
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem editarMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem statusMenu;
        public System.Windows.Forms.ToolStripMenuItem cadastrarMenu;
        public System.Windows.Forms.ContextMenuStrip cmsMembros;
        private System.Windows.Forms.Panel pnControles;
        private System.Windows.Forms.TextBox txtPesquisa;
        public System.Windows.Forms.ComboBox cbEstadoCivil;
        public System.Windows.Forms.ComboBox cbSituacao;
        public System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.ToolTip ttError;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridView dtgMembros;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tsImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Panel pnFiltro;
        private System.Windows.Forms.CheckBox chkInativos;
        private System.Windows.Forms.Button btnAplicaFiltro;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.ImageList imgsMembros;
        private System.Windows.Forms.ToolStripMenuItem tsImpSel;
        private System.Windows.Forms.ToolStripMenuItem tsImpFicha;
        private System.Windows.Forms.ToolStripMenuItem tsImpLista;
        private System.Windows.Forms.ToolStripMenuItem tsImpAniversariantes;
        private System.Windows.Forms.ToolStripMenuItem tsImpGraficos;
        private System.Windows.Forms.ToolStripMenuItem tsImpGrafSexo;
        private System.Windows.Forms.ToolStripMenuItem tsImpGrafSitu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}