namespace Perfumaria
{
    partial class frmNovaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaVenda));
            this.grpNovaVenda = new System.Windows.Forms.GroupBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.cboMetodoPagamento = new System.Windows.Forms.ComboBox();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataEmissao = new System.Windows.Forms.TextBox();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtCPFCNPJ = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPFCNPJ = new System.Windows.Forms.Label();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdbCPF = new System.Windows.Forms.RadioButton();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.grdItens = new System.Windows.Forms.DataGridView();
            this.grpListaC = new System.Windows.Forms.GroupBox();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbSKU = new System.Windows.Forms.RadioButton();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.grpListaP = new System.Windows.Forms.GroupBox();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.grpNovaVenda.SuspendLayout();
            this.grpTotal.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.grpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItens)).BeginInit();
            this.grpListaC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            this.grpListaP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNovaVenda
            // 
            this.grpNovaVenda.Controls.Add(this.lblPagamento);
            this.grpNovaVenda.Controls.Add(this.cboMetodoPagamento);
            this.grpNovaVenda.Controls.Add(this.grpTotal);
            this.grpNovaVenda.Controls.Add(this.txtNome);
            this.grpNovaVenda.Controls.Add(this.txtDataEmissao);
            this.grpNovaVenda.Controls.Add(this.txtNotaFiscal);
            this.grpNovaVenda.Controls.Add(this.lblNotaFiscal);
            this.grpNovaVenda.Controls.Add(this.lblData);
            this.grpNovaVenda.Controls.Add(this.txtCPFCNPJ);
            this.grpNovaVenda.Controls.Add(this.lblNome);
            this.grpNovaVenda.Controls.Add(this.lblCPFCNPJ);
            this.grpNovaVenda.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpNovaVenda.ForeColor = System.Drawing.Color.DimGray;
            this.grpNovaVenda.Location = new System.Drawing.Point(14, 327);
            this.grpNovaVenda.Name = "grpNovaVenda";
            this.grpNovaVenda.Size = new System.Drawing.Size(751, 132);
            this.grpNovaVenda.TabIndex = 44;
            this.grpNovaVenda.TabStop = false;
            this.grpNovaVenda.Text = "Dados da Venda";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblPagamento.ForeColor = System.Drawing.Color.DimGray;
            this.lblPagamento.Location = new System.Drawing.Point(7, 76);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(178, 18);
            this.lblPagamento.TabIndex = 17;
            this.lblPagamento.Text = "Método de Pagamento";
            // 
            // cboMetodoPagamento
            // 
            this.cboMetodoPagamento.BackColor = System.Drawing.SystemColors.Control;
            this.cboMetodoPagamento.Font = new System.Drawing.Font("Verdana", 12F);
            this.cboMetodoPagamento.ForeColor = System.Drawing.Color.DimGray;
            this.cboMetodoPagamento.FormattingEnabled = true;
            this.cboMetodoPagamento.Location = new System.Drawing.Point(10, 95);
            this.cboMetodoPagamento.Name = "cboMetodoPagamento";
            this.cboMetodoPagamento.Size = new System.Drawing.Size(215, 26);
            this.cboMetodoPagamento.TabIndex = 16;
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.lblValorTotal);
            this.grpTotal.Font = new System.Drawing.Font("Verdana", 11F);
            this.grpTotal.ForeColor = System.Drawing.Color.DimGray;
            this.grpTotal.Location = new System.Drawing.Point(538, 76);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(206, 46);
            this.grpTotal.TabIndex = 15;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Valor Total";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblValorTotal.Location = new System.Drawing.Point(9, 19);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(191, 21);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.Text = "R$ 0,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(296, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(448, 27);
            this.txtNome.TabIndex = 3;
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDataEmissao.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtDataEmissao.ForeColor = System.Drawing.Color.Black;
            this.txtDataEmissao.Location = new System.Drawing.Point(419, 95);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.ReadOnly = true;
            this.txtDataEmissao.Size = new System.Drawing.Size(113, 27);
            this.txtDataEmissao.TabIndex = 8;
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNotaFiscal.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNotaFiscal.ForeColor = System.Drawing.Color.Black;
            this.txtNotaFiscal.Location = new System.Drawing.Point(231, 95);
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.ReadOnly = true;
            this.txtNotaFiscal.Size = new System.Drawing.Size(182, 27);
            this.txtNotaFiscal.TabIndex = 7;
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblNotaFiscal.ForeColor = System.Drawing.Color.DimGray;
            this.lblNotaFiscal.Location = new System.Drawing.Point(228, 76);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(113, 18);
            this.lblNotaFiscal.TabIndex = 6;
            this.lblNotaFiscal.Text = "N° Nota Fiscal";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblData.ForeColor = System.Drawing.Color.DimGray;
            this.lblData.Location = new System.Drawing.Point(416, 75);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(110, 18);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data Emissão";
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCPFCNPJ.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtCPFCNPJ.ForeColor = System.Drawing.Color.Black;
            this.txtCPFCNPJ.Location = new System.Drawing.Point(10, 42);
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.ReadOnly = true;
            this.txtCPFCNPJ.Size = new System.Drawing.Size(280, 27);
            this.txtCPFCNPJ.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblNome.ForeColor = System.Drawing.Color.DimGray;
            this.lblNome.Location = new System.Drawing.Point(294, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblCPFCNPJ
            // 
            this.lblCPFCNPJ.AutoSize = true;
            this.lblCPFCNPJ.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblCPFCNPJ.ForeColor = System.Drawing.Color.DimGray;
            this.lblCPFCNPJ.Location = new System.Drawing.Point(9, 22);
            this.lblCPFCNPJ.Name = "lblCPFCNPJ";
            this.lblCPFCNPJ.Size = new System.Drawing.Size(37, 18);
            this.lblCPFCNPJ.TabIndex = 0;
            this.lblCPFCNPJ.Text = "CPF";
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.radioButton3);
            this.grpCliente.Controls.Add(this.rdbCPF);
            this.grpCliente.Controls.Add(this.txtCliente);
            this.grpCliente.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpCliente.ForeColor = System.Drawing.Color.DimGray;
            this.grpCliente.Location = new System.Drawing.Point(12, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(364, 59);
            this.grpCliente.TabIndex = 36;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Pesquisar Cliente";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(297, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 18);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Nome";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdbCPF
            // 
            this.rdbCPF.AutoSize = true;
            this.rdbCPF.Checked = true;
            this.rdbCPF.Location = new System.Drawing.Point(242, 25);
            this.rdbCPF.Name = "rdbCPF";
            this.rdbCPF.Size = new System.Drawing.Size(49, 18);
            this.rdbCPF.TabIndex = 2;
            this.rdbCPF.TabStop = true;
            this.rdbCPF.Text = "CPF";
            this.rdbCPF.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCliente.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtCliente.Location = new System.Drawing.Point(6, 21);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(230, 27);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.grdItens);
            this.grpProdutos.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpProdutos.ForeColor = System.Drawing.Color.DimGray;
            this.grpProdutos.Location = new System.Drawing.Point(13, 465);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Size = new System.Drawing.Size(751, 136);
            this.grpProdutos.TabIndex = 45;
            this.grpProdutos.TabStop = false;
            this.grpProdutos.Text = "Itens Adicionados";
            // 
            // grdItens
            // 
            this.grdItens.AllowUserToAddRows = false;
            this.grdItens.AllowUserToDeleteRows = false;
            this.grdItens.AllowUserToResizeColumns = false;
            this.grdItens.AllowUserToResizeRows = false;
            this.grdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItens.Location = new System.Drawing.Point(6, 19);
            this.grdItens.MultiSelect = false;
            this.grdItens.Name = "grdItens";
            this.grdItens.ReadOnly = true;
            this.grdItens.RowHeadersVisible = false;
            this.grdItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdItens.Size = new System.Drawing.Size(739, 108);
            this.grdItens.TabIndex = 2;
            // 
            // grpListaC
            // 
            this.grpListaC.Controls.Add(this.grdClientes);
            this.grpListaC.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpListaC.ForeColor = System.Drawing.Color.DimGray;
            this.grpListaC.Location = new System.Drawing.Point(12, 77);
            this.grpListaC.Name = "grpListaC";
            this.grpListaC.Size = new System.Drawing.Size(364, 183);
            this.grpListaC.TabIndex = 39;
            this.grpListaC.TabStop = false;
            this.grpListaC.Text = "Clientes Cadastrados";
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.AllowUserToResizeColumns = false;
            this.grdClientes.AllowUserToResizeRows = false;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(6, 19);
            this.grdClientes.MultiSelect = false;
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.RowHeadersVisible = false;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(352, 158);
            this.grdClientes.TabIndex = 0;
            this.grdClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellDoubleClick);
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnCliente.ForeColor = System.Drawing.Color.DimGray;
            this.btnCliente.Location = new System.Drawing.Point(13, 267);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(364, 54);
            this.btnCliente.TabIndex = 38;
            this.btnCliente.Text = "Selecionar &Cliente";
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblQuantidade.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantidade.Location = new System.Drawing.Point(407, 238);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 18);
            this.lblQuantidade.TabIndex = 43;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rdbSKU);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(400, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 59);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Produto";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 11F);
            this.radioButton1.ForeColor = System.Drawing.Color.DimGray;
            this.radioButton1.Location = new System.Drawing.Point(265, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 22);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Descrição";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbSKU
            // 
            this.rdbSKU.AutoSize = true;
            this.rdbSKU.Checked = true;
            this.rdbSKU.Font = new System.Drawing.Font("Verdana", 11F);
            this.rdbSKU.ForeColor = System.Drawing.Color.DimGray;
            this.rdbSKU.Location = new System.Drawing.Point(203, 23);
            this.rdbSKU.Name = "rdbSKU";
            this.rdbSKU.Size = new System.Drawing.Size(57, 22);
            this.rdbSKU.TabIndex = 2;
            this.rdbSKU.TabStop = true;
            this.rdbSKU.Text = "SKU";
            this.rdbSKU.UseVisualStyleBackColor = true;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.Control;
            this.txtProduto.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtProduto.ForeColor = System.Drawing.Color.DimGray;
            this.txtProduto.Location = new System.Drawing.Point(6, 21);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(191, 27);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // nudQtde
            // 
            this.nudQtde.Font = new System.Drawing.Font("Verdana", 11F);
            this.nudQtde.ForeColor = System.Drawing.Color.DimGray;
            this.nudQtde.Location = new System.Drawing.Point(505, 235);
            this.nudQtde.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.Size = new System.Drawing.Size(61, 25);
            this.nudQtde.TabIndex = 37;
            // 
            // grpListaP
            // 
            this.grpListaP.Controls.Add(this.grdProdutos);
            this.grpListaP.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpListaP.ForeColor = System.Drawing.Color.DimGray;
            this.grpListaP.Location = new System.Drawing.Point(399, 77);
            this.grpListaP.Name = "grpListaP";
            this.grpListaP.Size = new System.Drawing.Size(364, 152);
            this.grpListaP.TabIndex = 41;
            this.grpListaP.TabStop = false;
            this.grpListaP.Text = "Produtos Cadastrados";
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.AllowUserToResizeColumns = false;
            this.grdProdutos.AllowUserToResizeRows = false;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Location = new System.Drawing.Point(6, 21);
            this.grdProdutos.MultiSelect = false;
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.RowHeadersVisible = false;
            this.grdProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProdutos.Size = new System.Drawing.Size(352, 125);
            this.grdProdutos.TabIndex = 1;
            this.grdProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProdutos_CellDoubleClick);
            // 
            // btnProduto
            // 
            this.btnProduto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnProduto.ForeColor = System.Drawing.Color.DimGray;
            this.btnProduto.Location = new System.Drawing.Point(400, 267);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(364, 54);
            this.btnProduto.TabIndex = 42;
            this.btnProduto.Text = "Adicionar &Produto";
            this.btnProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(11)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(538, 610);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 42);
            this.btnLimpar.TabIndex = 62;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Location = new System.Drawing.Point(406, 610);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 42);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGravar.Location = new System.Drawing.Point(656, 610);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(108, 42);
            this.btnGravar.TabIndex = 61;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnRemover.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemover.Location = new System.Drawing.Point(19, 610);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(122, 42);
            this.btnRemover.TabIndex = 63;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // frmNovaVenda
            // 
            this.AcceptButton = this.btnGravar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(776, 664);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpNovaVenda);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpProdutos);
            this.Controls.Add(this.grpListaC);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudQtde);
            this.Controls.Add(this.grpListaP);
            this.Controls.Add(this.btnProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Nova Venda";
            this.Load += new System.EventHandler(this.frmNovaVenda_Load_1);
            this.grpNovaVenda.ResumeLayout(false);
            this.grpNovaVenda.PerformLayout();
            this.grpTotal.ResumeLayout(false);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdItens)).EndInit();
            this.grpListaC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            this.grpListaP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpNovaVenda;
        private System.Windows.Forms.TextBox txtDataEmissao;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCPFCNPJ;
        private System.Windows.Forms.Label lblCPFCNPJ;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdbCPF;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.DataGridView grdItens;
        private System.Windows.Forms.GroupBox grpListaC;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdbSKU;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.NumericUpDown nudQtde;
        private System.Windows.Forms.GroupBox grpListaP;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.ComboBox cboMetodoPagamento;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnRemover;
    }
}