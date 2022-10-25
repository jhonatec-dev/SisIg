namespace ControleFinanceiroIgreja.GUI
{
    partial class frmNiver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNiver));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgVisitantes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgMembros = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAno = new System.Windows.Forms.Button();
            this.menuImp = new System.Windows.Forms.MenuStrip();
            this.tsImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnSemana = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitantes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMembros)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuImp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(903, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgVisitantes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(454, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 384);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitantes";
            // 
            // dtgVisitantes
            // 
            this.dtgVisitantes.AllowUserToAddRows = false;
            this.dtgVisitantes.AllowUserToDeleteRows = false;
            this.dtgVisitantes.AllowUserToOrderColumns = true;
            this.dtgVisitantes.AllowUserToResizeColumns = false;
            this.dtgVisitantes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgVisitantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVisitantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgVisitantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgVisitantes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgVisitantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisitantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgVisitantes.Location = new System.Drawing.Point(3, 20);
            this.dtgVisitantes.MultiSelect = false;
            this.dtgVisitantes.Name = "dtgVisitantes";
            this.dtgVisitantes.ReadOnly = true;
            this.dtgVisitantes.RowHeadersVisible = false;
            this.dtgVisitantes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVisitantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVisitantes.Size = new System.Drawing.Size(440, 361);
            this.dtgVisitantes.TabIndex = 9;
            this.dtgVisitantes.DoubleClick += new System.EventHandler(this.dtgVisitantes_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgMembros);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membros";
            // 
            // dtgMembros
            // 
            this.dtgMembros.AllowUserToAddRows = false;
            this.dtgMembros.AllowUserToDeleteRows = false;
            this.dtgMembros.AllowUserToOrderColumns = true;
            this.dtgMembros.AllowUserToResizeColumns = false;
            this.dtgMembros.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgMembros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMembros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgMembros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgMembros.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgMembros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgMembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMembros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMembros.Location = new System.Drawing.Point(3, 20);
            this.dtgMembros.MultiSelect = false;
            this.dtgMembros.Name = "dtgMembros";
            this.dtgMembros.ReadOnly = true;
            this.dtgMembros.RowHeadersVisible = false;
            this.dtgMembros.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMembros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMembros.Size = new System.Drawing.Size(439, 361);
            this.dtgMembros.TabIndex = 9;
            this.dtgMembros.DoubleClick += new System.EventHandler(this.dtgMembros_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAno);
            this.panel1.Controls.Add(this.menuImp);
            this.panel1.Controls.Add(this.btnMes);
            this.panel1.Controls.Add(this.btnSemana);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 54);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 95;
            this.label1.Text = "Filtrar por:";
            // 
            // btnAno
            // 
            this.btnAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAno.Image = ((System.Drawing.Image)(resources.GetObject("btnAno.Image")));
            this.btnAno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAno.Location = new System.Drawing.Point(488, 7);
            this.btnAno.Name = "btnAno";
            this.btnAno.Size = new System.Drawing.Size(138, 40);
            this.btnAno.TabIndex = 94;
            this.btnAno.Text = "Ano";
            this.btnAno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAno.UseVisualStyleBackColor = true;
            this.btnAno.Click += new System.EventHandler(this.ano);
            // 
            // menuImp
            // 
            this.menuImp.AutoSize = false;
            this.menuImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuImp.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuImp.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuImp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsImprimir});
            this.menuImp.Location = new System.Drawing.Point(853, 0);
            this.menuImp.Name = "menuImp";
            this.menuImp.Size = new System.Drawing.Size(50, 54);
            this.menuImp.Stretch = false;
            this.menuImp.TabIndex = 93;
            this.menuImp.Text = "menuStrip1";
            this.menuImp.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuImp_ItemClicked);
            // 
            // tsImprimir
            // 
            this.tsImprimir.AutoSize = false;
            this.tsImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tsImprimir.Image = global::ControleFinanceiroIgreja.Properties.Resources.printer_48;
            this.tsImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsImprimir.Name = "tsImprimir";
            this.tsImprimir.Size = new System.Drawing.Size(48, 48);
            this.tsImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsImprimir.Click += new System.EventHandler(this.imprimir);
            // 
            // btnMes
            // 
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.Image = ((System.Drawing.Image)(resources.GetObject("btnMes.Image")));
            this.btnMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMes.Location = new System.Drawing.Point(306, 7);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(138, 40);
            this.btnMes.TabIndex = 92;
            this.btnMes.Text = "Mês";
            this.btnMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.mes);
            // 
            // btnSemana
            // 
            this.btnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemana.Image = ((System.Drawing.Image)(resources.GetObject("btnSemana.Image")));
            this.btnSemana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSemana.Location = new System.Drawing.Point(124, 7);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(138, 40);
            this.btnSemana.TabIndex = 91;
            this.btnSemana.Text = "Semana";
            this.btnSemana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSemana.UseVisualStyleBackColor = true;
            this.btnSemana.Click += new System.EventHandler(this.semana);
            // 
            // frmNiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 444);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNiver";
            this.Text = "Aniversariantes";
            this.Activated += new System.EventHandler(this.frmNiver_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNiver_FormClosed);
            this.Load += new System.EventHandler(this.frmNiver_Load);
            this.Shown += new System.EventHandler(this.frmNiver_Shown);
            this.Enter += new System.EventHandler(this.frmNiver_Enter);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitantes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMembros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuImp.ResumeLayout(false);
            this.menuImp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgMembros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgVisitantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.MenuStrip menuImp;
        private System.Windows.Forms.ToolStripMenuItem tsImprimir;
        private System.Windows.Forms.Button btnAno;
        private System.Windows.Forms.Label label1;
    }
}