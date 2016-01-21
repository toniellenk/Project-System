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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuInicial = new System.Windows.Forms.MenuStrip();
            this.MenCad = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estabelecimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenVend = new System.Windows.Forms.ToolStripMenuItem();
            this.PdVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.NomRotina = new System.Windows.Forms.Label();
            this.LsVyPrinc = new System.Windows.Forms.DataGridView();
            this.PanFiltros = new System.Windows.Forms.Panel();
            this.TxtBoxProcurar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadButContendo = new System.Windows.Forms.RadioButton();
            this.RadButIgual = new System.Windows.Forms.RadioButton();
            this.ButProcurar = new System.Windows.Forms.Button();
            this.CombBxFilt = new System.Windows.Forms.ComboBox();
            this.ButNovo = new System.Windows.Forms.Button();
            this.ButExcluir = new System.Windows.Forms.Button();
            this.ButAlterar = new System.Windows.Forms.Button();
            this.MenuInicial.SuspendLayout();
            this.PanCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LsVyPrinc)).BeginInit();
            this.PanFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuInicial
            // 
            this.MenuInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.MenuInicial.AutoSize = false;
            this.MenuInicial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuInicial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuInicial.BackgroundImage")));
            this.MenuInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
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
            this.MenuInicial.Size = new System.Drawing.Size(1194, 50);
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
            this.MenCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenCad.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MenCad.Image = ((System.Drawing.Image)(resources.GetObject("MenCad.Image")));
            this.MenCad.Name = "MenCad";
            this.MenCad.Size = new System.Drawing.Size(111, 46);
            this.MenCad.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtosToolStripMenuItem.Image")));
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // estabelecimentosToolStripMenuItem
            // 
            this.estabelecimentosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estabelecimentosToolStripMenuItem.Name = "estabelecimentosToolStripMenuItem";
            this.estabelecimentosToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.estabelecimentosToolStripMenuItem.Text = "Estabelecimentos";
            // 
            // MenVend
            // 
            this.MenVend.BackColor = System.Drawing.Color.Transparent;
            this.MenVend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PdVendaToolStripMenuItem,
            this.documentosDeSaídaToolStripMenuItem});
            this.MenVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenVend.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MenVend.Image = ((System.Drawing.Image)(resources.GetObject("MenVend.Image")));
            this.MenVend.Name = "MenVend";
            this.MenVend.Size = new System.Drawing.Size(101, 46);
            this.MenVend.Text = "Vendas";
            this.MenVend.Click += new System.EventHandler(this.nFeToolStripMenuItem_Click);
            // 
            // PdVendaToolStripMenuItem
            // 
            this.PdVendaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdVendaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PdVendaToolStripMenuItem.Image")));
            this.PdVendaToolStripMenuItem.Name = "PdVendaToolStripMenuItem";
            this.PdVendaToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.PdVendaToolStripMenuItem.Text = "Pedidos de Venda";
            this.PdVendaToolStripMenuItem.Click += new System.EventHandler(this.orçamentosToolStripMenuItem_Click);
            // 
            // documentosDeSaídaToolStripMenuItem
            // 
            this.documentosDeSaídaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nFeToolStripMenuItem1});
            this.documentosDeSaídaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentosDeSaídaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("documentosDeSaídaToolStripMenuItem.Image")));
            this.documentosDeSaídaToolStripMenuItem.Name = "documentosDeSaídaToolStripMenuItem";
            this.documentosDeSaídaToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.documentosDeSaídaToolStripMenuItem.Text = "Documentos de Saída";
            // 
            // nFeToolStripMenuItem1
            // 
            this.nFeToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nFeToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFeToolStripMenuItem1.Image = global::Projeto_NFC_e.Properties.Resources.Word_html_doc;
            this.nFeToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.nFeToolStripMenuItem1.Name = "nFeToolStripMenuItem1";
            this.nFeToolStripMenuItem1.Size = new System.Drawing.Size(121, 32);
            this.nFeToolStripMenuItem1.Text = "NFe";
            this.nFeToolStripMenuItem1.Click += new System.EventHandler(this.nFeToolStripMenuItem1_Click);
            // 
            // MenFinan
            // 
            this.MenFinan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem,
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem});
            this.MenFinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenFinan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MenFinan.Image = ((System.Drawing.Image)(resources.GetObject("MenFinan.Image")));
            this.MenFinan.Name = "MenFinan";
            this.MenFinan.Size = new System.Drawing.Size(120, 46);
            this.MenFinan.Text = "Financeiro";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            // 
            // MenEst
            // 
            this.MenEst.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saldoProdutosToolStripMenuItem});
            this.MenEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenEst.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MenEst.Image = ((System.Drawing.Image)(resources.GetObject("MenEst.Image")));
            this.MenEst.Name = "MenEst";
            this.MenEst.Size = new System.Drawing.Size(106, 46);
            this.MenEst.Text = "Estoque";
            // 
            // saldoProdutosToolStripMenuItem
            // 
            this.saldoProdutosToolStripMenuItem.Name = "saldoProdutosToolStripMenuItem";
            this.saldoProdutosToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.saldoProdutosToolStripMenuItem.Text = "Produtos";
            this.saldoProdutosToolStripMenuItem.Click += new System.EventHandler(this.saldoProdutosToolStripMenuItem_Click);
            // 
            // MenRel
            // 
            this.MenRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenRel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MenRel.Image = ((System.Drawing.Image)(resources.GetObject("MenRel.Image")));
            this.MenRel.Name = "MenRel";
            this.MenRel.Size = new System.Drawing.Size(118, 46);
            this.MenRel.Text = "Relatórios";
            // 
            // PanCentral
            // 
            this.PanCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanCentral.AutoScroll = true;
            this.PanCentral.BackColor = System.Drawing.Color.Transparent;
            this.PanCentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanCentral.BackgroundImage")));
            this.PanCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanCentral.Controls.Add(this.NomRotina);
            this.PanCentral.Controls.Add(this.ButNovo);
            this.PanCentral.Controls.Add(this.ButAlterar);
            this.PanCentral.Controls.Add(this.LsVyPrinc);
            this.PanCentral.Controls.Add(this.ButExcluir);
            this.PanCentral.Controls.Add(this.PanFiltros);
            this.PanCentral.Location = new System.Drawing.Point(201, 49);
            this.PanCentral.Margin = new System.Windows.Forms.Padding(5);
            this.PanCentral.Name = "PanCentral";
            this.PanCentral.Size = new System.Drawing.Size(1009, 911);
            this.PanCentral.TabIndex = 1;
            this.PanCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanCentral_Paint);
            // 
            // NomRotina
            // 
            this.NomRotina.AutoSize = true;
            this.NomRotina.BackColor = System.Drawing.Color.Transparent;
            this.NomRotina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomRotina.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NomRotina.Location = new System.Drawing.Point(3, 57);
            this.NomRotina.Name = "NomRotina";
            this.NomRotina.Size = new System.Drawing.Size(104, 24);
            this.NomRotina.TabIndex = 6;
            this.NomRotina.Text = "NomRotina";
            this.NomRotina.Click += new System.EventHandler(this.NomRotina_Click);
            // 
            // LsVyPrinc
            // 
            this.LsVyPrinc.AllowUserToAddRows = false;
            this.LsVyPrinc.AllowUserToDeleteRows = false;
            this.LsVyPrinc.AllowUserToResizeColumns = false;
            this.LsVyPrinc.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LsVyPrinc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.LsVyPrinc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LsVyPrinc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LsVyPrinc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.LsVyPrinc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LsVyPrinc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LsVyPrinc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.LsVyPrinc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LsVyPrinc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.LsVyPrinc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LsVyPrinc.DefaultCellStyle = dataGridViewCellStyle7;
            this.LsVyPrinc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.LsVyPrinc.GridColor = System.Drawing.Color.Aqua;
            this.LsVyPrinc.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.LsVyPrinc.Location = new System.Drawing.Point(0, 248);
            this.LsVyPrinc.Margin = new System.Windows.Forms.Padding(5);
            this.LsVyPrinc.MultiSelect = false;
            this.LsVyPrinc.Name = "LsVyPrinc";
            this.LsVyPrinc.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LsVyPrinc.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.LsVyPrinc.RowHeadersVisible = false;
            this.LsVyPrinc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LsVyPrinc.Size = new System.Drawing.Size(987, 545);
            this.LsVyPrinc.StandardTab = true;
            this.LsVyPrinc.TabIndex = 2;
            this.LsVyPrinc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LsVyPrinc_CellContentClick);
            this.LsVyPrinc.GotFocus += new System.EventHandler(this.Foco);
            // 
            // PanFiltros
            // 
            this.PanFiltros.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanFiltros.Controls.Add(this.TxtBoxProcurar);
            this.PanFiltros.Controls.Add(this.groupBox1);
            this.PanFiltros.Controls.Add(this.ButProcurar);
            this.PanFiltros.Controls.Add(this.CombBxFilt);
            this.PanFiltros.Location = new System.Drawing.Point(0, 139);
            this.PanFiltros.Name = "PanFiltros";
            this.PanFiltros.Size = new System.Drawing.Size(987, 81);
            this.PanFiltros.TabIndex = 5;
            this.PanFiltros.Visible = false;
            this.PanFiltros.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TxtBoxProcurar
            // 
            this.TxtBoxProcurar.Location = new System.Drawing.Point(396, 37);
            this.TxtBoxProcurar.Name = "TxtBoxProcurar";
            this.TxtBoxProcurar.Size = new System.Drawing.Size(202, 20);
            this.TxtBoxProcurar.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadButContendo);
            this.groupBox1.Controls.Add(this.RadButIgual);
            this.groupBox1.Location = new System.Drawing.Point(196, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 39);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RadButContendo
            // 
            this.RadButContendo.AutoSize = true;
            this.RadButContendo.Location = new System.Drawing.Point(80, 16);
            this.RadButContendo.Name = "RadButContendo";
            this.RadButContendo.Size = new System.Drawing.Size(71, 17);
            this.RadButContendo.TabIndex = 8;
            this.RadButContendo.TabStop = true;
            this.RadButContendo.Text = "Contendo";
            this.RadButContendo.UseVisualStyleBackColor = true;
            // 
            // RadButIgual
            // 
            this.RadButIgual.AutoSize = true;
            this.RadButIgual.Location = new System.Drawing.Point(14, 16);
            this.RadButIgual.Name = "RadButIgual";
            this.RadButIgual.Size = new System.Drawing.Size(48, 17);
            this.RadButIgual.TabIndex = 0;
            this.RadButIgual.TabStop = true;
            this.RadButIgual.Text = "Igual";
            this.RadButIgual.UseVisualStyleBackColor = true;
            // 
            // ButProcurar
            // 
            this.ButProcurar.Location = new System.Drawing.Point(624, 36);
            this.ButProcurar.Name = "ButProcurar";
            this.ButProcurar.Size = new System.Drawing.Size(75, 23);
            this.ButProcurar.TabIndex = 1;
            this.ButProcurar.Text = "Procurar";
            this.ButProcurar.UseVisualStyleBackColor = true;
            this.ButProcurar.Click += new System.EventHandler(this.ButProcurar_Click);
            // 
            // CombBxFilt
            // 
            this.CombBxFilt.FormattingEnabled = true;
            this.CombBxFilt.Location = new System.Drawing.Point(46, 36);
            this.CombBxFilt.Name = "CombBxFilt";
            this.CombBxFilt.Size = new System.Drawing.Size(131, 21);
            this.CombBxFilt.TabIndex = 0;
            this.CombBxFilt.SelectedIndexChanged += new System.EventHandler(this.CombBxFilt_SelectedIndexChanged);
            // 
            // ButNovo
            // 
            this.ButNovo.BackColor = System.Drawing.Color.Transparent;
            this.ButNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButNovo.Location = new System.Drawing.Point(22, 799);
            this.ButNovo.Name = "ButNovo";
            this.ButNovo.Size = new System.Drawing.Size(75, 26);
            this.ButNovo.TabIndex = 1;
            this.ButNovo.Text = "Novo";
            this.ButNovo.UseVisualStyleBackColor = false;
            this.ButNovo.Click += new System.EventHandler(this.ButNovo_Click);
            // 
            // ButExcluir
            // 
            this.ButExcluir.BackColor = System.Drawing.Color.Transparent;
            this.ButExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButExcluir.Location = new System.Drawing.Point(227, 799);
            this.ButExcluir.Name = "ButExcluir";
            this.ButExcluir.Size = new System.Drawing.Size(75, 26);
            this.ButExcluir.TabIndex = 4;
            this.ButExcluir.Text = "Excluir";
            this.ButExcluir.UseVisualStyleBackColor = false;
            this.ButExcluir.Click += new System.EventHandler(this.ButDelCliente_Click);
            // 
            // ButAlterar
            // 
            this.ButAlterar.BackColor = System.Drawing.Color.Transparent;
            this.ButAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButAlterar.Location = new System.Drawing.Point(125, 799);
            this.ButAlterar.Name = "ButAlterar";
            this.ButAlterar.Size = new System.Drawing.Size(75, 26);
            this.ButAlterar.TabIndex = 3;
            this.ButAlterar.Text = "Alterar";
            this.ButAlterar.UseVisualStyleBackColor = false;
            this.ButAlterar.Click += new System.EventHandler(this.ButAltCliente_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 960);
            this.Controls.Add(this.MenuInicial);
            this.Controls.Add(this.PanCentral);
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
            this.PanFiltros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem PdVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoProdutosToolStripMenuItem;
        private System.Windows.Forms.Panel PanCentral;
        private System.Windows.Forms.Button ButNovo;
        private System.Windows.Forms.DataGridView LsVyPrinc;
        private System.Windows.Forms.Button ButAlterar;
        private System.Windows.Forms.Button ButExcluir;
        private System.Windows.Forms.Panel PanFiltros;
        private System.Windows.Forms.ComboBox CombBxFilt;
        private System.Windows.Forms.Button ButProcurar;
        private System.Windows.Forms.Label NomRotina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadButIgual;
        private System.Windows.Forms.TextBox TxtBoxProcurar;
        private System.Windows.Forms.RadioButton RadButContendo;



    }
}