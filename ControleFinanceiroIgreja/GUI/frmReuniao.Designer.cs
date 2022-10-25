namespace ControleFinanceiroIgreja.GUI
{
    partial class frmReuniao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReuniao));
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOferta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numBiblias = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numRevistas = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numVisitantes = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.gbClasseAlunos = new System.Windows.Forms.GroupBox();
            this.dtgAlunos = new System.Windows.Forms.DataGridView();
            this.cmsAlunos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.marcarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desmarcarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mostrarAlunosInativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnFinal = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBiblias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRevistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisitantes)).BeginInit();
            this.gbClasseAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).BeginInit();
            this.cmsAlunos.SuspendLayout();
            this.pnFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbClasses
            // 
            this.cbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasses.Enabled = false;
            this.cbClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasses.Location = new System.Drawing.Point(93, 9);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(476, 28);
            this.cbClasses.TabIndex = 0;
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(93, 88);
            this.txtObs.MaxLength = 500;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObs.Size = new System.Drawing.Size(701, 45);
            this.txtObs.TabIndex = 6;
            // 
            // dtData
            // 
            this.dtData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(650, 12);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(144, 26);
            this.dtData.TabIndex = 1;
            this.dtData.ValueChanged += new System.EventHandler(this.dtData_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Data *";
            // 
            // txtOferta
            // 
            this.txtOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOferta.Location = new System.Drawing.Point(650, 48);
            this.txtOferta.MaxLength = 15;
            this.txtOferta.Name = "txtOferta";
            this.txtOferta.Size = new System.Drawing.Size(144, 26);
            this.txtOferta.TabIndex = 5;
            this.txtOferta.Text = "0,00";
            this.txtOferta.Enter += new System.EventHandler(this.txtOferta_Enter);
            this.txtOferta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOferta_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ofertas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Classe *";
            // 
            // numBiblias
            // 
            this.numBiblias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBiblias.Location = new System.Drawing.Point(93, 49);
            this.numBiblias.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numBiblias.Name = "numBiblias";
            this.numBiblias.Size = new System.Drawing.Size(95, 26);
            this.numBiblias.TabIndex = 2;
            this.numBiblias.ValueChanged += new System.EventHandler(this.numBiblias_ValueChanged);
            this.numBiblias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numBiblias_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bíblias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Revistas";
            // 
            // numRevistas
            // 
            this.numRevistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRevistas.Location = new System.Drawing.Point(278, 49);
            this.numRevistas.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numRevistas.Name = "numRevistas";
            this.numRevistas.Size = new System.Drawing.Size(95, 26);
            this.numRevistas.TabIndex = 3;
            this.numRevistas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numBiblias_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Visitantes";
            // 
            // numVisitantes
            // 
            this.numVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVisitantes.Location = new System.Drawing.Point(474, 51);
            this.numVisitantes.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numVisitantes.Name = "numVisitantes";
            this.numVisitantes.Size = new System.Drawing.Size(95, 26);
            this.numVisitantes.TabIndex = 4;
            this.numVisitantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numBiblias_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Obs.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // gbClasseAlunos
            // 
            this.gbClasseAlunos.Controls.Add(this.dtgAlunos);
            this.gbClasseAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClasseAlunos.Location = new System.Drawing.Point(12, 139);
            this.gbClasseAlunos.Name = "gbClasseAlunos";
            this.gbClasseAlunos.Size = new System.Drawing.Size(782, 311);
            this.gbClasseAlunos.TabIndex = 7;
            this.gbClasseAlunos.TabStop = false;
            this.gbClasseAlunos.Text = "Alunos";
            this.gbClasseAlunos.Enter += new System.EventHandler(this.gbClasseAlunos_Enter);
            // 
            // dtgAlunos
            // 
            this.dtgAlunos.AllowUserToAddRows = false;
            this.dtgAlunos.AllowUserToDeleteRows = false;
            this.dtgAlunos.AllowUserToOrderColumns = true;
            this.dtgAlunos.AllowUserToResizeColumns = false;
            this.dtgAlunos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgAlunos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgAlunos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlunos.ContextMenuStrip = this.cmsAlunos;
            this.dtgAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgAlunos.Location = new System.Drawing.Point(3, 22);
            this.dtgAlunos.MultiSelect = false;
            this.dtgAlunos.Name = "dtgAlunos";
            this.dtgAlunos.ReadOnly = true;
            this.dtgAlunos.RowHeadersVisible = false;
            this.dtgAlunos.RowTemplate.Height = 33;
            this.dtgAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlunos.Size = new System.Drawing.Size(776, 286);
            this.dtgAlunos.TabIndex = 0;
            this.dtgAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlunos_CellClick);
            this.dtgAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlunos_CellContentClick);
            this.dtgAlunos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgAlunos_CellFormatting);
            // 
            // cmsAlunos
            // 
            this.cmsAlunos.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsAlunos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcarTudoToolStripMenuItem,
            this.desmarcarTudoToolStripMenuItem,
            this.toolStripSeparator1,
            this.mostrarAlunosInativosToolStripMenuItem});
            this.cmsAlunos.Name = "cmsAlunos";
            this.cmsAlunos.Size = new System.Drawing.Size(258, 124);
            // 
            // marcarTudoToolStripMenuItem
            // 
            this.marcarTudoToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.check_24;
            this.marcarTudoToolStripMenuItem.Name = "marcarTudoToolStripMenuItem";
            this.marcarTudoToolStripMenuItem.Size = new System.Drawing.Size(257, 38);
            this.marcarTudoToolStripMenuItem.Text = "Marcar tudo";
            this.marcarTudoToolStripMenuItem.Click += new System.EventHandler(this.marcarTudoToolStripMenuItem_Click);
            // 
            // desmarcarTudoToolStripMenuItem
            // 
            this.desmarcarTudoToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.uncheck_24;
            this.desmarcarTudoToolStripMenuItem.Name = "desmarcarTudoToolStripMenuItem";
            this.desmarcarTudoToolStripMenuItem.Size = new System.Drawing.Size(257, 38);
            this.desmarcarTudoToolStripMenuItem.Text = "Desmarcar tudo";
            this.desmarcarTudoToolStripMenuItem.Click += new System.EventHandler(this.desmarcarTudoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // mostrarAlunosInativosToolStripMenuItem
            // 
            this.mostrarAlunosInativosToolStripMenuItem.Image = global::ControleFinanceiroIgreja.Properties.Resources.eye_24;
            this.mostrarAlunosInativosToolStripMenuItem.Name = "mostrarAlunosInativosToolStripMenuItem";
            this.mostrarAlunosInativosToolStripMenuItem.Size = new System.Drawing.Size(257, 38);
            this.mostrarAlunosInativosToolStripMenuItem.Text = "Mostrar/Ocultar alunos inativos";
            this.mostrarAlunosInativosToolStripMenuItem.Click += new System.EventHandler(this.mostrarAlunosInativosToolStripMenuItem_Click);
            // 
            // pnFinal
            // 
            this.pnFinal.Controls.Add(this.label7);
            this.pnFinal.Controls.Add(this.btnSalvar);
            this.pnFinal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFinal.Location = new System.Drawing.Point(0, 452);
            this.pnFinal.Name = "pnFinal";
            this.pnFinal.Size = new System.Drawing.Size(822, 60);
            this.pnFinal.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Campos obrigatórios *";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::ControleFinanceiroIgreja.Properties.Resources.save_48;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(663, 1);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(131, 57);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmReuniao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(822, 512);
            this.Controls.Add(this.pnFinal);
            this.Controls.Add(this.gbClasseAlunos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numVisitantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numRevistas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBiblias);
            this.Controls.Add(this.cbClasses);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOferta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReuniao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alterar dados da reunião";
            this.Load += new System.EventHandler(this.frmReuniao_Load);
            this.Shown += new System.EventHandler(this.frmReuniao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numBiblias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRevistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisitantes)).EndInit();
            this.gbClasseAlunos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).EndInit();
            this.cmsAlunos.ResumeLayout(false);
            this.pnFinal.ResumeLayout(false);
            this.pnFinal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOferta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numBiblias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRevistas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numVisitantes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbClasseAlunos;
        private System.Windows.Forms.DataGridView dtgAlunos;
        private System.Windows.Forms.Panel pnFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ContextMenuStrip cmsAlunos;
        private System.Windows.Forms.ToolStripMenuItem marcarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desmarcarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mostrarAlunosInativosToolStripMenuItem;
    }
}