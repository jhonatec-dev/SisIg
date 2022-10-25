namespace ControleFinanceiroIgreja.GUI
{
    partial class frmSelClasseAno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelClasseAno));
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGerarRel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkInativos = new System.Windows.Forms.CheckBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbClasses
            // 
            this.cbClasses.DropDownHeight = 400;
            this.cbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasses.IntegralHeight = false;
            this.cbClasses.Location = new System.Drawing.Point(8, 35);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(476, 28);
            this.cbClasses.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Classe *";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Campos obrigatórios *";
            // 
            // btnGerarRel
            // 
            this.btnGerarRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRel.Image = global::ControleFinanceiroIgreja.Properties.Resources.report_48;
            this.btnGerarRel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarRel.Location = new System.Drawing.Point(346, 159);
            this.btnGerarRel.Name = "btnGerarRel";
            this.btnGerarRel.Size = new System.Drawing.Size(131, 57);
            this.btnGerarRel.TabIndex = 34;
            this.btnGerarRel.Text = "Gerar";
            this.btnGerarRel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarRel.UseVisualStyleBackColor = true;
            this.btnGerarRel.Click += new System.EventHandler(this.btnGerarRel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ano *";
            // 
            // chkInativos
            // 
            this.chkInativos.AutoSize = true;
            this.chkInativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInativos.Location = new System.Drawing.Point(271, 99);
            this.chkInativos.Name = "chkInativos";
            this.chkInativos.Size = new System.Drawing.Size(213, 24);
            this.chkInativos.TabIndex = 38;
            this.chkInativos.Text = "Mostrar alunos inativos";
            this.chkInativos.UseVisualStyleBackColor = true;
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(8, 99);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 26);
            this.txtAno.TabIndex = 39;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // frmSelClasseAno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 225);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.chkInativos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGerarRel);
            this.Controls.Add(this.cbClasses);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelClasseAno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecionar classe e ano";
            this.Load += new System.EventHandler(this.frmSelClasseAno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGerarRel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkInativos;
        private System.Windows.Forms.TextBox txtAno;
    }
}