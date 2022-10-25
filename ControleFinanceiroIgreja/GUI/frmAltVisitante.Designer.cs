namespace ControleFinanceiroIgreja.GUI
{
    partial class frmAltVisitante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltVisitante));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabObs = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.tabContato = new System.Windows.Forms.TabPage();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPessoal = new System.Windows.Forms.TabPage();
            this.txtLocalNascimento = new System.Windows.Forms.TextBox();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNasc = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.dtCasamento = new System.Windows.Forms.DateTimePicker();
            this.tabM = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabObs.SuspendLayout();
            this.tabContato.SuspendLayout();
            this.tabPessoal.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.tabM.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(540, 401);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 40);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabObs
            // 
            this.tabObs.Controls.Add(this.label20);
            this.tabObs.Controls.Add(this.txtObs);
            this.tabObs.Location = new System.Drawing.Point(4, 29);
            this.tabObs.Name = "tabObs";
            this.tabObs.Padding = new System.Windows.Forms.Padding(3);
            this.tabObs.Size = new System.Drawing.Size(634, 343);
            this.tabObs.TabIndex = 3;
            this.tabObs.Text = "Observações";
            this.tabObs.UseVisualStyleBackColor = true;
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
            this.txtObs.Size = new System.Drawing.Size(609, 269);
            this.txtObs.TabIndex = 0;
            // 
            // tabContato
            // 
            this.tabContato.Controls.Add(this.txtCEP);
            this.tabContato.Controls.Add(this.label2);
            this.tabContato.Controls.Add(this.label12);
            this.tabContato.Controls.Add(this.txtCidade);
            this.tabContato.Controls.Add(this.txtTel2);
            this.tabContato.Controls.Add(this.txtBairro);
            this.tabContato.Controls.Add(this.txtTel1);
            this.tabContato.Controls.Add(this.txtEndereco);
            this.tabContato.Controls.Add(this.txtEmail);
            this.tabContato.Controls.Add(this.label11);
            this.tabContato.Controls.Add(this.label7);
            this.tabContato.Controls.Add(this.cbUF);
            this.tabContato.Controls.Add(this.label9);
            this.tabContato.Controls.Add(this.label8);
            this.tabContato.Controls.Add(this.label6);
            this.tabContato.Controls.Add(this.label10);
            this.tabContato.Location = new System.Drawing.Point(4, 29);
            this.tabContato.Name = "tabContato";
            this.tabContato.Padding = new System.Windows.Forms.Padding(3);
            this.tabContato.Size = new System.Drawing.Size(634, 343);
            this.tabContato.TabIndex = 1;
            this.tabContato.Text = "Contato";
            this.tabContato.UseVisualStyleBackColor = true;
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(507, 93);
            this.txtCEP.Mask = "00,000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(112, 26);
            this.txtCEP.TabIndex = 2;
            this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(503, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "CEP";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(6, 145);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(495, 26);
            this.txtCidade.TabIndex = 3;
            // 
            // txtTel2
            // 
            this.txtTel2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel2.Location = new System.Drawing.Point(260, 197);
            this.txtTel2.MaxLength = 15;
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(241, 26);
            this.txtTel2.TabIndex = 6;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(6, 93);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(495, 26);
            this.txtBairro.TabIndex = 1;
            // 
            // txtTel1
            // 
            this.txtTel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel1.Location = new System.Drawing.Point(6, 198);
            this.txtTel1.MaxLength = 15;
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(241, 26);
            this.txtTel1.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(6, 39);
            this.txtEndereco.MaxLength = 200;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(613, 26);
            this.txtEndereco.TabIndex = 0;
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
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(514, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "UF";
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
            // cbUF
            // 
            this.cbUF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUF.DropDownHeight = 400;
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUF.ForeColor = System.Drawing.Color.Black;
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
            this.cbUF.Location = new System.Drawing.Point(507, 145);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(112, 27);
            this.cbUF.TabIndex = 4;
            this.cbUF.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbUF_DrawItem);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tel2";
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
            // tabPessoal
            // 
            this.tabPessoal.AutoScroll = true;
            this.tabPessoal.Controls.Add(this.txtLocalNascimento);
            this.tabPessoal.Controls.Add(this.txtProfissao);
            this.tabPessoal.Controls.Add(this.txtNome);
            this.tabPessoal.Controls.Add(this.label22);
            this.tabPessoal.Controls.Add(this.label21);
            this.tabPessoal.Controls.Add(this.label1);
            this.tabPessoal.Controls.Add(this.label3);
            this.tabPessoal.Controls.Add(this.dtNasc);
            this.tabPessoal.Controls.Add(this.label18);
            this.tabPessoal.Controls.Add(this.label17);
            this.tabPessoal.Controls.Add(this.cbEstadoCivil);
            this.tabPessoal.Controls.Add(this.gbSexo);
            this.tabPessoal.Controls.Add(this.dtCasamento);
            this.tabPessoal.Location = new System.Drawing.Point(4, 29);
            this.tabPessoal.Name = "tabPessoal";
            this.tabPessoal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPessoal.Size = new System.Drawing.Size(634, 343);
            this.tabPessoal.TabIndex = 0;
            this.tabPessoal.Text = "Dados pessoais";
            this.tabPessoal.UseVisualStyleBackColor = true;
            // 
            // txtLocalNascimento
            // 
            this.txtLocalNascimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocalNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalNascimento.Location = new System.Drawing.Point(6, 204);
            this.txtLocalNascimento.MaxLength = 350;
            this.txtLocalNascimento.Name = "txtLocalNascimento";
            this.txtLocalNascimento.Size = new System.Drawing.Size(613, 26);
            this.txtLocalNascimento.TabIndex = 8;
            // 
            // txtProfissao
            // 
            this.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfissao.Location = new System.Drawing.Point(6, 259);
            this.txtProfissao.MaxLength = 200;
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(613, 26);
            this.txtProfissao.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(6, 39);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(613, 26);
            this.txtNome.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome completo *";
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
            this.dtNasc.Value = new System.DateTime(2018, 11, 2, 0, 0, 0, 0);
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
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFem);
            this.gbSexo.Controls.Add(this.rbMasc);
            this.gbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dtCasamento.Value = new System.DateTime(2018, 11, 2, 0, 0, 0, 0);
            // 
            // tabM
            // 
            this.tabM.Controls.Add(this.tabPessoal);
            this.tabM.Controls.Add(this.tabContato);
            this.tabM.Controls.Add(this.tabObs);
            this.tabM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabM.Location = new System.Drawing.Point(3, 19);
            this.tabM.Name = "tabM";
            this.tabM.SelectedIndex = 0;
            this.tabM.Size = new System.Drawing.Size(642, 376);
            this.tabM.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.tabM);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 457);
            this.panel1.TabIndex = 4;
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
            this.btnFechar.Location = new System.Drawing.Point(626, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 38);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.TabStop = false;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmAltVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(670, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltVisitante";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Altera dados do visitante";
            this.Load += new System.EventHandler(this.frmAltVisitante_Load);
            this.tabObs.ResumeLayout(false);
            this.tabObs.PerformLayout();
            this.tabContato.ResumeLayout(false);
            this.tabContato.PerformLayout();
            this.tabPessoal.ResumeLayout(false);
            this.tabPessoal.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.tabM.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabPage tabObs;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TabPage tabContato;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPessoal;
        private System.Windows.Forms.TextBox txtLocalNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNasc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.DateTimePicker dtCasamento;
        private System.Windows.Forms.TabControl tabM;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
    }
}