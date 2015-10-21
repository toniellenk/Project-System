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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuInicial = new System.Windows.Forms.MenuStrip();
            this.MenCad = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estabelecimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenVend = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosDeSaídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nFeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenFinan = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenEst = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenRel = new System.Windows.Forms.ToolStripMenuItem();
            this.PanCentral = new System.Windows.Forms.Panel();
            this.LsVyPrinc = new System.Windows.Forms.DataGridView();
            this.PanFiltros = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CombBxFilt = new System.Windows.Forms.ComboBox();
            this.BuNvCliente = new System.Windows.Forms.Button();
            this.ButDelCliente = new System.Windows.Forms.Button();
            this.ButAltCliente = new System.Windows.Forms.Button();
            this.NomRotina = new System.Windows.Forms.Label();
            this.MenuInicial.SuspendLayout();
            this.PanCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LsVyPrinc)).BeginInit();
            this.PanFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuInicial
            // 
            this.MenuInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.MenuInicial.AutoSize = false;
            this.MenuInicial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MenuInicial.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.MenuInicial.GripMargin = new System.Windows.Forms.Padding(2);
            this.MenuInicial.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.MenuInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenCad,
            this.MenVend,
            this.MenFinan,
            this.MenEst,
            this.MenRel});
            this.MenuInicial.Location = new System.Drawing.Point(0, 0);
            this.MenuInicial.Margin = new System.Windows.Forms.Padding(2);
            this.MenuInicial.Name = "MenuInicial";
            this.MenuInicial.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuInicial.Size = new System.Drawing.Size(1237, 50);
            this.MenuInicial.TabIndex = 0;
            this.MenuInicial.Text = "MenuInicial";
            this.MenuInicial.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuInicial_ItemClicked);
            // 
            // MenCad
            // 
            this.MenCad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.estabelecimentosToolStripMenuItem});
            this.MenCad.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.MenCad.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MenCad.Image = ((System.Drawing.Image)(resources.GetObject("MenCad.Image")));
            this.MenCad.Name = "MenCad";
            this.MenCad.Size = new System.Drawing.Size(118, 46);
            this.MenCad.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click_1);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // estabelecimentosToolStripMenuItem
            // 
            this.estabelecimentosToolStripMenuItem.Name = "estabelecimentosToolStripMenuItem";
            this.estabelecimentosToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.estabelecimentosToolStripMenuItem.Text = "Estabelecimentos";
            // 
            // MenVend
            // 
            this.MenVend.BackColor = System.Drawing.Color.Transparent;
            this.MenVend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orçamentosToolStripMenuItem,
            this.documentosDeSaídaToolStripMenuItem});
            this.MenVend.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.MenVend.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MenVend.Image = ((System.Drawing.Image)(resources.GetObject("MenVend.Image")));
            this.MenVend.Name = "MenVend";
            this.MenVend.Size = new System.Drawing.Size(103, 46);
            this.MenVend.Text = "Vendas";
            this.MenVend.Click += new System.EventHandler(this.nFeToolStripMenuItem_Click);
            // 
            // orçamentosToolStripMenuItem
            // 
            this.orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            this.orçamentosToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.orçamentosToolStripMenuItem.Text = "Orçamentos";
            // 
            // documentosDeSaídaToolStripMenuItem
            // 
            this.documentosDeSaídaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nFeToolStripMenuItem1});
            this.documentosDeSaídaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("documentosDeSaídaToolStripMenuItem.Image")));
            this.documentosDeSaídaToolStripMenuItem.Name = "documentosDeSaídaToolStripMenuItem";
            this.documentosDeSaídaToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.documentosDeSaídaToolStripMenuItem.Text = "Documentos de Saída";
            // 
            // nFeToolStripMenuItem1
            // 
            this.nFeToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nFeToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFeToolStripMenuItem1.Image = global::Projeto_NFC_e.Properties.Resources.Word_html_doc;
            this.nFeToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.nFeToolStripMenuItem1.Name = "nFeToolStripMenuItem1";
            this.nFeToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.nFeToolStripMenuItem1.Text = "NFe";
            this.nFeToolStripMenuItem1.Click += new System.EventHandler(this.nFeToolStripMenuItem1_Click);
            // 
            // MenFinan
            // 
            this.MenFinan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem,
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem});
            this.MenFinan.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.MenFinan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MenFinan.Image = ((System.Drawing.Image)(resources.GetObject("MenFinan.Image")));
            this.MenFinan.Name = "MenFinan";
            this.MenFinan.Size = new System.Drawing.Size(132, 46);
            this.MenFinan.Text = "Financeiro";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            // 
            // MenEst
            // 
            this.MenEst.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saldoProdutosToolStripMenuItem});
            this.MenEst.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.MenEst.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MenEst.Image = ((System.Drawing.Image)(resources.GetObject("MenEst.Image")));
            this.MenEst.Name = "MenEst";
            this.MenEst.Size = new System.Drawing.Size(110, 46);
            this.MenEst.Text = "Estoque";
            // 
            // saldoProdutosToolStripMenuItem
            // 
            this.saldoProdutosToolStripMenuItem.Name = "saldoProdutosToolStripMenuItem";
            this.saldoProdutosToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.saldoProdutosToolStripMenuItem.Text = "Produtos";
            this.saldoProdutosToolStripMenuItem.Click += new System.EventHandler(this.saldoProdutosToolStripMenuItem_Click);
            // 
            // MenRel
            // 
            this.MenRel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.MenRel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MenRel.Image = ((System.Drawing.Image)(resources.GetObject("MenRel.Image")));
            this.MenRel.Name = "MenRel";
            this.MenRel.Size = new System.Drawing.Size(130, 46);
            this.MenRel.Text = "Relatórios";
            // 
            // PanCentral
            // 
            this.PanCentral.AutoScroll = true;
            this.PanCentral.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanCentral.Controls.Add(this.NomRotina);
            this.PanCentral.Controls.Add(this.LsVyPrinc);
            this.PanCentral.Controls.Add(this.PanFiltros);
            this.PanCentral.Controls.Add(this.BuNvCliente);
            this.PanCentral.Controls.Add(this.ButDelCliente);
            this.PanCentral.Controls.Add(this.ButAltCliente);
            this.PanCentral.Location = new System.Drawing.Point(164, 55);
            this.PanCentral.Margin = new System.Windows.Forms.Padding(5);
            this.PanCentral.Name = "PanCentral";
            this.PanCentral.Size = new System.Drawing.Size(1072, 860);
            this.PanCentral.TabIndex = 1;
            this.PanCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanCentral_Paint);
            // 
            // LsVyPrinc
            // 
            this.LsVyPrinc.AllowUserToAddRows = false;
            this.LsVyPrinc.AllowUserToDeleteRows = false;
            this.LsVyPrinc.AllowUserToResizeColumns = false;
            this.LsVyPrinc.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LsVyPrinc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.LsVyPrinc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LsVyPrinc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LsVyPrinc.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.LsVyPrinc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LsVyPrinc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LsVyPrinc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.LsVyPrinc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LsVyPrinc.DefaultCellStyle = dataGridViewCellStyle6;
            this.LsVyPrinc.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.LsVyPrinc.Location = new System.Drawing.Point(-1, 248);
            this.LsVyPrinc.Margin = new System.Windows.Forms.Padding(5);
            this.LsVyPrinc.MultiSelect = false;
            this.LsVyPrinc.Name = "LsVyPrinc";
            this.LsVyPrinc.ReadOnly = true;
            this.LsVyPrinc.RowHeadersVisible = false;
            this.LsVyPrinc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LsVyPrinc.Size = new System.Drawing.Size(1071, 506);
            this.LsVyPrinc.TabIndex = 2;
            this.LsVyPrinc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LsVyPrinc_CellContentClick);
            this.LsVyPrinc.GotFocus += new System.EventHandler(this.Foco);
            // 
            // PanFiltros
            // 
            this.PanFiltros.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PanFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanFiltros.Controls.Add(this.button1);
            this.PanFiltros.Controls.Add(this.CombBxFilt);
            this.PanFiltros.Location = new System.Drawing.Point(-1, 101);
            this.PanFiltros.Name = "PanFiltros";
            this.PanFiltros.Size = new System.Drawing.Size(1066, 122);
            this.PanFiltros.TabIndex = 5;
            this.PanFiltros.Visible = false;
            this.PanFiltros.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CombBxFilt
            // 
            this.CombBxFilt.FormattingEnabled = true;
            this.CombBxFilt.Location = new System.Drawing.Point(64, 30);
            this.CombBxFilt.Name = "CombBxFilt";
            this.CombBxFilt.Size = new System.Drawing.Size(121, 21);
            this.CombBxFilt.TabIndex = 0;
            this.CombBxFilt.Visible = false;
            // 
            // BuNvCliente
            // 
            this.BuNvCliente.Location = new System.Drawing.Point(64, 810);
            this.BuNvCliente.Name = "BuNvCliente";
            this.BuNvCliente.Size = new System.Drawing.Size(75, 26);
            this.BuNvCliente.TabIndex = 1;
            this.BuNvCliente.Text = "Novo";
            this.BuNvCliente.UseVisualStyleBackColor = true;
            this.BuNvCliente.Click += new System.EventHandler(this.ButNovo_Click);
            // 
            // ButDelCliente
            // 
            this.ButDelCliente.Location = new System.Drawing.Point(277, 810);
            this.ButDelCliente.Name = "ButDelCliente";
            this.ButDelCliente.Size = new System.Drawing.Size(75, 26);
            this.ButDelCliente.TabIndex = 4;
            this.ButDelCliente.Text = "Excluir";
            this.ButDelCliente.UseVisualStyleBackColor = true;
            this.ButDelCliente.Click += new System.EventHandler(this.ButDelCliente_Click);
            // 
            // ButAltCliente
            // 
            this.ButAltCliente.Location = new System.Drawing.Point(172, 810);
            this.ButAltCliente.Name = "ButAltCliente";
            this.ButAltCliente.Size = new System.Drawing.Size(75, 26);
            this.ButAltCliente.TabIndex = 3;
            this.ButAltCliente.Text = "Alterar";
            this.ButAltCliente.UseVisualStyleBackColor = true;
            this.ButAltCliente.Click += new System.EventHandler(this.ButAltCliente_Click);
            // 
            // NomRotina
            // 
            this.NomRotina.AutoSize = true;
            this.NomRotina.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomRotina.Location = new System.Drawing.Point(17, 12);
            this.NomRotina.Name = "NomRotina";
            this.NomRotina.Size = new System.Drawing.Size(262, 55);
            this.NomRotina.TabIndex = 6;
            this.NomRotina.Text = "NomRotina";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1237, 998);
            this.Controls.Add(this.PanCentral);
            this.Controls.Add(this.MenuInicial);
            this.MainMenuStrip = this.MenuInicial;
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.MenuInicial.ResumeLayout(false);
            this.MenuInicial.PerformLayout();
            this.PanCentral.ResumeLayout(false);
            this.PanCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LsVyPrinc)).EndInit();
            this.PanFiltros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuInicial;
        private System.Windows.Forms.ToolStripMenuItem MenVend;
        private System.Windows.Forms.ToolStripMenuItem documentosDeSaídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nFeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenCad;
        private System.Windows.Forms.ToolStripMenuItem MenFinan;
        private System.Windows.Forms.ToolStripMenuItem MenEst;
        private System.Windows.Forms.ToolStripMenuItem MenRel;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estabelecimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoProdutosToolStripMenuItem;
        private System.Windows.Forms.Panel PanCentral;
        private System.Windows.Forms.Button BuNvCliente;
        private System.Windows.Forms.DataGridView LsVyPrinc;
        private System.Windows.Forms.Button ButAltCliente;
        private System.Windows.Forms.Button ButDelCliente;
        private System.Windows.Forms.Panel PanFiltros;
        private System.Windows.Forms.ComboBox CombBxFilt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NomRotina;



    }
}