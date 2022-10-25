namespace ControleFinanceiroIgreja.GUI
{
    partial class frmLancamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentos));
            this.gbRecebimentos = new System.Windows.Forms.GroupBox();
            this.dtgEntradas = new System.Windows.Forms.DataGridView();
            this.cmsEntradas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lancarEntradaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEntradasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.removerEntradaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tLayout = new System.Windows.Forms.TableLayoutPanel();
            this.gbSaidas = new System.Windows.Forms.GroupBox();
            this.dtgSaidas = new System.Windows.Forms.DataGridView();
            this.cmsSaidas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lançarSaidaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editarSaidaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.removerSaidaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSaldoGeral = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaldoMes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalSaidas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.menuImp = new System.Windows.Forms.MenuStrip();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosOsLançamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrupadosMensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.agrupadosAnualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gráficoDoMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoDoAnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.balanceteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceteGráficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.contribuintesMensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.membrosPorEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasPorMembroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.livroCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbRecebimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntradas)).BeginInit();
            this.cmsEntradas.SuspendLayout();
            this.tLayout.SuspendLayout();
            this.gbSaidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSaidas)).BeginInit();
            this.cmsSaidas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuImp.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRecebimentos
            // 
            this.gbRecebimentos.BackColor = System.Drawing.Color.LightGreen;
            this.gbRecebimentos.Controls.Add(this.dtgEntradas);
            this.gbRecebimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRecebimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecebimentos.ForeColor = System.Drawing.Color.Black;
            this.gbRecebimentos.Location = new System.Drawing.Point(3, 3);
            this.gbRecebimentos.Name = "gbRecebimentos";
            this.gbRecebimentos.Size = new System.Drawing.Size(561, 368);
            this.gbRecebimentos.TabIndex = 13;
            this.gbRecebimentos.TabStop = false;
            this.gbRecebimentos.Text = "Entradas";
            // 
            // dtgEntradas
            // 
            this.dtgEntradas.AllowUserToAddRows = false;
            this.dtgEntradas.AllowUserToDeleteRows = false;
            this.dtgEntradas.AllowUserToOrderColumns = true;
            this.dtgEntradas.AllowUserToResizeColumns = false;
            this.dtgEntradas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgEntradas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgEntradas.BackgroundColor = System.Drawing.Color.White;
            this.dtgEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEntradas.ContextMenuStrip = this.cmsEntradas;
            this.dtgEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEntradas.Location = new System.Drawing.Point(3, 22);
            this.dtgEntradas.MultiSelect = false;
            this.dtgEntradas.Name = "dtgEntradas";
            this.dtgEntradas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgEntradas.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dtgEntradas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEntradas.Size = new System.Drawing.Size(555, 343);
            this.dtgEntradas.TabIndex = 16;
            this.dtgEntradas.DoubleClick += new System.EventHandler(this.dtgEntradas_DoubleClick);
            this.dtgEntradas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgEntradas_MouseDown);
            // 
            // cmsEntradas
            // 
            this.cmsEntradas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsEntradas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lancarEntradaMenu,
            this.editarEntradasMenu,
            this.removerEntradaMenu});
            this.cmsEntradas.Name = "cmsEntradas";
            this.cmsEntradas.Size = new System.Drawing.Size(174, 118);
            this.cmsEntradas.Opening += new System.ComponentModel.CancelEventHandler(this.cmsEntradas_Opening);
            // 
            // lancarEntradaMenu
            // 
            this.lancarEntradaMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.entrada_24;
            this.lancarEntradaMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lancarEntradaMenu.Name = "lancarEntradaMenu";
            this.lancarEntradaMenu.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.lancarEntradaMenu.ShowShortcutKeys = false;
            this.lancarEntradaMenu.Size = new System.Drawing.Size(173, 38);
            this.lancarEntradaMenu.Text = "Lançar Entrada";
            this.lancarEntradaMenu.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // editarEntradasMenu
            // 
            this.editarEntradasMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.pencil_24;
            this.editarEntradasMenu.Name = "editarEntradasMenu";
            this.editarEntradasMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.editarEntradasMenu.ShowShortcutKeys = false;
            this.editarEntradasMenu.Size = new System.Drawing.Size(173, 38);
            this.editarEntradasMenu.Text = "Editar Entrada";
            this.editarEntradasMenu.Click += new System.EventHandler(this.dtgEntradas_DoubleClick);
            // 
            // removerEntradaMenu
            // 
            this.removerEntradaMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.stop_24;
            this.removerEntradaMenu.Name = "removerEntradaMenu";
            this.removerEntradaMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F2)));
            this.removerEntradaMenu.ShowShortcutKeys = false;
            this.removerEntradaMenu.Size = new System.Drawing.Size(173, 38);
            this.removerEntradaMenu.Text = "Remover Entrada";
            this.removerEntradaMenu.Click += new System.EventHandler(this.removerEntradaMenu_Click);
            // 
            // tLayout
            // 
            this.tLayout.ColumnCount = 2;
            this.tLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.1749F));
            this.tLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.8251F));
            this.tLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLayout.Controls.Add(this.gbSaidas, 0, 0);
            this.tLayout.Controls.Add(this.gbRecebimentos, 0, 0);
            this.tLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayout.Location = new System.Drawing.Point(0, 54);
            this.tLayout.Name = "tLayout";
            this.tLayout.RowCount = 1;
            this.tLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 374F));
            this.tLayout.Size = new System.Drawing.Size(976, 374);
            this.tLayout.TabIndex = 14;
            this.tLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // gbSaidas
            // 
            this.gbSaidas.BackColor = System.Drawing.Color.Salmon;
            this.gbSaidas.Controls.Add(this.dtgSaidas);
            this.gbSaidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaidas.ForeColor = System.Drawing.Color.Black;
            this.gbSaidas.Location = new System.Drawing.Point(570, 3);
            this.gbSaidas.Name = "gbSaidas";
            this.gbSaidas.Size = new System.Drawing.Size(403, 368);
            this.gbSaidas.TabIndex = 10;
            this.gbSaidas.TabStop = false;
            this.gbSaidas.Text = "Saídas";
            this.gbSaidas.Enter += new System.EventHandler(this.gbSaidas_Enter);
            // 
            // dtgSaidas
            // 
            this.dtgSaidas.AllowUserToAddRows = false;
            this.dtgSaidas.AllowUserToDeleteRows = false;
            this.dtgSaidas.AllowUserToOrderColumns = true;
            this.dtgSaidas.AllowUserToResizeColumns = false;
            this.dtgSaidas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgSaidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgSaidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgSaidas.BackgroundColor = System.Drawing.Color.White;
            this.dtgSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSaidas.ContextMenuStrip = this.cmsSaidas;
            this.dtgSaidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSaidas.Location = new System.Drawing.Point(3, 22);
            this.dtgSaidas.MultiSelect = false;
            this.dtgSaidas.Name = "dtgSaidas";
            this.dtgSaidas.ReadOnly = true;
            this.dtgSaidas.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dtgSaidas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgSaidas.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSaidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSaidas.Size = new System.Drawing.Size(397, 343);
            this.dtgSaidas.TabIndex = 15;
            this.dtgSaidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSaidas_CellContentClick);
            this.dtgSaidas.DoubleClick += new System.EventHandler(this.dtgSaidas_DoubleClick);
            this.dtgSaidas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgSaidas_MouseDown);
            // 
            // cmsSaidas
            // 
            this.cmsSaidas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsSaidas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançarSaidaMenu,
            this.editarSaidaMenu,
            this.removerSaidaMenu});
            this.cmsSaidas.Name = "cmsSaidas";
            this.cmsSaidas.Size = new System.Drawing.Size(162, 118);
            // 
            // lançarSaidaMenu
            // 
            this.lançarSaidaMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.saida_24;
            this.lançarSaidaMenu.Name = "lançarSaidaMenu";
            this.lançarSaidaMenu.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.lançarSaidaMenu.ShowShortcutKeys = false;
            this.lançarSaidaMenu.Size = new System.Drawing.Size(161, 38);
            this.lançarSaidaMenu.Text = "Lançar Saídas";
            this.lançarSaidaMenu.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // editarSaidaMenu
            // 
            this.editarSaidaMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.pencil_24;
            this.editarSaidaMenu.Name = "editarSaidaMenu";
            this.editarSaidaMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.editarSaidaMenu.ShowShortcutKeys = false;
            this.editarSaidaMenu.Size = new System.Drawing.Size(161, 38);
            this.editarSaidaMenu.Text = "Editar Saída";
            this.editarSaidaMenu.Click += new System.EventHandler(this.dtgSaidas_DoubleClick);
            // 
            // removerSaidaMenu
            // 
            this.removerSaidaMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.stop_24;
            this.removerSaidaMenu.Name = "removerSaidaMenu";
            this.removerSaidaMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F3)));
            this.removerSaidaMenu.ShowShortcutKeys = false;
            this.removerSaidaMenu.Size = new System.Drawing.Size(161, 38);
            this.removerSaidaMenu.Text = "Remover Saída";
            this.removerSaidaMenu.Click += new System.EventHandler(this.removerSaidaMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lblSaldoGeral);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblSaldoMes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotalSaidas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotalEntradas);
            this.panel1.Controls.Add(this.menuImp);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.cbAno);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbMes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 54);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lblSaldoGeral
            // 
            this.lblSaldoGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoGeral.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSaldoGeral.Location = new System.Drawing.Point(755, 6);
            this.lblSaldoGeral.Name = "lblSaldoGeral";
            this.lblSaldoGeral.Size = new System.Drawing.Size(146, 20);
            this.lblSaldoGeral.TabIndex = 87;
            this.lblSaldoGeral.Text = "R$ 0.000.000,00";
            this.lblSaldoGeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(598, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 86;
            this.label5.Text = "Saldo do Mês";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaldoMes
            // 
            this.lblSaldoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMes.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSaldoMes.Location = new System.Drawing.Point(594, 6);
            this.lblSaldoMes.Name = "lblSaldoMes";
            this.lblSaldoMes.Size = new System.Drawing.Size(149, 20);
            this.lblSaldoMes.TabIndex = 85;
            this.lblSaldoMes.Text = "R$ 0.000.000,00";
            this.lblSaldoMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 84;
            this.label1.Text = "Total de Saídas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSaidas
            // 
            this.lblTotalSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaidas.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSaidas.Location = new System.Drawing.Point(439, 6);
            this.lblTotalSaidas.Name = "lblTotalSaidas";
            this.lblTotalSaidas.Size = new System.Drawing.Size(149, 20);
            this.lblTotalSaidas.TabIndex = 83;
            this.lblTotalSaidas.Text = "R$ 0.000.000,00";
            this.lblTotalSaidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "Total de Entradas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalEntradas.Location = new System.Drawing.Point(284, 6);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(149, 20);
            this.lblTotalEntradas.TabIndex = 81;
            this.lblTotalEntradas.Text = "R$ 0.000.000,00";
            this.lblTotalEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuImp
            // 
            this.menuImp.AutoSize = false;
            this.menuImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuImp.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuImp.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuImp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem});
            this.menuImp.Location = new System.Drawing.Point(922, 0);
            this.menuImp.Name = "menuImp";
            this.menuImp.Size = new System.Drawing.Size(54, 54);
            this.menuImp.TabIndex = 79;
            this.menuImp.Text = "menuStrip1";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.AutoSize = false;
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosOsLançamentosToolStripMenuItem,
            this.agrupadosMensalToolStripMenuItem,
            this.toolStripSeparator1,
            this.agrupadosAnualToolStripMenuItem,
            this.toolStripSeparator2,
            this.gráficoDoMêsToolStripMenuItem,
            this.gráficoDoAnoToolStripMenuItem,
            this.toolStripSeparator3,
            this.balanceteToolStripMenuItem,
            this.balanceteGráficoToolStripMenuItem,
            this.toolStripSeparator4,
            this.contribuintesMensalToolStripMenuItem,
            this.toolStripSeparator5,
            this.membrosPorEntradaToolStripMenuItem,
            this.entradasPorMembroToolStripMenuItem,
            this.toolStripSeparator6,
            this.livroCaixaToolStripMenuItem});
            this.imprimirToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.printer_48;
            this.imprimirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(48, 48);
            this.imprimirToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.imprimirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.imprimirToolStripMenuItem.DropDownClosed += new System.EventHandler(this.imprimirToolStripMenuItem_DropDownClosed);
            this.imprimirToolStripMenuItem.DropDownOpened += new System.EventHandler(this.imprimirToolStripMenuItem_DropDownOpened);
            // 
            // todosOsLançamentosToolStripMenuItem
            // 
            this.todosOsLançamentosToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.document_48;
            this.todosOsLançamentosToolStripMenuItem.Name = "todosOsLançamentosToolStripMenuItem";
            this.todosOsLançamentosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.todosOsLançamentosToolStripMenuItem.Text = "Todos os Lançamentos";
            this.todosOsLançamentosToolStripMenuItem.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // agrupadosMensalToolStripMenuItem
            // 
            this.agrupadosMensalToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.flow;
            this.agrupadosMensalToolStripMenuItem.Name = "agrupadosMensalToolStripMenuItem";
            this.agrupadosMensalToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.agrupadosMensalToolStripMenuItem.Text = "Agrupados (Mensal)";
            this.agrupadosMensalToolStripMenuItem.Click += new System.EventHandler(this.impAgrupado);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // agrupadosAnualToolStripMenuItem
            // 
            this.agrupadosAnualToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.flow;
            this.agrupadosAnualToolStripMenuItem.Name = "agrupadosAnualToolStripMenuItem";
            this.agrupadosAnualToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.agrupadosAnualToolStripMenuItem.Text = "Agrupados (Anual)";
            this.agrupadosAnualToolStripMenuItem.Click += new System.EventHandler(this.impAgrupadoAnual);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // gráficoDoMêsToolStripMenuItem
            // 
            this.gráficoDoMêsToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.piechart_32;
            this.gráficoDoMêsToolStripMenuItem.Name = "gráficoDoMêsToolStripMenuItem";
            this.gráficoDoMêsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gráficoDoMêsToolStripMenuItem.Text = "Gráfico do Mês";
            this.gráficoDoMêsToolStripMenuItem.Click += new System.EventHandler(this.impGrafico);
            // 
            // gráficoDoAnoToolStripMenuItem
            // 
            this.gráficoDoAnoToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.piechart_32;
            this.gráficoDoAnoToolStripMenuItem.Name = "gráficoDoAnoToolStripMenuItem";
            this.gráficoDoAnoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gráficoDoAnoToolStripMenuItem.Text = "Gráfico do Ano";
            this.gráficoDoAnoToolStripMenuItem.Click += new System.EventHandler(this.impGraficoAnual);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // balanceteToolStripMenuItem
            // 
            this.balanceteToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.balancete;
            this.balanceteToolStripMenuItem.Name = "balanceteToolStripMenuItem";
            this.balanceteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.balanceteToolStripMenuItem.Text = "Balancete";
            this.balanceteToolStripMenuItem.Click += new System.EventHandler(this.ribRelLancBal_Click);
            // 
            // balanceteGráficoToolStripMenuItem
            // 
            this.balanceteGráficoToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.analytics;
            this.balanceteGráficoToolStripMenuItem.Name = "balanceteGráficoToolStripMenuItem";
            this.balanceteGráficoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.balanceteGráficoToolStripMenuItem.Text = "Balancete (Gráfico)";
            this.balanceteGráficoToolStripMenuItem.Click += new System.EventHandler(this.ribRelLancBalChrt_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // contribuintesMensalToolStripMenuItem
            // 
            this.contribuintesMensalToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.star_48;
            this.contribuintesMensalToolStripMenuItem.Name = "contribuintesMensalToolStripMenuItem";
            this.contribuintesMensalToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.contribuintesMensalToolStripMenuItem.Text = "Contribuintes (Mensal)";
            this.contribuintesMensalToolStripMenuItem.Click += new System.EventHandler(this.ribRelLancCont_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(192, 6);
            // 
            // membrosPorEntradaToolStripMenuItem
            // 
            this.membrosPorEntradaToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.calendar_48;
            this.membrosPorEntradaToolStripMenuItem.Name = "membrosPorEntradaToolStripMenuItem";
            this.membrosPorEntradaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.membrosPorEntradaToolStripMenuItem.Text = "Membros por Entrada";
            this.membrosPorEntradaToolStripMenuItem.Click += new System.EventHandler(this.ribRelLanMemEnt_Click);
            // 
            // entradasPorMembroToolStripMenuItem
            // 
            this.entradasPorMembroToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.calendar_48;
            this.entradasPorMembroToolStripMenuItem.Name = "entradasPorMembroToolStripMenuItem";
            this.entradasPorMembroToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.entradasPorMembroToolStripMenuItem.Text = "Entradas por Membro";
            this.entradasPorMembroToolStripMenuItem.Click += new System.EventHandler(this.ribRelLancEntMem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(192, 6);
            // 
            // livroCaixaToolStripMenuItem
            // 
            this.livroCaixaToolStripMenuItem.Name = "livroCaixaToolStripMenuItem";
            this.livroCaixaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.livroCaixaToolStripMenuItem.Text = "Livro Caixa";
            this.livroCaixaToolStripMenuItem.Click += new System.EventHandler(this.livroCaixaToolStripMenuItem_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.AutoSize = true;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Image = global::ControleFinanceiroIgreja.Properties.Resources.refresh_24;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(213, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(57, 46);
            this.btnAtualizar.TabIndex = 77;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // cbAno
            // 
            this.cbAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbAno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(128, 22);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(82, 27);
            this.cbAno.TabIndex = 70;
            this.cbAno.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbAno_DrawItem);
            this.cbAno.SelectedIndexChanged += new System.EventHandler(this.cbAno_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(128, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 22);
            this.label6.TabIndex = 71;
            this.label6.Text = "Ano";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMes
            // 
            this.cbMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbMes.Location = new System.Drawing.Point(6, 22);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(116, 27);
            this.cbMes.TabIndex = 69;
            this.cbMes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbMes_DrawItem);
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 22);
            this.label7.TabIndex = 72;
            this.label7.Text = "Mês";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(756, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 88;
            this.label3.Text = "Saldo Final";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 428);
            this.ControlBox = false;
            this.Controls.Add(this.tLayout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lançamentos";
            this.Activated += new System.EventHandler(this.frmLancamentos_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLancamentos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLancamentos_FormClosed);
            this.Load += new System.EventHandler(this.frmLancamentos_Load);
            this.Enter += new System.EventHandler(this.frmLancamentos_Enter);
            this.gbRecebimentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntradas)).EndInit();
            this.cmsEntradas.ResumeLayout(false);
            this.tLayout.ResumeLayout(false);
            this.gbSaidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSaidas)).EndInit();
            this.cmsSaidas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuImp.ResumeLayout(false);
            this.menuImp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRecebimentos;
        private System.Windows.Forms.DataGridView dtgEntradas;
        private System.Windows.Forms.TableLayoutPanel tLayout;
        private System.Windows.Forms.GroupBox gbSaidas;
        private System.Windows.Forms.DataGridView dtgSaidas;
        private System.Windows.Forms.ContextMenuStrip cmsEntradas;
        private System.Windows.Forms.ToolStripMenuItem lancarEntradaMenu;
        private System.Windows.Forms.ToolStripMenuItem editarEntradasMenu;
        private System.Windows.Forms.ToolStripMenuItem removerEntradaMenu;
        private System.Windows.Forms.ContextMenuStrip cmsSaidas;
        private System.Windows.Forms.ToolStripMenuItem lançarSaidaMenu;
        private System.Windows.Forms.ToolStripMenuItem editarSaidaMenu;
        private System.Windows.Forms.ToolStripMenuItem removerSaidaMenu;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cbAno;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbMes;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.MenuStrip menuImp;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosOsLançamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrupadosMensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem agrupadosAnualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem gráficoDoMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoDoAnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem balanceteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceteGráficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem contribuintesMensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem membrosPorEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasPorMembroToolStripMenuItem;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblSaldoGeral;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblSaldoMes;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTotalSaidas;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem livroCaixaToolStripMenuItem;
    }
}