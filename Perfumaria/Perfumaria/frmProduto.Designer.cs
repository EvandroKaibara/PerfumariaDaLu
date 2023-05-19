namespace Perfumaria
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.btnImagem = new System.Windows.Forms.Button();
            this.cboSetor = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblSku = new System.Windows.Forms.Label();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.chkSetor = new System.Windows.Forms.CheckBox();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.lblImportado = new System.Windows.Forms.Label();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.grdNCM = new System.Windows.Forms.DataGridView();
            this.txtNCM = new System.Windows.Forms.TextBox();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.grpNCM = new System.Windows.Forms.GroupBox();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNCM)).BeginInit();
            this.grpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.grpNCM.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.btnImagem);
            this.grpDados.Controls.Add(this.cboSetor);
            this.grpDados.Controls.Add(this.txtQuantidade);
            this.grpDados.Controls.Add(this.lblSku);
            this.grpDados.Controls.Add(this.pctImagem);
            this.grpDados.Controls.Add(this.chkSetor);
            this.grpDados.Controls.Add(this.txtSku);
            this.grpDados.Controls.Add(this.lblSetor);
            this.grpDados.Controls.Add(this.lblDescricao);
            this.grpDados.Controls.Add(this.lblQuantidade);
            this.grpDados.Controls.Add(this.txtDescricao);
            this.grpDados.Controls.Add(this.lblValorUnitario);
            this.grpDados.Controls.Add(this.txtPrecoUnitario);
            this.grpDados.Controls.Add(this.lblImportado);
            this.grpDados.Controls.Add(this.rdbNao);
            this.grpDados.Controls.Add(this.rdbSim);
            this.grpDados.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDados.ForeColor = System.Drawing.Color.DimGray;
            this.grpDados.Location = new System.Drawing.Point(420, 12);
            this.grpDados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDados.Name = "grpDados";
            this.grpDados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDados.Size = new System.Drawing.Size(398, 325);
            this.grpDados.TabIndex = 20;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados para Cadastro";
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(251, 280);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(139, 38);
            this.btnImagem.TabIndex = 40;
            this.btnImagem.Text = "Selecione a Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // cboSetor
            // 
            this.cboSetor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSetor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSetor.BackColor = System.Drawing.SystemColors.Control;
            this.cboSetor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSetor.FormattingEnabled = true;
            this.cboSetor.Items.AddRange(new object[] {
            "awdih\thuiwagdua\t",
            "uahwdhioaw"});
            this.cboSetor.Location = new System.Drawing.Point(8, 93);
            this.cboSetor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSetor.Name = "cboSetor";
            this.cboSetor.Size = new System.Drawing.Size(209, 26);
            this.cboSetor.TabIndex = 35;
            this.cboSetor.SelectedIndexChanged += new System.EventHandler(this.cboSetor_SelectedIndexChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantidade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(8, 289);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantidade.MaxLength = 4;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(209, 27);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // lblSku
            // 
            this.lblSku.AutoSize = true;
            this.lblSku.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblSku.ForeColor = System.Drawing.Color.DimGray;
            this.lblSku.Location = new System.Drawing.Point(3, 19);
            this.lblSku.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(39, 18);
            this.lblSku.TabIndex = 20;
            this.lblSku.Text = "SKU";
            // 
            // pctImagem
            // 
            this.pctImagem.Image = global::Perfumaria.Properties.Resources.placeholder;
            this.pctImagem.Location = new System.Drawing.Point(251, 182);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(139, 92);
            this.pctImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImagem.TabIndex = 39;
            this.pctImagem.TabStop = false;
            // 
            // chkSetor
            // 
            this.chkSetor.AutoSize = true;
            this.chkSetor.Checked = true;
            this.chkSetor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSetor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSetor.ForeColor = System.Drawing.Color.DimGray;
            this.chkSetor.Location = new System.Drawing.Point(224, 95);
            this.chkSetor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSetor.Name = "chkSetor";
            this.chkSetor.Size = new System.Drawing.Size(111, 22);
            this.chkSetor.TabIndex = 2;
            this.chkSetor.Text = "Sem Setor";
            this.chkSetor.UseVisualStyleBackColor = true;
            this.chkSetor.CheckedChanged += new System.EventHandler(this.chkSetor_CheckedChanged);
            // 
            // txtSku
            // 
            this.txtSku.BackColor = System.Drawing.SystemColors.Control;
            this.txtSku.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSku.Location = new System.Drawing.Point(8, 39);
            this.txtSku.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSku.MaxLength = 15;
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(209, 27);
            this.txtSku.TabIndex = 0;
            this.txtSku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSku_KeyPress);
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblSetor.ForeColor = System.Drawing.Color.DimGray;
            this.lblSetor.Location = new System.Drawing.Point(6, 73);
            this.lblSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(49, 18);
            this.lblSetor.TabIndex = 27;
            this.lblSetor.Text = "Setor";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblDescricao.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescricao.Location = new System.Drawing.Point(6, 124);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 18);
            this.lblDescricao.TabIndex = 21;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AccessibleDescription = "";
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblQuantidade.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantidade.Location = new System.Drawing.Point(5, 269);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 18);
            this.lblQuantidade.TabIndex = 34;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescricao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(8, 144);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(382, 27);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AccessibleDescription = "";
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblValorUnitario.ForeColor = System.Drawing.Color.DimGray;
            this.lblValorUnitario.Location = new System.Drawing.Point(7, 177);
            this.lblValorUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(112, 18);
            this.lblValorUnitario.TabIndex = 25;
            this.lblValorUnitario.Text = "Preço Unitário";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecoUnitario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitario.Location = new System.Drawing.Point(8, 197);
            this.txtPrecoUnitario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecoUnitario.MaxLength = 8;
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(209, 27);
            this.txtPrecoUnitario.TabIndex = 4;
            this.txtPrecoUnitario.Enter += new System.EventHandler(this.txtPrecoUnitario_Enter);
            this.txtPrecoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoUnitario_KeyPress);
            this.txtPrecoUnitario.Leave += new System.EventHandler(this.txtPrecoUnitario_Leave);
            // 
            // lblImportado
            // 
            this.lblImportado.AccessibleDescription = "";
            this.lblImportado.AutoSize = true;
            this.lblImportado.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblImportado.ForeColor = System.Drawing.Color.DimGray;
            this.lblImportado.Location = new System.Drawing.Point(8, 238);
            this.lblImportado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImportado.Name = "lblImportado";
            this.lblImportado.Size = new System.Drawing.Size(94, 18);
            this.lblImportado.TabIndex = 31;
            this.lblImportado.Text = "Importado:";
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Checked = true;
            this.rdbNao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNao.ForeColor = System.Drawing.Color.DimGray;
            this.rdbNao.Location = new System.Drawing.Point(165, 237);
            this.rdbNao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(58, 22);
            this.rdbNao.TabIndex = 6;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSim.ForeColor = System.Drawing.Color.DimGray;
            this.rdbSim.Location = new System.Drawing.Point(104, 237);
            this.rdbSim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(56, 22);
            this.rdbSim.TabIndex = 5;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // grdNCM
            // 
            this.grdNCM.AllowUserToAddRows = false;
            this.grdNCM.AllowUserToDeleteRows = false;
            this.grdNCM.AllowUserToResizeColumns = false;
            this.grdNCM.AllowUserToResizeRows = false;
            this.grdNCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNCM.Location = new System.Drawing.Point(8, 57);
            this.grdNCM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grdNCM.MultiSelect = false;
            this.grdNCM.Name = "grdNCM";
            this.grdNCM.ReadOnly = true;
            this.grdNCM.RowHeadersVisible = false;
            this.grdNCM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNCM.Size = new System.Drawing.Size(382, 144);
            this.grdNCM.TabIndex = 0;
            this.grdNCM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNCM_CellClick);
            // 
            // txtNCM
            // 
            this.txtNCM.BackColor = System.Drawing.SystemColors.Control;
            this.txtNCM.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCM.Location = new System.Drawing.Point(8, 24);
            this.txtNCM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNCM.Name = "txtNCM";
            this.txtNCM.Size = new System.Drawing.Size(382, 27);
            this.txtNCM.TabIndex = 8;
            this.txtNCM.TextChanged += new System.EventHandler(this.txtNCM_TextChanged);
            this.txtNCM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNCM_KeyPress);
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdProdutos);
            this.grpLista.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLista.ForeColor = System.Drawing.Color.DimGray;
            this.grpLista.Location = new System.Drawing.Point(14, 78);
            this.grpLista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpLista.Name = "grpLista";
            this.grpLista.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpLista.Size = new System.Drawing.Size(398, 474);
            this.grpLista.TabIndex = 19;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Produtos Cadastrados";
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.AllowUserToResizeColumns = false;
            this.grdProdutos.AllowUserToResizeRows = false;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Location = new System.Drawing.Point(7, 19);
            this.grdProdutos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grdProdutos.MultiSelect = false;
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.RowHeadersVisible = false;
            this.grdProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProdutos.Size = new System.Drawing.Size(384, 449);
            this.grdProdutos.TabIndex = 0;
            this.grdProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProdutos_CellClick);
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisa.ForeColor = System.Drawing.Color.DimGray;
            this.grpPesquisa.Location = new System.Drawing.Point(14, 12);
            this.grpPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpPesquisa.Size = new System.Drawing.Size(398, 60);
            this.grpPesquisa.TabIndex = 18;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisar por";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesquisa.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtPesquisa.Location = new System.Drawing.Point(8, 22);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(382, 27);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGravar.Location = new System.Drawing.Point(710, 558);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(108, 42);
            this.btnGravar.TabIndex = 37;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Location = new System.Drawing.Point(460, 558);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 42);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(11)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(592, 558);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 42);
            this.btnLimpar.TabIndex = 38;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ofdImagem
            // 
            this.ofdImagem.FileName = "openFileDialog1";
            // 
            // grpNCM
            // 
            this.grpNCM.Controls.Add(this.txtNCM);
            this.grpNCM.Controls.Add(this.grdNCM);
            this.grpNCM.Font = new System.Drawing.Font("Verdana", 11F);
            this.grpNCM.ForeColor = System.Drawing.Color.DimGray;
            this.grpNCM.Location = new System.Drawing.Point(420, 345);
            this.grpNCM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpNCM.Name = "grpNCM";
            this.grpNCM.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpNCM.Size = new System.Drawing.Size(398, 207);
            this.grpNCM.TabIndex = 39;
            this.grpNCM.TabStop = false;
            this.grpNCM.Text = "NCM";
            // 
            // frmProduto
            // 
            this.AcceptButton = this.btnGravar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(832, 612);
            this.Controls.Add(this.grpNCM);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.grpDados);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNCM)).EndInit();
            this.grpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpNCM.ResumeLayout(false);
            this.grpNCM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblImportado;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtNCM;
        private System.Windows.Forms.DataGridView grdNCM;
        private System.Windows.Forms.CheckBox chkSetor;
        private System.Windows.Forms.ComboBox cboSetor;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private System.Windows.Forms.GroupBox grpNCM;
    }
}