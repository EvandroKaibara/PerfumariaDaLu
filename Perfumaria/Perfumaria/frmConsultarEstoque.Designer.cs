namespace Perfumaria
{
    partial class frmConsultarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarEstoque));
            this.grpListaP = new System.Windows.Forms.GroupBox();
            this.btnLimparProduto = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.grpNotasFiscais = new System.Windows.Forms.GroupBox();
            this.grdEstoque = new System.Windows.Forms.DataGridView();
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.rdbDescricao = new System.Windows.Forms.RadioButton();
            this.rdbSKU = new System.Windows.Forms.RadioButton();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grpListaP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpNotasFiscais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstoque)).BeginInit();
            this.grpProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListaP
            // 
            this.grpListaP.Controls.Add(this.btnLimparProduto);
            this.grpListaP.Controls.Add(this.txtDescricao);
            this.grpListaP.Controls.Add(this.label5);
            this.grpListaP.Controls.Add(this.txtSKU);
            this.grpListaP.Controls.Add(this.label6);
            this.grpListaP.Controls.Add(this.grdProdutos);
            this.grpListaP.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.grpListaP.ForeColor = System.Drawing.Color.DimGray;
            this.grpListaP.Location = new System.Drawing.Point(12, 75);
            this.grpListaP.Name = "grpListaP";
            this.grpListaP.Size = new System.Drawing.Size(376, 245);
            this.grpListaP.TabIndex = 36;
            this.grpListaP.TabStop = false;
            this.grpListaP.Text = "Produtos Cadastrados";
            // 
            // btnLimparProduto
            // 
            this.btnLimparProduto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimparProduto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimparProduto.Location = new System.Drawing.Point(277, 155);
            this.btnLimparProduto.Name = "btnLimparProduto";
            this.btnLimparProduto.Size = new System.Drawing.Size(93, 84);
            this.btnLimparProduto.TabIndex = 38;
            this.btnLimparProduto.Text = "Limpar Produto";
            this.btnLimparProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLimparProduto.UseVisualStyleBackColor = true;
            this.btnLimparProduto.Click += new System.EventHandler(this.btnLimparProduto_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescricao.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Location = new System.Drawing.Point(6, 210);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(265, 27);
            this.txtDescricao.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(2, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Descrição";
            // 
            // txtSKU
            // 
            this.txtSKU.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSKU.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtSKU.ForeColor = System.Drawing.Color.Black;
            this.txtSKU.Location = new System.Drawing.Point(6, 155);
            this.txtSKU.MaxLength = 50;
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.ReadOnly = true;
            this.txtSKU.Size = new System.Drawing.Size(265, 27);
            this.txtSKU.TabIndex = 35;
            this.txtSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(3, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "SKU";
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
            this.grdProdutos.Size = new System.Drawing.Size(364, 107);
            this.grdProdutos.TabIndex = 0;
            this.grdProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProdutos_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTermino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 75);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Data de Emissão";
            // 
            // dtpTermino
            // 
            this.dtpTermino.Checked = false;
            this.dtpTermino.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTermino.Location = new System.Drawing.Point(193, 41);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.ShowCheckBox = true;
            this.dtpTermino.Size = new System.Drawing.Size(177, 27);
            this.dtpTermino.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(190, 20);
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
            this.dtpInicio.Location = new System.Drawing.Point(5, 41);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowCheckBox = true;
            this.dtpInicio.Size = new System.Drawing.Size(177, 27);
            this.dtpInicio.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(2, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Início";
            // 
            // grpNotasFiscais
            // 
            this.grpNotasFiscais.Controls.Add(this.grdEstoque);
            this.grpNotasFiscais.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.grpNotasFiscais.ForeColor = System.Drawing.Color.DimGray;
            this.grpNotasFiscais.Location = new System.Drawing.Point(398, 12);
            this.grpNotasFiscais.Name = "grpNotasFiscais";
            this.grpNotasFiscais.Size = new System.Drawing.Size(376, 443);
            this.grpNotasFiscais.TabIndex = 34;
            this.grpNotasFiscais.TabStop = false;
            this.grpNotasFiscais.Text = "Entradas de Estoque Encontradas";
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
            this.grdEstoque.Size = new System.Drawing.Size(364, 418);
            this.grdEstoque.TabIndex = 1;
            // 
            // grpProduto
            // 
            this.grpProduto.Controls.Add(this.rdbDescricao);
            this.grpProduto.Controls.Add(this.rdbSKU);
            this.grpProduto.Controls.Add(this.txtProduto);
            this.grpProduto.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.grpProduto.ForeColor = System.Drawing.Color.DimGray;
            this.grpProduto.Location = new System.Drawing.Point(12, 12);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(376, 57);
            this.grpProduto.TabIndex = 33;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "Pesquisar Produto";
            // 
            // rdbDescricao
            // 
            this.rdbDescricao.AutoSize = true;
            this.rdbDescricao.Font = new System.Drawing.Font("Verdana", 9F);
            this.rdbDescricao.ForeColor = System.Drawing.Color.DimGray;
            this.rdbDescricao.Location = new System.Drawing.Point(288, 25);
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
            this.rdbSKU.Font = new System.Drawing.Font("Verdana", 9F);
            this.rdbSKU.ForeColor = System.Drawing.Color.DimGray;
            this.rdbSKU.Location = new System.Drawing.Point(235, 25);
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
            this.txtProduto.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtProduto.ForeColor = System.Drawing.Color.DimGray;
            this.txtProduto.Location = new System.Drawing.Point(6, 21);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(223, 27);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(11)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(127, 409);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 42);
            this.btnLimpar.TabIndex = 68;
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
            this.btnCancelar.Location = new System.Drawing.Point(12, 409);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 42);
            this.btnCancelar.TabIndex = 66;
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
            this.btnPesquisar.Location = new System.Drawing.Point(242, 409);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(146, 42);
            this.btnPesquisar.TabIndex = 67;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmConsultarEstoque
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(786, 461);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grpListaP);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.grpNotasFiscais);
            this.Controls.Add(this.grpProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Estoque";
            this.Load += new System.EventHandler(this.frmConsultarEstoque_Load);
            this.grpListaP.ResumeLayout(false);
            this.grpListaP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpNotasFiscais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEstoque)).EndInit();
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpListaP;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpNotasFiscais;
        private System.Windows.Forms.DataGridView grdEstoque;
        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.RadioButton rdbDescricao;
        private System.Windows.Forms.RadioButton rdbSKU;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimparProduto;
    }
}