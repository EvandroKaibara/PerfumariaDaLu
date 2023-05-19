namespace Perfumaria
{
    partial class frmConsultarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarVenda));
            this.grpNotasFiscais = new System.Windows.Forms.GroupBox();
            this.grdVenda = new System.Windows.Forms.DataGridView();
            this.grpEntradaEstoque = new System.Windows.Forms.GroupBox();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.txtDataEmissao = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteCPFCNPJ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.grpNotaFiscal = new System.Windows.Forms.GroupBox();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpListaC = new System.Windows.Forms.GroupBox();
            this.btnLimparCliente = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCPF = new System.Windows.Forms.RadioButton();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grpNotasFiscais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVenda)).BeginInit();
            this.grpEntradaEstoque.SuspendLayout();
            this.grpTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpNotaFiscal.SuspendLayout();
            this.grpListaC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.grpCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNotasFiscais
            // 
            this.grpNotasFiscais.Controls.Add(this.grdVenda);
            this.grpNotasFiscais.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.grpNotasFiscais.ForeColor = System.Drawing.Color.DimGray;
            this.grpNotasFiscais.Location = new System.Drawing.Point(391, 11);
            this.grpNotasFiscais.Name = "grpNotasFiscais";
            this.grpNotasFiscais.Size = new System.Drawing.Size(634, 203);
            this.grpNotasFiscais.TabIndex = 46;
            this.grpNotasFiscais.TabStop = false;
            this.grpNotasFiscais.Text = "Notas Fiscais Encontradas";
            // 
            // grdVenda
            // 
            this.grdVenda.AllowUserToAddRows = false;
            this.grdVenda.AllowUserToDeleteRows = false;
            this.grdVenda.AllowUserToResizeColumns = false;
            this.grdVenda.AllowUserToResizeRows = false;
            this.grdVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVenda.Location = new System.Drawing.Point(6, 18);
            this.grdVenda.MultiSelect = false;
            this.grdVenda.Name = "grdVenda";
            this.grdVenda.ReadOnly = true;
            this.grdVenda.RowHeadersVisible = false;
            this.grdVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVenda.Size = new System.Drawing.Size(622, 176);
            this.grdVenda.TabIndex = 1;
            this.grdVenda.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVenda_CellDoubleClick);
            // 
            // grpEntradaEstoque
            // 
            this.grpEntradaEstoque.Controls.Add(this.grpTotal);
            this.grpEntradaEstoque.Controls.Add(this.grdProdutos);
            this.grpEntradaEstoque.Controls.Add(this.txtDataEmissao);
            this.grpEntradaEstoque.Controls.Add(this.txtNumero);
            this.grpEntradaEstoque.Controls.Add(this.lblNotaFiscal);
            this.grpEntradaEstoque.Controls.Add(this.lblData);
            this.grpEntradaEstoque.Controls.Add(this.txtNomeCliente);
            this.grpEntradaEstoque.Controls.Add(this.label1);
            this.grpEntradaEstoque.Controls.Add(this.txtClienteCPFCNPJ);
            this.grpEntradaEstoque.Controls.Add(this.label5);
            this.grpEntradaEstoque.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.grpEntradaEstoque.ForeColor = System.Drawing.Color.DimGray;
            this.grpEntradaEstoque.Location = new System.Drawing.Point(391, 222);
            this.grpEntradaEstoque.Name = "grpEntradaEstoque";
            this.grpEntradaEstoque.Size = new System.Drawing.Size(634, 319);
            this.grpEntradaEstoque.TabIndex = 43;
            this.grpEntradaEstoque.TabStop = false;
            this.grpEntradaEstoque.Text = "Dados Nota Fiscal";
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.lblValorTotal);
            this.grpTotal.Font = new System.Drawing.Font("Verdana", 11F);
            this.grpTotal.ForeColor = System.Drawing.Color.Gray;
            this.grpTotal.Location = new System.Drawing.Point(431, 72);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(197, 46);
            this.grpTotal.TabIndex = 15;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Valor Total";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblValorTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblValorTotal.Location = new System.Drawing.Point(9, 19);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(182, 21);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.Text = "R$ 0,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.AllowUserToResizeColumns = false;
            this.grdProdutos.AllowUserToResizeRows = false;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Location = new System.Drawing.Point(6, 128);
            this.grdProdutos.MultiSelect = false;
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.RowHeadersVisible = false;
            this.grdProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProdutos.Size = new System.Drawing.Size(622, 183);
            this.grdProdutos.TabIndex = 14;
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDataEmissao.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtDataEmissao.Location = new System.Drawing.Point(216, 91);
            this.txtDataEmissao.MaxLength = 50;
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.ReadOnly = true;
            this.txtDataEmissao.Size = new System.Drawing.Size(209, 27);
            this.txtDataEmissao.TabIndex = 13;
            this.txtDataEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumero.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNumero.Location = new System.Drawing.Point(6, 91);
            this.txtNumero.MaxLength = 20;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(204, 27);
            this.txtNumero.TabIndex = 12;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblNotaFiscal.Location = new System.Drawing.Point(4, 71);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(113, 18);
            this.lblNotaFiscal.TabIndex = 11;
            this.lblNotaFiscal.Text = "Nº Nota Fiscal";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblData.Location = new System.Drawing.Point(213, 71);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(110, 18);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data Emissão";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNomeCliente.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNomeCliente.Location = new System.Drawing.Point(216, 39);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(412, 27);
            this.txtNomeCliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.Location = new System.Drawing.Point(212, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // txtClienteCPFCNPJ
            // 
            this.txtClienteCPFCNPJ.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtClienteCPFCNPJ.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtClienteCPFCNPJ.Location = new System.Drawing.Point(6, 39);
            this.txtClienteCPFCNPJ.MaxLength = 50;
            this.txtClienteCPFCNPJ.Name = "txtClienteCPFCNPJ";
            this.txtClienteCPFCNPJ.ReadOnly = true;
            this.txtClienteCPFCNPJ.Size = new System.Drawing.Size(204, 27);
            this.txtClienteCPFCNPJ.TabIndex = 5;
            this.txtClienteCPFCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11F);
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTermino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(9, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 79);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Data de Emissão";
            // 
            // dtpTermino
            // 
            this.dtpTermino.Checked = false;
            this.dtpTermino.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTermino.Location = new System.Drawing.Point(193, 43);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.ShowCheckBox = true;
            this.dtpTermino.Size = new System.Drawing.Size(177, 27);
            this.dtpTermino.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F);
            this.label4.Location = new System.Drawing.Point(192, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Término";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Checked = false;
            this.dtpInicio.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(6, 43);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowCheckBox = true;
            this.dtpInicio.Size = new System.Drawing.Size(177, 27);
            this.dtpInicio.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Início";
            // 
            // grpNotaFiscal
            // 
            this.grpNotaFiscal.Controls.Add(this.txtNotaFiscal);
            this.grpNotaFiscal.Controls.Add(this.label2);
            this.grpNotaFiscal.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.grpNotaFiscal.ForeColor = System.Drawing.Color.DimGray;
            this.grpNotaFiscal.Location = new System.Drawing.Point(9, 320);
            this.grpNotaFiscal.Name = "grpNotaFiscal";
            this.grpNotaFiscal.Size = new System.Drawing.Size(376, 87);
            this.grpNotaFiscal.TabIndex = 40;
            this.grpNotaFiscal.TabStop = false;
            this.grpNotaFiscal.Text = "Pesquisar Nota Fiscal";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.BackColor = System.Drawing.SystemColors.Control;
            this.txtNotaFiscal.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNotaFiscal.Location = new System.Drawing.Point(6, 44);
            this.txtNotaFiscal.MaxLength = 20;
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(364, 27);
            this.txtNotaFiscal.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Número";
            // 
            // grpListaC
            // 
            this.grpListaC.Controls.Add(this.btnLimparCliente);
            this.grpListaC.Controls.Add(this.txtNome);
            this.grpListaC.Controls.Add(this.lblNome);
            this.grpListaC.Controls.Add(this.txtCPF);
            this.grpListaC.Controls.Add(this.lblCPF);
            this.grpListaC.Controls.Add(this.grdClientes);
            this.grpListaC.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.grpListaC.ForeColor = System.Drawing.Color.DimGray;
            this.grpListaC.Location = new System.Drawing.Point(9, 70);
            this.grpListaC.Name = "grpListaC";
            this.grpListaC.Size = new System.Drawing.Size(376, 244);
            this.grpListaC.TabIndex = 39;
            this.grpListaC.TabStop = false;
            this.grpListaC.Text = "Clientes Cadastrados";
            // 
            // btnLimparCliente
            // 
            this.btnLimparCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimparCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimparCliente.Location = new System.Drawing.Point(277, 148);
            this.btnLimparCliente.Name = "btnLimparCliente";
            this.btnLimparCliente.Size = new System.Drawing.Size(93, 84);
            this.btnLimparCliente.TabIndex = 37;
            this.btnLimparCliente.Text = "Limpar Cliente";
            this.btnLimparCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLimparCliente.UseVisualStyleBackColor = true;
            this.btnLimparCliente.Click += new System.EventHandler(this.btnLimparCliente_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNome.Location = new System.Drawing.Point(6, 204);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(265, 27);
            this.txtNome.TabIndex = 36;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblNome.Location = new System.Drawing.Point(3, 184);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 35;
            this.lblNome.Text = "Nome";
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCPF.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtCPF.Location = new System.Drawing.Point(6, 150);
            this.txtCPF.MaxLength = 50;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(265, 27);
            this.txtCPF.TabIndex = 34;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblCPF.Location = new System.Drawing.Point(2, 130);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 18);
            this.lblCPF.TabIndex = 33;
            this.lblCPF.Text = "CPF";
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.AllowUserToResizeColumns = false;
            this.grdClientes.AllowUserToResizeRows = false;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(6, 18);
            this.grdClientes.MultiSelect = false;
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.RowHeadersVisible = false;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(364, 107);
            this.grdClientes.TabIndex = 0;
            this.grdClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellDoubleClick);
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.rdbNome);
            this.grpCliente.Controls.Add(this.rdbCPF);
            this.grpCliente.Controls.Add(this.txtCliente);
            this.grpCliente.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.grpCliente.ForeColor = System.Drawing.Color.DimGray;
            this.grpCliente.Location = new System.Drawing.Point(9, 11);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(376, 53);
            this.grpCliente.TabIndex = 38;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Pesquisar Cliente";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Font = new System.Drawing.Font("Verdana", 11F);
            this.rdbNome.Location = new System.Drawing.Point(299, 19);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(71, 22);
            this.rdbNome.TabIndex = 3;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // rdbCPF
            // 
            this.rdbCPF.AutoSize = true;
            this.rdbCPF.Checked = true;
            this.rdbCPF.Font = new System.Drawing.Font("Verdana", 11F);
            this.rdbCPF.Location = new System.Drawing.Point(238, 19);
            this.rdbCPF.Name = "rdbCPF";
            this.rdbCPF.Size = new System.Drawing.Size(55, 22);
            this.rdbCPF.TabIndex = 2;
            this.rdbCPF.TabStop = true;
            this.rdbCPF.Text = "CPF";
            this.rdbCPF.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCliente.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtCliente.Location = new System.Drawing.Point(6, 17);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(226, 27);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(11)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(124, 498);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 42);
            this.btnLimpar.TabIndex = 65;
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
            this.btnCancelar.Location = new System.Drawing.Point(9, 498);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 42);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Image = global::Perfumaria.Properties.Resources.procura;
            this.btnPesquisar.Location = new System.Drawing.Point(239, 498);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(146, 42);
            this.btnPesquisar.TabIndex = 64;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmConsultarVenda
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1040, 553);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpNotasFiscais);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.grpEntradaEstoque);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpNotaFiscal);
            this.Controls.Add(this.grpListaC);
            this.Controls.Add(this.grpCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Venda";
            this.Load += new System.EventHandler(this.frmConsultarVenda_Load);
            this.grpNotasFiscais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVenda)).EndInit();
            this.grpEntradaEstoque.ResumeLayout(false);
            this.grpEntradaEstoque.PerformLayout();
            this.grpTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpNotaFiscal.ResumeLayout(false);
            this.grpNotaFiscal.PerformLayout();
            this.grpListaC.ResumeLayout(false);
            this.grpListaC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNotasFiscais;
        private System.Windows.Forms.DataGridView grdVenda;
        private System.Windows.Forms.GroupBox grpEntradaEstoque;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.TextBox txtDataEmissao;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClienteCPFCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpNotaFiscal;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpListaC;
        private System.Windows.Forms.Button btnLimparCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCPF;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}