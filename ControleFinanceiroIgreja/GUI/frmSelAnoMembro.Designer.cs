namespace ControleFinanceiroIgreja.GUI
{
    partial class frmSelAnoMembro
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
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMembro = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAno
            // 
            this.cbAno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAno.DropDownHeight = 400;
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAno.FormattingEnabled = true;
            this.cbAno.IntegralHeight = false;
            this.cbAno.Location = new System.Drawing.Point(6, 63);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(193, 27);
            this.cbAno.TabIndex = 0;
            this.cbAno.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbAno_DrawItem);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(7, 40);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(41, 20);
            this.lblAno.TabIndex = 62;
            this.lblAno.Text = "Ano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Membro";
            // 
            // cbMembro
            // 
            this.cbMembro.DropDownHeight = 400;
            this.cbMembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMembro.IntegralHeight = false;
            this.cbMembro.Location = new System.Drawing.Point(7, 120);
            this.cbMembro.Name = "cbMembro";
            this.cbMembro.Size = new System.Drawing.Size(494, 28);
            this.cbMembro.TabIndex = 1;
            this.cbMembro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMembro_KeyPress);
            this.cbMembro.Leave += new System.EventHandler(this.cbMembro_Leave);
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(335, 166);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(163, 39);
            this.btnOk.TabIndex = 68;
            this.btnOk.Text = "Gerar Relatório";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            this.btnFechar.Location = new System.Drawing.Point(470, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 38);
            this.btnFechar.TabIndex = 70;
            this.btnFechar.TabStop = false;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "Selecione os dados para emissão do relatório";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.cbAno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.cbMembro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 221);
            this.panel1.TabIndex = 72;
            // 
            // frmSelAnoMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(514, 225);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelAnoMembro";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecione os dados para gerar o relatório";
            this.Load += new System.EventHandler(this.frmSelAnoMembro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMembro;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}