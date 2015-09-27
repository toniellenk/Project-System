namespace Projeto_NFC_e
{
    partial class FormInicial
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
            this.ButStatSefaz = new System.Windows.Forms.Button();
            this.ButLimp = new System.Windows.Forms.Button();
            this.RetSefaz = new System.Windows.Forms.Label();
            this.XmlEnv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButConsNfc = new System.Windows.Forms.Button();
            this.TxtChave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButAss = new System.Windows.Forms.Button();
            this.ButMontNfe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButStatSefaz
            // 
            this.ButStatSefaz.Location = new System.Drawing.Point(473, 167);
            this.ButStatSefaz.Name = "ButStatSefaz";
            this.ButStatSefaz.Size = new System.Drawing.Size(75, 23);
            this.ButStatSefaz.TabIndex = 4;
            this.ButStatSefaz.Text = "Status Sefaz";
            this.ButStatSefaz.UseVisualStyleBackColor = true;
            this.ButStatSefaz.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButLimp
            // 
            this.ButLimp.Location = new System.Drawing.Point(473, 298);
            this.ButLimp.Name = "ButLimp";
            this.ButLimp.Size = new System.Drawing.Size(75, 23);
            this.ButLimp.TabIndex = 6;
            this.ButLimp.Text = "Limpar";
            this.ButLimp.UseVisualStyleBackColor = true;
            this.ButLimp.Click += new System.EventHandler(this.ButTest_Click);
            // 
            // RetSefaz
            // 
            this.RetSefaz.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RetSefaz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetSefaz.Cursor = System.Windows.Forms.Cursors.Default;
            this.RetSefaz.ForeColor = System.Drawing.Color.Black;
            this.RetSefaz.Location = new System.Drawing.Point(563, 167);
            this.RetSefaz.Name = "RetSefaz";
            this.RetSefaz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RetSefaz.Size = new System.Drawing.Size(455, 286);
            this.RetSefaz.TabIndex = 7;
            this.RetSefaz.Click += new System.EventHandler(this.RetSefaz_Click);
            // 
            // XmlEnv
            // 
            this.XmlEnv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.XmlEnv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.XmlEnv.Cursor = System.Windows.Forms.Cursors.Default;
            this.XmlEnv.ForeColor = System.Drawing.Color.Black;
            this.XmlEnv.Location = new System.Drawing.Point(12, 167);
            this.XmlEnv.Name = "XmlEnv";
            this.XmlEnv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.XmlEnv.Size = new System.Drawing.Size(455, 286);
            this.XmlEnv.TabIndex = 9;
            this.XmlEnv.Click += new System.EventHandler(this.XmlEnv_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "XML de Envio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "XML de Retorno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ButConsNfc
            // 
            this.ButConsNfc.Location = new System.Drawing.Point(125, 66);
            this.ButConsNfc.Name = "ButConsNfc";
            this.ButConsNfc.Size = new System.Drawing.Size(100, 23);
            this.ButConsNfc.TabIndex = 12;
            this.ButConsNfc.Text = "Consulta NFC-e";
            this.ButConsNfc.UseVisualStyleBackColor = true;
            this.ButConsNfc.Click += new System.EventHandler(this.ButConsNfc_Click);
            // 
            // TxtChave
            // 
            this.TxtChave.Location = new System.Drawing.Point(11, 40);
            this.TxtChave.Name = "TxtChave";
            this.TxtChave.Size = new System.Drawing.Size(346, 20);
            this.TxtChave.TabIndex = 13;
            this.TxtChave.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chave NFC-e";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtChave);
            this.panel1.Controls.Add(this.ButConsNfc);
            this.panel1.Location = new System.Drawing.Point(334, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 102);
            this.panel1.TabIndex = 15;
            // 
            // ButAss
            // 
            this.ButAss.Location = new System.Drawing.Point(474, 217);
            this.ButAss.Name = "ButAss";
            this.ButAss.Size = new System.Drawing.Size(75, 23);
            this.ButAss.TabIndex = 16;
            this.ButAss.Text = "Assinar";
            this.ButAss.UseVisualStyleBackColor = true;
            this.ButAss.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ButMontNfe
            // 
            this.ButMontNfe.Location = new System.Drawing.Point(474, 344);
            this.ButMontNfe.Name = "ButMontNfe";
            this.ButMontNfe.Size = new System.Drawing.Size(75, 23);
            this.ButMontNfe.TabIndex = 17;
            this.ButMontNfe.Text = "Montar NFe";
            this.ButMontNfe.UseVisualStyleBackColor = true;
            this.ButMontNfe.Click += new System.EventHandler(this.ButMontNfe_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 544);
            this.Controls.Add(this.ButMontNfe);
            this.Controls.Add(this.ButAss);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XmlEnv);
            this.Controls.Add(this.RetSefaz);
            this.Controls.Add(this.ButLimp);
            this.Controls.Add(this.ButStatSefaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormInicial";
            this.Text = "NFCe - Nota Fiscal do Consumidor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButLimp;
        private System.Windows.Forms.Button ButStatSefaz;
        private System.Windows.Forms.Label RetSefaz;
        private System.Windows.Forms.Label XmlEnv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButConsNfc;
        private System.Windows.Forms.TextBox TxtChave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButAss;
        private System.Windows.Forms.Button ButMontNfe;
    }
}

