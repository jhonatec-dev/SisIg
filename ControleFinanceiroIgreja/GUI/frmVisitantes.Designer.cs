namespace ControleFinanceiroIgreja.GUI
{
    partial class frmVisitantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitantes));
            this.dtgVisitantes = new System.Windows.Forms.DataGridView();
            this.cmsVisitantes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastrarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.removerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastrarComoMembroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbVisitantes = new System.Windows.Forms.GroupBox();
            this.gbVisitas = new System.Windows.Forms.GroupBox();
            this.dtgVisitas = new System.Windows.Forms.DataGridView();
            this.cmsVisitas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarVisitas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastrarVisitas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.removerVisitas = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuImp = new System.Windows.Forms.MenuStrip();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaParaCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLista = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aniversariantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPesq = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblReg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitantes)).BeginInit();
            this.cmsVisitantes.SuspendLayout();
            this.gbVisitantes.SuspendLayout();
            this.gbVisitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitas)).BeginInit();
            this.cmsVisitas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuImp.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVisitantes
            // 
            this.dtgVisitantes.AllowUserToAddRows = false;
            this.dtgVisitantes.AllowUserToDeleteRows = false;
            this.dtgVisitantes.AllowUserToOrderColumns = true;
            this.dtgVisitantes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgVisitantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVisitantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgVisitantes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisitantes.ContextMenuStrip = this.cmsVisitantes;
            this.dtgVisitantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgVisitantes.Location = new System.Drawing.Point(3, 22);
            this.dtgVisitantes.MultiSelect = false;
            this.dtgVisitantes.Name = "dtgVisitantes";
            this.dtgVisitantes.ReadOnly = true;
            this.dtgVisitantes.RowHeadersVisible = false;
            this.dtgVisitantes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgVisitantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVisitantes.Size = new System.Drawing.Size(517, 445);
            this.dtgVisitantes.TabIndex = 11;
            this.dtgVisitantes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVisitantes_RowEnter);
            this.dtgVisitantes.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dtgVisitantes_RowStateChanged);
            this.dtgVisitantes.SelectionChanged += new System.EventHandler(this.dtgVisitantes_SelectionChanged);
            this.dtgVisitantes.DoubleClick += new System.EventHandler(this.btnEditar_Click);
            this.dtgVisitantes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgVisitantes_MouseDown);
            // 
            // cmsVisitantes
            // 
            this.cmsVisitantes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsVisitantes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarMenu,
            this.toolStripSeparator1,
            this.cadastrarMenu,
            this.toolStripSeparator2,
            this.imprimirMenu,
            this.toolStripSeparator6,
            this.removerMenu,
            this.toolStripSeparator3,
            this.cadastrarComoMembroToolStripMenuItem});
            this.cmsVisitantes.Name = "cmsMembros";
            this.cmsVisitantes.Size = new System.Drawing.Size(224, 218);
            // 
            // editarMenu
            // 
            this.editarMenu.BackColor = System.Drawing.SystemColors.Control;
            this.editarMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.pencil_24;
            this.editarMenu.Name = "editarMenu";
            this.editarMenu.Size = new System.Drawing.Size(223, 38);
            this.editarMenu.Text = "Editar";
            this.editarMenu.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // cadastrarMenu
            // 
            this.cadastrarMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.add_24;
            this.cadastrarMenu.Name = "cadastrarMenu";
            this.cadastrarMenu.Size = new System.Drawing.Size(223, 38);
            this.cadastrarMenu.Text = "Cadastrar";
            this.cadastrarMenu.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // imprimirMenu
            // 
            this.imprimirMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.printer_48_black;
            this.imprimirMenu.Name = "imprimirMenu";
            this.imprimirMenu.Size = new System.Drawing.Size(223, 38);
            this.imprimirMenu.Text = "Imprimir";
            this.imprimirMenu.Click += new System.EventHandler(this.imprimirSelecionado);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(220, 6);
            // 
            // removerMenu
            // 
            this.removerMenu.Image = global::ControleFinanceiroIgreja.Properties.Resources.stop_24;
            this.removerMenu.Name = "removerMenu";
            this.removerMenu.Size = new System.Drawing.Size(223, 38);
            this.removerMenu.Text = "Remover";
            this.removerMenu.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // cadastrarComoMembroToolStripMenuItem
            // 
            this.cadastrarComoMembroToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.profle_32;
            this.cadastrarComoMembroToolStripMenuItem.Name = "cadastrarComoMembroToolStripMenuItem";
            this.cadastrarComoMembroToolStripMenuItem.Size = new System.Drawing.Size(223, 38);
            this.cadastrarComoMembroToolStripMenuItem.Text = "Cadastrar como Membro";
            this.cadastrarComoMembroToolStripMenuItem.Click += new System.EventHandler(this.cadastrarComoMembroToolStripMenuItem_Click);
            // 
            // gbVisitantes
            // 
            this.gbVisitantes.Controls.Add(this.dtgVisitantes);
            this.gbVisitantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVisitantes.Location = new System.Drawing.Point(3, 3);
            this.gbVisitantes.Name = "gbVisitantes";
            this.gbVisitantes.Size = new System.Drawing.Size(523, 470);
            this.gbVisitantes.TabIndex = 12;
            this.gbVisitantes.TabStop = false;
            this.gbVisitantes.Text = "Visitantes";
            this.gbVisitantes.Enter += new System.EventHandler(this.gbVisitantes_Enter);
            // 
            // gbVisitas
            // 
            this.gbVisitas.Controls.Add(this.dtgVisitas);
            this.gbVisitas.Controls.Add(this.panel1);
            this.gbVisitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVisitas.Enabled = false;
            this.gbVisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVisitas.Location = new System.Drawing.Point(532, 3);
            this.gbVisitas.Name = "gbVisitas";
            this.gbVisitas.Size = new System.Drawing.Size(293, 470);
            this.gbVisitas.TabIndex = 12;
            this.gbVisitas.TabStop = false;
            this.gbVisitas.Text = "Visitas";
            this.gbVisitas.Enter += new System.EventHandler(this.gbVisitas_Enter);
            // 
            // dtgVisitas
            // 
            this.dtgVisitas.AllowUserToAddRows = false;
            this.dtgVisitas.AllowUserToDeleteRows = false;
            this.dtgVisitas.AllowUserToOrderColumns = true;
            this.dtgVisitas.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgVisitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgVisitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgVisitas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisitas.ContextMenuStrip = this.cmsVisitas;
            this.dtgVisitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgVisitas.Location = new System.Drawing.Point(3, 92);
            this.dtgVisitas.MultiSelect = false;
            this.dtgVisitas.Name = "dtgVisitas";
            this.dtgVisitas.ReadOnly = true;
            this.dtgVisitas.RowHeadersVisible = false;
            this.dtgVisitas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgVisitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVisitas.Size = new System.Drawing.Size(287, 375);
            this.dtgVisitas.TabIndex = 13;
            this.dtgVisitas.DoubleClick += new System.EventHandler(this.editarVisitas_Click);
            this.dtgVisitas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgVisitas_MouseDown);
            // 
            // cmsVisitas
            // 
            this.cmsVisitas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsVisitas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarVisitas,
            this.toolStripSeparator4,
            this.cadastrarVisitas,
            this.toolStripSeparator5,
            this.removerVisitas});
            this.cmsVisitas.Name = "cmsMembros";
            this.cmsVisitas.Size = new System.Drawing.Size(141, 130);
            // 
            // editarVisitas
            // 
            this.editarVisitas.Image = global::ControleFinanceiroIgreja.Properties.Resources.pencil_24;
            this.editarVisitas.Name = "editarVisitas";
            this.editarVisitas.Size = new System.Drawing.Size(140, 38);
            this.editarVisitas.Text = "Editar";
            this.editarVisitas.Click += new System.EventHandler(this.editarVisitas_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(137, 6);
            // 
            // cadastrarVisitas
            // 
            this.cadastrarVisitas.Image = global::ControleFinanceiroIgreja.Properties.Resources.add_24;
            this.cadastrarVisitas.Name = "cadastrarVisitas";
            this.cadastrarVisitas.Size = new System.Drawing.Size(140, 38);
            this.cadastrarVisitas.Text = "Cadastrar";
            this.cadastrarVisitas.Click += new System.EventHandler(this.cadastrarVisitas_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(137, 6);
            // 
            // removerVisitas
            // 
            this.removerVisitas.Image = global::ControleFinanceiroIgreja.Properties.Resources.stop_24;
            this.removerVisitas.Name = "removerVisitas";
            this.removerVisitas.Size = new System.Drawing.Size(140, 38);
            this.removerVisitas.Text = "Remover";
            this.removerVisitas.Click += new System.EventHandler(this.removerVisitas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 70);
            this.panel1.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Nome do visitante";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(3, 32);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(281, 26);
            this.txtNome.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.88889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.11111F));
            this.tableLayoutPanel1.Controls.Add(this.gbVisitas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbVisitantes, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 476);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.menuImp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblReg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 54);
            this.panel2.TabIndex = 14;
            // 
            // menuImp
            // 
            this.menuImp.AutoSize = false;
            this.menuImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuImp.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuImp.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuImp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem});
            this.menuImp.Location = new System.Drawing.Point(763, 0);
            this.menuImp.Name = "menuImp";
            this.menuImp.Size = new System.Drawing.Size(65, 54);
            this.menuImp.TabIndex = 84;
            this.menuImp.Text = "menuStrip1";
            this.menuImp.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuImp_ItemClicked);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.AutoSize = false;
            this.imprimirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichaParaCadastroToolStripMenuItem,
            this.toolStripSeparator7,
            this.tsLista,
            this.toolStripSeparator8,
            this.aniversariantesToolStripMenuItem});
            this.imprimirToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.printer_48;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(54, 48);
            this.imprimirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.imprimirToolStripMenuItem.DropDownClosed += new System.EventHandler(this.imprimirToolStripMenuItem_DropDownClosed);
            this.imprimirToolStripMenuItem.DropDownOpened += new System.EventHandler(this.imprimirToolStripMenuItem_DropDownOpened);
            // 
            // fichaParaCadastroToolStripMenuItem
            // 
            this.fichaParaCadastroToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.clipboard_48;
            this.fichaParaCadastroToolStripMenuItem.Name = "fichaParaCadastroToolStripMenuItem";
            this.fichaParaCadastroToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.fichaParaCadastroToolStripMenuItem.Text = "Ficha para cadastro";
            this.fichaParaCadastroToolStripMenuItem.Click += new System.EventHandler(this.impFichaNull);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(173, 6);
            // 
            // tsLista
            // 
            this.tsLista.Image = global::ControleFinanceiroIgreja.Properties.Resources.lista_membros;
            this.tsLista.Name = "tsLista";
            this.tsLista.Size = new System.Drawing.Size(176, 22);
            this.tsLista.Text = "Lista de visitantes";
            this.tsLista.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(173, 6);
            // 
            // aniversariantesToolStripMenuItem
            // 
            this.aniversariantesToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.bcake_32;
            this.aniversariantesToolStripMenuItem.Name = "aniversariantesToolStripMenuItem";
            this.aniversariantesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aniversariantesToolStripMenuItem.Text = "Aniversariantes";
            this.aniversariantesToolStripMenuItem.Click += new System.EventHandler(this.ribRelVisNiver_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(418, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 90;
            this.label1.Text = "registro(s)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblPesq);
            this.panel3.Controls.Add(this.txtPesquisa);
            this.panel3.Location = new System.Drawing.Point(12, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 40);
            this.panel3.TabIndex = 89;
            // 
            // lblPesq
            // 
            this.lblPesq.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesq.ForeColor = System.Drawing.Color.White;
            this.lblPesq.Location = new System.Drawing.Point(11, 6);
            this.lblPesq.Name = "lblPesq";
            this.lblPesq.Size = new System.Drawing.Size(79, 20);
            this.lblPesq.TabIndex = 77;
            this.lblPesq.Text = "Pesquisar";
            this.lblPesq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.White;
            this.txtPesquisa.Location = new System.Drawing.Point(4, 7);
            this.txtPesquisa.MaxLength = 300;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(389, 22);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            this.txtPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyUp);
            // 
            // lblReg
            // 
            this.lblReg.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.White;
            this.lblReg.Location = new System.Drawing.Point(418, 7);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(81, 22);
            this.lblReg.TabIndex = 88;
            this.lblReg.Text = "123456";
            this.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 530);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisitantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Visitantes";
            this.Activated += new System.EventHandler(this.frmVisitantes_Activated);
            this.Load += new System.EventHandler(this.frmVisitantes_Load);
            this.Shown += new System.EventHandler(this.frmVisitantes_Shown);
            this.Enter += new System.EventHandler(this.frmVisitantes_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitantes)).EndInit();
            this.cmsVisitantes.ResumeLayout(false);
            this.gbVisitantes.ResumeLayout(false);
            this.gbVisitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitas)).EndInit();
            this.cmsVisitas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuImp.ResumeLayout(false);
            this.menuImp.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgVisitantes;
        private System.Windows.Forms.GroupBox gbVisitantes;
        private System.Windows.Forms.GroupBox gbVisitas;
        private System.Windows.Forms.DataGridView dtgVisitas;
        private System.Windows.Forms.ContextMenuStrip cmsVisitas;
        private System.Windows.Forms.ToolStripMenuItem editarVisitas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVisitas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem removerVisitas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuImp;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaParaCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsLista;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aniversariantesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsVisitantes;
        private System.Windows.Forms.ToolStripMenuItem editarMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem removerMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cadastrarComoMembroToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblPesq;
        private System.Windows.Forms.TextBox txtPesquisa;
        public System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.ToolStripMenuItem imprimirMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}