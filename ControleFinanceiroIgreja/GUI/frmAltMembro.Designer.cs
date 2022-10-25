namespace ControleFinanceiroIgreja.GUI
{
    partial class frmAltMembro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltMembro));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNasc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtCasamento = new System.Windows.Forms.DateTimePicker();
            this.txtTitEleitor = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tabM = new System.Windows.Forms.TabControl();
            this.tabPessoal = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtLocalNascimento = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tabContato = new System.Windows.Forms.TabPage();
            this.tabSecretaria = new System.Windows.Forms.TabPage();
            this.txtProcedencia = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbHistorico = new System.Windows.Forms.GroupBox();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.dtgHistorico = new System.Windows.Forms.DataGridView();
            this.cmsHistorico = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRemover = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddStatus = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddAdmissao = new System.Windows.Forms.Button();
            this.cbAdmissao = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtMembro = new System.Windows.Forms.DateTimePicker();
            this.chkMembro = new System.Windows.Forms.CheckBox();
            this.tabObs = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gbSexo.SuspendLayout();
            this.tabM.SuspendLayout();
            this.tabPessoal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabContato.SuspendLayout();
            this.tabSecretaria.SuspendLayout();
            this.gbHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).BeginInit();
            this.cmsHistorico.SuspendLayout();
            this.tabObs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome completo *";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(6, 39);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(749, 26);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(6, 39);
            this.txtEndereco.MaxLength = 200;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(739, 26);
            this.txtEndereco.TabIndex = 0;
            this.txtEndereco.Enter += new System.EventHandler(this.txtEndereco_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nasc.";
            // 
            // dtNasc
            // 
            this.dtNasc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNasc.CustomFormat = "dd/MM/yyyy";
            this.dtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNasc.Location = new System.Drawing.Point(225, 92);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(125, 26);
            this.dtNasc.TabIndex = 2;
            this.dtNasc.Value = new System.DateTime(2018, 11, 6, 0, 0, 0, 0);
            this.dtNasc.ValueChanged += new System.EventHandler(this.dtNasc_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "RG";
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.White;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.Color.Black;
            this.txtCPF.Location = new System.Drawing.Point(356, 92);
            this.txtCPF.Mask = "000,000,000-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(126, 26);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_MaskInputRejected);
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Enter);
            // 
            // txtRG
            // 
            this.txtRG.BackColor = System.Drawing.Color.White;
            this.txtRG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.ForeColor = System.Drawing.Color.Black;
            this.txtRG.Location = new System.Drawing.Point(486, 92);
            this.txtRG.MaxLength = 15;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(133, 26);
            this.txtRG.TabIndex = 4;
            this.txtRG.Enter += new System.EventHandler(this.txtRG_Enter);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFem);
            this.gbSexo.Controls.Add(this.rbMasc);
            this.gbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.ForeColor = System.Drawing.Color.Black;
            this.gbSexo.Location = new System.Drawing.Point(6, 69);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(213, 49);
            this.gbSexo.TabIndex = 1;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(112, 17);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(100, 24);
            this.rbFem.TabIndex = 1;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            this.rbFem.CheckedChanged += new System.EventHandler(this.rbFem_CheckedChanged);
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Checked = true;
            this.rbMasc.Location = new System.Drawing.Point(6, 17);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(107, 24);
            this.rbMasc.TabIndex = 0;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(6, 93);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(613, 26);
            this.txtBairro.TabIndex = 1;
            this.txtBairro.Enter += new System.EventHandler(this.txtBairro_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(6, 145);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(613, 26);
            this.txtCidade.TabIndex = 3;
            this.txtCidade.Enter += new System.EventHandler(this.txtCidade_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cidade";
            // 
            // txtTel2
            // 
            this.txtTel2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel2.Location = new System.Drawing.Point(244, 198);
            this.txtTel2.MaxLength = 15;
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(232, 26);
            this.txtTel2.TabIndex = 6;
            this.txtTel2.Enter += new System.EventHandler(this.txtTel2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tel2";
            // 
            // txtTel1
            // 
            this.txtTel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel1.Location = new System.Drawing.Point(6, 198);
            this.txtTel1.MaxLength = 15;
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(232, 26);
            this.txtTel1.TabIndex = 5;
            this.txtTel1.Enter += new System.EventHandler(this.txtTel1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tel1";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(6, 250);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(613, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Email";
            // 
            // cbUF
            // 
            this.cbUF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUF.DropDownHeight = 400;
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUF.FormattingEnabled = true;
            this.cbUF.IntegralHeight = false;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(633, 145);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(112, 27);
            this.cbUF.TabIndex = 4;
            this.cbUF.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbUF_DrawItem);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(640, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "UF";
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(633, 93);
            this.txtCEP.Mask = "00,000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(112, 26);
            this.txtCEP.TabIndex = 2;
            this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCEP.Enter += new System.EventHandler(this.txtCEP_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(629, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "CEP";
            // 
            // dtCasamento
            // 
            this.dtCasamento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCasamento.CustomFormat = "dd/MM/yyyy";
            this.dtCasamento.Enabled = false;
            this.dtCasamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCasamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCasamento.Location = new System.Drawing.Point(225, 154);
            this.dtCasamento.Name = "dtCasamento";
            this.dtCasamento.Size = new System.Drawing.Size(125, 26);
            this.dtCasamento.TabIndex = 6;
            this.dtCasamento.Value = new System.DateTime(2018, 11, 6, 0, 0, 0, 0);
            this.dtCasamento.ValueChanged += new System.EventHandler(this.dtCasamento_ValueChanged);
            // 
            // txtTitEleitor
            // 
            this.txtTitEleitor.BackColor = System.Drawing.Color.White;
            this.txtTitEleitor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitEleitor.ForeColor = System.Drawing.Color.Black;
            this.txtTitEleitor.Location = new System.Drawing.Point(356, 154);
            this.txtTitEleitor.MaxLength = 15;
            this.txtTitEleitor.Name = "txtTitEleitor";
            this.txtTitEleitor.Size = new System.Drawing.Size(263, 26);
            this.txtTitEleitor.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(356, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "Título de Eleitor";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(221, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "Desde";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 20);
            this.label17.TabIndex = 18;
            this.label17.Text = "Estado Civil";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstadoCivil.DropDownHeight = 400;
            this.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.IntegralHeight = false;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "SOLTEIRO",
            "CASADO",
            "VIÚVO",
            "DIVORCIADO",
            "OUTRO"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(6, 155);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(213, 22);
            this.cbEstadoCivil.TabIndex = 5;
            this.cbEstadoCivil.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbEstadoCivil_DrawItem);
            this.cbEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.cbEstadoCivil_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 339);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "Nome da mãe";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.BackColor = System.Drawing.Color.White;
            this.txtNomeMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMae.ForeColor = System.Drawing.Color.Black;
            this.txtNomeMae.Location = new System.Drawing.Point(6, 362);
            this.txtNomeMae.MaxLength = 200;
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(749, 26);
            this.txtNomeMae.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Nome do pai";
            // 
            // txtNomePai
            // 
            this.txtNomePai.BackColor = System.Drawing.Color.White;
            this.txtNomePai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomePai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePai.ForeColor = System.Drawing.Color.Black;
            this.txtNomePai.Location = new System.Drawing.Point(6, 311);
            this.txtNomePai.MaxLength = 200;
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(749, 26);
            this.txtNomePai.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(363, 488);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(128, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Membro status";
            this.lblStatus.Visible = false;
            this.lblStatus.Click += new System.EventHandler(this.label21_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(17, 488);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(33, 20);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID:";
            this.lblID.Visible = false;
            // 
            // tabM
            // 
            this.tabM.Controls.Add(this.tabPessoal);
            this.tabM.Controls.Add(this.tabContato);
            this.tabM.Controls.Add(this.tabSecretaria);
            this.tabM.Controls.Add(this.tabObs);
            this.tabM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabM.Location = new System.Drawing.Point(7, 36);
            this.tabM.Name = "tabM";
            this.tabM.SelectedIndex = 0;
            this.tabM.Size = new System.Drawing.Size(769, 438);
            this.tabM.TabIndex = 0;
            // 
            // tabPessoal
            // 
            this.tabPessoal.AutoScroll = true;
            this.tabPessoal.BackColor = System.Drawing.Color.White;
            this.tabPessoal.Controls.Add(this.pictureBox2);
            this.tabPessoal.Controls.Add(this.txtLocalNascimento);
            this.tabPessoal.Controls.Add(this.label22);
            this.tabPessoal.Controls.Add(this.txtProfissao);
            this.tabPessoal.Controls.Add(this.label21);
            this.tabPessoal.Controls.Add(this.label1);
            this.tabPessoal.Controls.Add(this.txtNome);
            this.tabPessoal.Controls.Add(this.txtTitEleitor);
            this.tabPessoal.Controls.Add(this.label3);
            this.tabPessoal.Controls.Add(this.label19);
            this.tabPessoal.Controls.Add(this.dtNasc);
            this.tabPessoal.Controls.Add(this.label18);
            this.tabPessoal.Controls.Add(this.label4);
            this.tabPessoal.Controls.Add(this.label17);
            this.tabPessoal.Controls.Add(this.label5);
            this.tabPessoal.Controls.Add(this.cbEstadoCivil);
            this.tabPessoal.Controls.Add(this.txtCPF);
            this.tabPessoal.Controls.Add(this.label16);
            this.tabPessoal.Controls.Add(this.txtRG);
            this.tabPessoal.Controls.Add(this.txtNomeMae);
            this.tabPessoal.Controls.Add(this.gbSexo);
            this.tabPessoal.Controls.Add(this.label15);
            this.tabPessoal.Controls.Add(this.dtCasamento);
            this.tabPessoal.Controls.Add(this.txtNomePai);
            this.tabPessoal.Location = new System.Drawing.Point(4, 29);
            this.tabPessoal.Name = "tabPessoal";
            this.tabPessoal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPessoal.Size = new System.Drawing.Size(761, 405);
            this.tabPessoal.TabIndex = 0;
            this.tabPessoal.Text = "Dados pessoais";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(633, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 111);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // txtLocalNascimento
            // 
            this.txtLocalNascimento.BackColor = System.Drawing.Color.White;
            this.txtLocalNascimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocalNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalNascimento.ForeColor = System.Drawing.Color.Black;
            this.txtLocalNascimento.Location = new System.Drawing.Point(6, 204);
            this.txtLocalNascimento.MaxLength = 350;
            this.txtLocalNascimento.Name = "txtLocalNascimento";
            this.txtLocalNascimento.Size = new System.Drawing.Size(749, 26);
            this.txtLocalNascimento.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 181);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(176, 20);
            this.label22.TabIndex = 25;
            this.label22.Text = "Local de Nascimento";
            // 
            // txtProfissao
            // 
            this.txtProfissao.BackColor = System.Drawing.Color.White;
            this.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfissao.ForeColor = System.Drawing.Color.Black;
            this.txtProfissao.Location = new System.Drawing.Point(6, 259);
            this.txtProfissao.MaxLength = 200;
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(749, 26);
            this.txtProfissao.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 236);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 20);
            this.label21.TabIndex = 23;
            this.label21.Text = "Profissão";
            // 
            // tabContato
            // 
            this.tabContato.BackColor = System.Drawing.Color.White;
            this.tabContato.Controls.Add(this.txtCEP);
            this.tabContato.Controls.Add(this.label2);
            this.tabContato.Controls.Add(this.label12);
            this.tabContato.Controls.Add(this.txtCidade);
            this.tabContato.Controls.Add(this.label11);
            this.tabContato.Controls.Add(this.label7);
            this.tabContato.Controls.Add(this.cbUF);
            this.tabContato.Controls.Add(this.label9);
            this.tabContato.Controls.Add(this.txtTel2);
            this.tabContato.Controls.Add(this.txtBairro);
            this.tabContato.Controls.Add(this.label8);
            this.tabContato.Controls.Add(this.txtTel1);
            this.tabContato.Controls.Add(this.txtEndereco);
            this.tabContato.Controls.Add(this.label6);
            this.tabContato.Controls.Add(this.txtEmail);
            this.tabContato.Controls.Add(this.label10);
            this.tabContato.ForeColor = System.Drawing.Color.Black;
            this.tabContato.Location = new System.Drawing.Point(4, 29);
            this.tabContato.Name = "tabContato";
            this.tabContato.Padding = new System.Windows.Forms.Padding(3);
            this.tabContato.Size = new System.Drawing.Size(761, 405);
            this.tabContato.TabIndex = 1;
            this.tabContato.Text = "Contato";
            // 
            // tabSecretaria
            // 
            this.tabSecretaria.BackColor = System.Drawing.Color.White;
            this.tabSecretaria.Controls.Add(this.txtProcedencia);
            this.tabSecretaria.Controls.Add(this.label23);
            this.tabSecretaria.Controls.Add(this.label13);
            this.tabSecretaria.Controls.Add(this.gbHistorico);
            this.tabSecretaria.Controls.Add(this.btnAddStatus);
            this.tabSecretaria.Controls.Add(this.cbStatus);
            this.tabSecretaria.Controls.Add(this.btnAddAdmissao);
            this.tabSecretaria.Controls.Add(this.cbAdmissao);
            this.tabSecretaria.Controls.Add(this.label14);
            this.tabSecretaria.Controls.Add(this.dtMembro);
            this.tabSecretaria.Controls.Add(this.chkMembro);
            this.tabSecretaria.Location = new System.Drawing.Point(4, 29);
            this.tabSecretaria.Name = "tabSecretaria";
            this.tabSecretaria.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecretaria.Size = new System.Drawing.Size(761, 405);
            this.tabSecretaria.TabIndex = 2;
            this.tabSecretaria.Text = "Secretaria";
            // 
            // txtProcedencia
            // 
            this.txtProcedencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProcedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedencia.Location = new System.Drawing.Point(6, 31);
            this.txtProcedencia.MaxLength = 200;
            this.txtProcedencia.Name = "txtProcedencia";
            this.txtProcedencia.Size = new System.Drawing.Size(589, 26);
            this.txtProcedencia.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 20);
            this.label23.TabIndex = 42;
            this.label23.Text = "Procedência";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "Situação atual do membro";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // gbHistorico
            // 
            this.gbHistorico.Controls.Add(this.lblHistorico);
            this.gbHistorico.Controls.Add(this.dtgHistorico);
            this.gbHistorico.Enabled = false;
            this.gbHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHistorico.ForeColor = System.Drawing.Color.Black;
            this.gbHistorico.Location = new System.Drawing.Point(9, 182);
            this.gbHistorico.Name = "gbHistorico";
            this.gbHistorico.Size = new System.Drawing.Size(746, 216);
            this.gbHistorico.TabIndex = 7;
            this.gbHistorico.TabStop = false;
            this.gbHistorico.Text = "Histórico do Membro";
            this.gbHistorico.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.Location = new System.Drawing.Point(152, 96);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(490, 20);
            this.lblHistorico.TabIndex = 11;
            this.lblHistorico.Text = "Cadastre e salve o membro para ativar a função de histórico";
            // 
            // dtgHistorico
            // 
            this.dtgHistorico.AllowUserToAddRows = false;
            this.dtgHistorico.AllowUserToDeleteRows = false;
            this.dtgHistorico.AllowUserToOrderColumns = true;
            this.dtgHistorico.AllowUserToResizeColumns = false;
            this.dtgHistorico.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgHistorico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgHistorico.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgHistorico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorico.ContextMenuStrip = this.cmsHistorico;
            this.dtgHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgHistorico.Location = new System.Drawing.Point(3, 18);
            this.dtgHistorico.MultiSelect = false;
            this.dtgHistorico.Name = "dtgHistorico";
            this.dtgHistorico.ReadOnly = true;
            this.dtgHistorico.RowHeadersVisible = false;
            this.dtgHistorico.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHistorico.Size = new System.Drawing.Size(740, 195);
            this.dtgHistorico.StandardTab = true;
            this.dtgHistorico.TabIndex = 0;
            this.dtgHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHistorico_CellContentClick);
            this.dtgHistorico.DoubleClick += new System.EventHandler(this.tsEditar_Click);
            this.dtgHistorico.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgHistorico_MouseDown);
            // 
            // cmsHistorico
            // 
            this.cmsHistorico.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsHistorico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEditar,
            this.toolStripSeparator3,
            this.tsCadastrar,
            this.toolStripSeparator4,
            this.tsRemover});
            this.cmsHistorico.Name = "cmsMembros";
            this.cmsHistorico.Size = new System.Drawing.Size(141, 130);
            // 
            // tsEditar
            // 
            this.tsEditar.Image = global::ControleFinanceiroIgreja.Properties.Resources.pencil_24;
            this.tsEditar.Name = "tsEditar";
            this.tsEditar.Size = new System.Drawing.Size(140, 38);
            this.tsEditar.Text = "Editar";
            this.tsEditar.Click += new System.EventHandler(this.tsEditar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
            // 
            // tsCadastrar
            // 
            this.tsCadastrar.Image = global::ControleFinanceiroIgreja.Properties.Resources.compose_24;
            this.tsCadastrar.Name = "tsCadastrar";
            this.tsCadastrar.Size = new System.Drawing.Size(140, 38);
            this.tsCadastrar.Text = "Cadastrar";
            this.tsCadastrar.Click += new System.EventHandler(this.tsCadastrar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(137, 6);
            // 
            // tsRemover
            // 
            this.tsRemover.Image = global::ControleFinanceiroIgreja.Properties.Resources.stop_24;
            this.tsRemover.Name = "tsRemover";
            this.tsRemover.Size = new System.Drawing.Size(140, 38);
            this.tsRemover.Text = "Remover";
            this.tsRemover.Click += new System.EventHandler(this.tsRemover_Click);
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.AutoSize = true;
            this.btnAddStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStatus.Image = global::ControleFinanceiroIgreja.Properties.Resources.stack_32;
            this.btnAddStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStatus.Location = new System.Drawing.Point(601, 143);
            this.btnAddStatus.Name = "btnAddStatus";
            this.btnAddStatus.Size = new System.Drawing.Size(147, 37);
            this.btnAddStatus.TabIndex = 6;
            this.btnAddStatus.Text = "Situações";
            this.btnAddStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStatus.UseCompatibleTextRendering = true;
            this.btnAddStatus.UseVisualStyleBackColor = true;
            this.btnAddStatus.Click += new System.EventHandler(this.btnAddStatus_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownHeight = 400;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Location = new System.Drawing.Point(6, 148);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(589, 27);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbStatus_DrawItem);
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged_1);
            // 
            // btnAddAdmissao
            // 
            this.btnAddAdmissao.AutoSize = true;
            this.btnAddAdmissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdmissao.Image = global::ControleFinanceiroIgreja.Properties.Resources.stack_32;
            this.btnAddAdmissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdmissao.Location = new System.Drawing.Point(605, 78);
            this.btnAddAdmissao.Name = "btnAddAdmissao";
            this.btnAddAdmissao.Size = new System.Drawing.Size(147, 37);
            this.btnAddAdmissao.TabIndex = 4;
            this.btnAddAdmissao.Text = "Admissões";
            this.btnAddAdmissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAdmissao.UseCompatibleTextRendering = true;
            this.btnAddAdmissao.UseVisualStyleBackColor = true;
            this.btnAddAdmissao.Click += new System.EventHandler(this.btnAddAdmissao_Click);
            // 
            // cbAdmissao
            // 
            this.cbAdmissao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAdmissao.DropDownHeight = 400;
            this.cbAdmissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdmissao.Enabled = false;
            this.cbAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdmissao.FormattingEnabled = true;
            this.cbAdmissao.IntegralHeight = false;
            this.cbAdmissao.Location = new System.Drawing.Point(6, 83);
            this.cbAdmissao.Name = "cbAdmissao";
            this.cbAdmissao.Size = new System.Drawing.Size(589, 27);
            this.cbAdmissao.TabIndex = 3;
            this.cbAdmissao.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbAdmissao_DrawItem);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = "Admissão";
            // 
            // dtMembro
            // 
            this.dtMembro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMembro.CustomFormat = "dd/MM/yyyy";
            this.dtMembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMembro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMembro.Location = new System.Drawing.Point(608, 31);
            this.dtMembro.Name = "dtMembro";
            this.dtMembro.Size = new System.Drawing.Size(144, 26);
            this.dtMembro.TabIndex = 2;
            this.dtMembro.Value = new System.DateTime(2018, 11, 5, 0, 0, 0, 0);
            this.dtMembro.Visible = false;
            // 
            // chkMembro
            // 
            this.chkMembro.AutoSize = true;
            this.chkMembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMembro.Location = new System.Drawing.Point(608, 8);
            this.chkMembro.Name = "chkMembro";
            this.chkMembro.Size = new System.Drawing.Size(89, 22);
            this.chkMembro.TabIndex = 1;
            this.chkMembro.Text = "Membro";
            this.chkMembro.UseVisualStyleBackColor = true;
            this.chkMembro.CheckedChanged += new System.EventHandler(this.chkMembro_CheckedChanged);
            // 
            // tabObs
            // 
            this.tabObs.BackColor = System.Drawing.Color.White;
            this.tabObs.Controls.Add(this.label20);
            this.tabObs.Controls.Add(this.txtObs);
            this.tabObs.Location = new System.Drawing.Point(4, 29);
            this.tabObs.Name = "tabObs";
            this.tabObs.Padding = new System.Windows.Forms.Padding(3);
            this.tabObs.Size = new System.Drawing.Size(761, 405);
            this.tabObs.TabIndex = 3;
            this.tabObs.Text = "Observações";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 20);
            this.label20.TabIndex = 25;
            this.label20.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(10, 41);
            this.txtObs.MaxLength = 500;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(741, 358);
            this.txtObs.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(701, 476);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(71, 32);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.tabM);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 528);
            this.panel1.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(2, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(240, 24);
            this.label24.TabIndex = 14;
            this.label24.Text = "Editar dados do membro";
            this.label24.Visible = false;
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
            this.btnFechar.Location = new System.Drawing.Point(752, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 38);
            this.btnFechar.TabIndex = 22;
            this.btnFechar.TabStop = false;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmAltMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(796, 532);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltMembro";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dados do membro";
            this.Load += new System.EventHandler(this.frmAltMembro_Load);
            this.Shown += new System.EventHandler(this.frmAltMembro_Shown);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.tabM.ResumeLayout(false);
            this.tabPessoal.ResumeLayout(false);
            this.tabPessoal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabContato.ResumeLayout(false);
            this.tabContato.PerformLayout();
            this.tabSecretaria.ResumeLayout(false);
            this.tabSecretaria.PerformLayout();
            this.gbHistorico.ResumeLayout(false);
            this.gbHistorico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).EndInit();
            this.cmsHistorico.ResumeLayout(false);
            this.tabObs.ResumeLayout(false);
            this.tabObs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtCasamento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTitEleitor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TabControl tabM;
        private System.Windows.Forms.TabPage tabPessoal;
        private System.Windows.Forms.TabPage tabContato;
        private System.Windows.Forms.TabPage tabSecretaria;
        private System.Windows.Forms.TabPage tabObs;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnAddAdmissao;
        private System.Windows.Forms.ComboBox cbAdmissao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtMembro;
        private System.Windows.Forms.CheckBox chkMembro;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtLocalNascimento;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox gbHistorico;
        private System.Windows.Forms.DataGridView dtgHistorico;
        private System.Windows.Forms.TextBox txtProcedencia;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ContextMenuStrip cmsHistorico;
        private System.Windows.Forms.ToolStripMenuItem tsEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsCadastrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsRemover;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblHistorico;
    }
}