namespace Perfumaria
{
    partial class frmEntradaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradaEstoque));
            this.btnProduto = new System.Windows.Forms.Button();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.lblQtde = new System.Windows.Forms.Label();
            this.grpListaP = new System.Windows.Forms.GroupBox();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.rdbDescricao = new System.Windows.Forms.RadioButton();
            this.rdbSKU = new System.Windows.Forms.RadioButton();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtDataEmissao = new System.Windows.Forms.TextBox();
            this.grdEstoque = new System.Windows.Forms.DataGridView();
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            this.grpListaP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.grpProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstoque)).BeginInit();
            this.grpProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProduto
            // 
            this.btnProduto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnProduto.ForeColor = System.Drawing.Color.DimGray;
            this.btnProduto.Location = new System.Drawing.Point(19, 303);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(405, 44);
            this.btnProduto.TabIndex = 26;
            this.btnProduto.Text = "Selecionar &Produto";
            this.btnProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // nudQtde
            // 
            this.nudQtde.BackColor = System.Drawing.SystemColors.Control;
            this.nudQtde.Font = new System.Drawing.Font("Verdana", 9F);
            this.nudQtde.Location = new System.Drawing.Point(100, 273);
            this.nudQtde.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.Size = new System.Drawing.Size(69, 22);
            this.nudQtde.TabIndex = 25;
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblQtde.ForeColor = System.Drawing.Color.DimGray;
            this.lblQtde.Location = new System.Drawing.Point(18, 275);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(81, 14);
            this.lblQtde.TabIndex = 24;
            this.lblQtde.Text = "Quantidade";
            // 
            // grpListaP
            // 
            this.grpListaP.Controls.Add(this.grdProdutos);
            this.grpListaP.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpListaP.ForeColor = System.Drawing.Color.DimGray;
            this.grpListaP.Location = new System.Drawing.Point(12, 71);
            this.grpListaP.Name = "grpListaP";
            this.grpListaP.Size = new System.Drawing.Size(419, 195);
            this.grpListaP.TabIndex = 23;
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
            this.grdProdutos.Location = new System.Drawing.Point(6, 19);
            this.grdProdutos.MultiSelect = false;
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.RowHeadersVisible = false;
            this.grdProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProdutos.Size = new System.Drawing.Size(406, 170);
            this.grdProdutos.TabIndex = 0;
            // 
            // grpProduto
            // 
            this.grpProduto.Controls.Add(this.rdbDescricao);
            this.grpProduto.Controls.Add(this.rdbSKU);
            this.grpProduto.Controls.Add(this.txtProduto);
            this.grpProduto.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpProduto.ForeColor = System.Drawing.Color.DimGray;
            this.grpProduto.Location = new System.Drawing.Point(12, 12);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(419, 53);
            this.grpProduto.TabIndex = 22;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "Pesquisar por";
            // 
            // rdbDescricao
            // 
            this.rdbDescricao.AutoSize = true;
            this.rdbDescricao.Location = new System.Drawing.Point(310, 24);
            this.rdbDescricao.Name = "rdbDescricao";
            this.rdbDescricao.Size = new System.Drawing.Size(85, 18);
            this.rdbDescricao.TabIndex = 3;
            this.rdbDescricao.TabStop = true;
            this.rdbDescricao.Text = "Descrição";
            this.rdbDescricao.UseVisualStyleBackColor = true;
            // 
            // rdbSKU
            // 
            this.rdbSKU.AutoSize = true;
            this.rdbSKU.Checked = true;
            this.rdbSKU.Location = new System.Drawing.Point(257, 23);
            this.rdbSKU.Name = "rdbSKU";
            this.rdbSKU.Size = new System.Drawing.Size(50, 18);
            this.rdbSKU.TabIndex = 2;
            this.rdbSKU.TabStop = true;
            this.rdbSKU.Text = "SKU";
            this.rdbSKU.UseVisualStyleBackColor = true;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.Control;
            this.txtProduto.Location = new System.Drawing.Point(9, 21);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(242, 22);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblData.ForeColor = System.Drawing.Color.DimGray;
            this.lblData.Location = new System.Drawing.Point(177, 275);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(93, 14);
            this.lblData.TabIndex = 27;
            this.lblData.Text = "Data Emissão";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDataEmissao.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtDataEmissao.ForeColor = System.Drawing.Color.Black;
            this.txtDataEmissao.Location = new System.Drawing.Point(272, 272);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.ReadOnly = true;
            this.txtDataEmissao.Size = new System.Drawing.Size(152, 22);
            this.txtDataEmissao.TabIndex = 28;
            // 
            // grdEstoque
            // 
            this.grdEstoque.AllowUserToAddRows = false;
            this.grdEstoque.AllowUserToDeleteRows = false;
            this.grdEstoque.AllowUserToResizeColumns = false;
            this.grdEstoque.AllowUserToResizeRows = false;
            this.grdEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstoque.Location = new System.Drawing.Point(6, 19);
            this.grdEstoque.MultiSelect = false;
            this.grdEstoque.Name = "grdEstoque";
            this.grdEstoque.ReadOnly = true;
            this.grdEstoque.RowHeadersVisible = false;
            this.grdEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEstoque.Size = new System.Drawing.Size(406, 136);
            this.grdEstoque.TabIndex = 1;
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.grdEstoque);
            this.grpProdutos.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpProdutos.ForeColor = System.Drawing.Color.DimGray;
            this.grpProdutos.Location = new System.Drawing.Point(12, 352);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Size = new System.Drawing.Size(419, 161);
            this.grpProdutos.TabIndex = 29;
            this.grpProdutos.TabStop = false;
            this.grpProdutos.Text = "Produtos Adicionados";
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
            this.btnRemover.Location = new System.Drawing.Point(-318, 442);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(122, 42);
            this.btnRemover.TabIndex = 67;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(11)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(204, 519);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 42);
            this.btnLimpar.TabIndex = 66;
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
            this.btnCancelar.Location = new System.Drawing.Point(72, 519);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 42);
            this.btnCancelar.TabIndex = 64;
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
            this.btnGravar.Location = new System.Drawing.Point(322, 519);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(108, 42);
            this.btnGravar.TabIndex = 65;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // frmEntradaEstoque
            // 
            this.AcceptButton = this.btnGravar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(440, 570);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpProdutos);
            this.Controls.Add(this.txtDataEmissao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.nudQtde);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.grpListaP);
            this.Controls.Add(this.grpProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntradaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Estoque";
            this.Load += new System.EventHandler(this.frmEntradaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            this.grpListaP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstoque)).EndInit();
            this.grpProdutos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.NumericUpDown nudQtde;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.GroupBox grpListaP;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.RadioButton rdbDescricao;
        private System.Windows.Forms.RadioButton rdbSKU;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtDataEmissao;
        private System.Windows.Forms.DataGridView grdEstoque;
        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}