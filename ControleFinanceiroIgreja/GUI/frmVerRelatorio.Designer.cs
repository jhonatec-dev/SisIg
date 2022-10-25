namespace ControleFinanceiroIgreja.GUI
{
    partial class frmVerRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerRelatorio));
            this.rvRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsPrim = new System.Windows.Forms.ToolStripButton();
            this.tsAnt = new System.Windows.Forms.ToolStripButton();
            this.tsTxtPag = new System.Windows.Forms.ToolStripTextBox();
            this.tsPag = new System.Windows.Forms.ToolStripLabel();
            this.tsProx = new System.Windows.Forms.ToolStripButton();
            this.tsUlt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsImp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsImpView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsZoom = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsConfig = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rvRelatorio
            // 
            this.rvRelatorio.AutoScroll = true;
            this.rvRelatorio.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.rvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvRelatorio.IsDocumentMapWidthFixed = true;
            this.rvRelatorio.LocalReport.ReportEmbeddedResource = "";
            this.rvRelatorio.Location = new System.Drawing.Point(0, 86);
            this.rvRelatorio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.rvRelatorio.Name = "rvRelatorio";
            this.rvRelatorio.ServerReport.BearerToken = null;
            this.rvRelatorio.ShowToolBar = false;
            this.rvRelatorio.Size = new System.Drawing.Size(854, 407);
            this.rvRelatorio.TabIndex = 9;
            this.rvRelatorio.WaitControlDisplayAfter = 0;
            this.rvRelatorio.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rvRelatorio.ZoomChange += new Microsoft.Reporting.WinForms.ZoomChangedEventHandler(this.rvRelatorio_ZoomChange);
            this.rvRelatorio.PageNavigation += new Microsoft.Reporting.WinForms.PageNavigationEventHandler(this.rvRelatorio_PageNavigation);
            this.rvRelatorio.DocumentMapNavigation += new Microsoft.Reporting.WinForms.DocumentMapNavigationEventHandler(this.rvRelatorio_DocumentMapNavigation);
            this.rvRelatorio.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.rvRelatorio_RenderingComplete);
            this.rvRelatorio.StatusChanged += new System.EventHandler<System.EventArgs>(this.rvRelatorio_StatusChanged);
            this.rvRelatorio.Load += new System.EventHandler(this.rvRelatorio_Load);
            this.rvRelatorio.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rvRelatorio_Scroll);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPrim,
            this.tsAnt,
            this.tsTxtPag,
            this.tsPag,
            this.tsProx,
            this.tsUlt,
            this.toolStripSeparator1,
            this.tsImp,
            this.toolStripSeparator2,
            this.tsImprimir,
            this.tsImpView,
            this.toolStripSeparator3,
            this.tsZoom,
            this.toolStripSeparator4,
            this.tsConfig});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 43);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(854, 43);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsPrim
            // 
            this.tsPrim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPrim.Enabled = false;
            this.tsPrim.Image = global::ControleFinanceiroIgreja.Properties.Resources.rpt__5_;
            this.tsPrim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrim.Name = "tsPrim";
            this.tsPrim.Size = new System.Drawing.Size(36, 36);
            this.tsPrim.Text = "Primeira Página";
            this.tsPrim.ToolTipText = "Primeira Página";
            this.tsPrim.Click += new System.EventHandler(this.tsPrim_Click);
            // 
            // tsAnt
            // 
            this.tsAnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAnt.Enabled = false;
            this.tsAnt.Image = global::ControleFinanceiroIgreja.Properties.Resources.rpt__6_;
            this.tsAnt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAnt.Name = "tsAnt";
            this.tsAnt.Size = new System.Drawing.Size(36, 36);
            this.tsAnt.Text = "Página Anterior";
            this.tsAnt.Click += new System.EventHandler(this.tsAnt_Click);
            // 
            // tsTxtPag
            // 
            this.tsTxtPag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTxtPag.MaxLength = 3;
            this.tsTxtPag.Name = "tsTxtPag";
            this.tsTxtPag.ShortcutsEnabled = false;
            this.tsTxtPag.Size = new System.Drawing.Size(60, 32);
            this.tsTxtPag.Text = "1";
            this.tsTxtPag.ToolTipText = "Digite a Página Desejada";
            this.tsTxtPag.Enter += new System.EventHandler(this.tsTxtPag_Enter);
            this.tsTxtPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsTxtPag_KeyPress);
            this.tsTxtPag.Click += new System.EventHandler(this.tsTxtPag_Click);
            // 
            // tsPag
            // 
            this.tsPag.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPag.ForeColor = System.Drawing.Color.White;
            this.tsPag.Name = "tsPag";
            this.tsPag.Size = new System.Drawing.Size(48, 25);
            this.tsPag.Text = "de   ";
            // 
            // tsProx
            // 
            this.tsProx.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsProx.Enabled = false;
            this.tsProx.Image = global::ControleFinanceiroIgreja.Properties.Resources.rpt__1_;
            this.tsProx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsProx.Name = "tsProx";
            this.tsProx.Size = new System.Drawing.Size(36, 36);
            this.tsProx.Text = "Próxima Página";
            this.tsProx.Click += new System.EventHandler(this.tsProx_Click);
            // 
            // tsUlt
            // 
            this.tsUlt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUlt.Enabled = false;
            this.tsUlt.Image = global::ControleFinanceiroIgreja.Properties.Resources.rpt__7_;
            this.tsUlt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUlt.Name = "tsUlt";
            this.tsUlt.Size = new System.Drawing.Size(36, 36);
            this.tsUlt.Text = "Última Página";
            this.tsUlt.Click += new System.EventHandler(this.tsUlt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsImp
            // 
            this.tsImp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsImp.Image = global::ControleFinanceiroIgreja.Properties.Resources.rpt2;
            this.tsImp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsImp.Name = "tsImp";
            this.tsImp.Size = new System.Drawing.Size(36, 36);
            this.tsImp.ToolTipText = "Exportar como PDF";
            this.tsImp.Click += new System.EventHandler(this.tsImp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsImprimir
            // 
            this.tsImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsImprimir.ForeColor = System.Drawing.Color.White;
            this.tsImprimir.Image = global::ControleFinanceiroIgreja.Properties.Resources.printer_48;
            this.tsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsImprimir.Name = "tsImprimir";
            this.tsImprimir.Size = new System.Drawing.Size(98, 36);
            this.tsImprimir.Text = "Imprimir";
            this.tsImprimir.Click += new System.EventHandler(this.tsImprimir_Click);
            // 
            // tsImpView
            // 
            this.tsImpView.CheckOnClick = true;
            this.tsImpView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsImpView.Image = global::ControleFinanceiroIgreja.Properties.Resources.rpt__3_;
            this.tsImpView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsImpView.Name = "tsImpView";
            this.tsImpView.Size = new System.Drawing.Size(36, 36);
            this.tsImpView.Text = "Visualizar Impressão";
            this.tsImpView.Click += new System.EventHandler(this.tsImpView_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tsZoom
            // 
            this.tsZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsZoom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsZoom.Items.AddRange(new object[] {
            "Página Inteira",
            "Largura da Página",
            "500%",
            "200%",
            "150%",
            "100%",
            "75%",
            "50%",
            "25%"});
            this.tsZoom.MaxDropDownItems = 9;
            this.tsZoom.Name = "tsZoom";
            this.tsZoom.Size = new System.Drawing.Size(220, 33);
            this.tsZoom.ToolTipText = "Modo de Zoom";
            this.tsZoom.SelectedIndexChanged += new System.EventHandler(this.tsZoom_SelectedIndexChanged);
            this.tsZoom.Click += new System.EventHandler(this.tsZoom_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // tsConfig
            // 
            this.tsConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsConfig.Image = global::ControleFinanceiroIgreja.Properties.Resources.rpt__2_;
            this.tsConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsConfig.Name = "tsConfig";
            this.tsConfig.Size = new System.Drawing.Size(36, 36);
            this.tsConfig.Text = "Configurar Página";
            this.tsConfig.Click += new System.EventHandler(this.tsConfig_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.rvRelatorio);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 43, 0, 0);
            this.panel1.Size = new System.Drawing.Size(854, 493);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 493);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Gerador de Relatórios SisIg";
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
            this.btnFechar.Location = new System.Drawing.Point(814, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 38);
            this.btnFechar.TabIndex = 23;
            this.btnFechar.TabStop = false;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmVerRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(858, 497);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerRelatorio";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVerRelatorio_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rvRelatorio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsPrim;
        private System.Windows.Forms.ToolStripButton tsAnt;
        private System.Windows.Forms.ToolStripTextBox tsTxtPag;
        private System.Windows.Forms.ToolStripLabel tsPag;
        private System.Windows.Forms.ToolStripButton tsProx;
        private System.Windows.Forms.ToolStripButton tsUlt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsImp;
        private System.Windows.Forms.ToolStripButton tsImpView;
        private System.Windows.Forms.ToolStripComboBox tsZoom;
        private System.Windows.Forms.ToolStripButton tsConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsImprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
    }
}