namespace Perfumaria
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.grdPesquisa = new System.Windows.Forms.DataGridView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDados.SuspendLayout();
            this.grpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisa)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.txtTelefone);
            this.grpDados.Controls.Add(this.txtCPF);
            this.grpDados.Controls.Add(this.lblCPF);
            this.grpDados.Controls.Add(this.lblTelefone);
            this.grpDados.Controls.Add(this.label5);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Controls.Add(this.cboUF);
            this.grpDados.Controls.Add(this.lblUF);
            this.grpDados.Controls.Add(this.lblEndereco);
            this.grpDados.Controls.Add(this.txtEndereco);
            this.grpDados.Controls.Add(this.lblNumero);
            this.grpDados.Controls.Add(this.txtNumero);
            this.grpDados.Controls.Add(this.cboCidade);
            this.grpDados.Controls.Add(this.txtComplemento);
            this.grpDados.Controls.Add(this.lblCidade);
            this.grpDados.Controls.Add(this.lblComplemento);
            this.grpDados.Controls.Add(this.txtBairro);
            this.grpDados.Controls.Add(this.txtCEP);
            this.grpDados.Controls.Add(this.lblCEP);
            this.grpDados.Controls.Add(this.lblBairro);
            this.grpDados.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpDados.ForeColor = System.Drawing.Color.DimGray;
            this.grpDados.Location = new System.Drawing.Point(12, 260);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(457, 398);
            this.grpDados.TabIndex = 11;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados para Cadastro";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(6, 359);
            this.txtTelefone.MaxLength = 20;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(220, 27);
            this.txtTelefone.TabIndex = 40;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPF.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(6, 94);
            this.txtCPF.MaxLength = 20;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(227, 27);
            this.txtCPF.TabIndex = 22;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblCPF.Location = new System.Drawing.Point(6, 72);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 18);
            this.lblCPF.TabIndex = 21;
            this.lblCPF.Text = "CPF";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblTelefone.ForeColor = System.Drawing.Color.DimGray;
            this.lblTelefone.Location = new System.Drawing.Point(6, 338);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(69, 18);
            this.lblTelefone.TabIndex = 39;
            this.lblTelefone.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11F);
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(6, 42);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(445, 27);
            this.txtNome.TabIndex = 14;
            // 
            // cboUF
            // 
            this.cboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUF.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(336, 306);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(115, 26);
            this.cboUF.TabIndex = 38;
            this.cboUF.SelectedIndexChanged += new System.EventHandler(this.cboUF_SelectedIndexChanged);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblUF.ForeColor = System.Drawing.Color.DimGray;
            this.lblUF.Location = new System.Drawing.Point(335, 288);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(28, 18);
            this.lblUF.TabIndex = 37;
            this.lblUF.Text = "UF";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblEndereco.ForeColor = System.Drawing.Color.DimGray;
            this.lblEndereco.Location = new System.Drawing.Point(6, 126);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 18);
            this.lblEndereco.TabIndex = 25;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Control;
            this.txtEndereco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(6, 146);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(445, 27);
            this.txtEndereco.TabIndex = 26;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblNumero.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumero.Location = new System.Drawing.Point(6, 179);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(27, 18);
            this.lblNumero.TabIndex = 28;
            this.lblNumero.Text = "N°";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(6, 198);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(56, 27);
            this.txtNumero.TabIndex = 29;
            // 
            // cboCidade
            // 
            this.cboCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCidade.BackColor = System.Drawing.SystemColors.Control;
            this.cboCidade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(6, 306);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(324, 26);
            this.cboCidade.TabIndex = 36;
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.SystemColors.Control;
            this.txtComplemento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(68, 198);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(383, 27);
            this.txtComplemento.TabIndex = 30;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblCidade.ForeColor = System.Drawing.Color.DimGray;
            this.lblCidade.Location = new System.Drawing.Point(5, 285);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 18);
            this.lblCidade.TabIndex = 35;
            this.lblCidade.Text = "Cidade";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblComplemento.ForeColor = System.Drawing.Color.DimGray;
            this.lblComplemento.Location = new System.Drawing.Point(69, 177);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(114, 18);
            this.lblComplemento.TabIndex = 27;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Control;
            this.txtBairro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(6, 252);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(220, 27);
            this.txtBairro.TabIndex = 32;
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.SystemColors.Control;
            this.txtCEP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(232, 252);
            this.txtCEP.MaxLength = 8;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(219, 27);
            this.txtCEP.TabIndex = 34;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblCEP.ForeColor = System.Drawing.Color.DimGray;
            this.lblCEP.Location = new System.Drawing.Point(229, 233);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(37, 18);
            this.lblCEP.TabIndex = 33;
            this.lblCEP.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblBairro.ForeColor = System.Drawing.Color.DimGray;
            this.lblBairro.Location = new System.Drawing.Point(6, 231);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(52, 18);
            this.lblBairro.TabIndex = 31;
            this.lblBairro.Text = "Bairro";
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdPesquisa);
            this.grpLista.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpLista.ForeColor = System.Drawing.Color.DimGray;
            this.grpLista.Location = new System.Drawing.Point(12, 76);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(457, 178);
            this.grpLista.TabIndex = 10;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Clientes Cadastrados";
            // 
            // grdPesquisa
            // 
            this.grdPesquisa.AllowUserToAddRows = false;
            this.grdPesquisa.AllowUserToDeleteRows = false;
            this.grdPesquisa.AllowUserToResizeColumns = false;
            this.grdPesquisa.AllowUserToResizeRows = false;
            this.grdPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPesquisa.Location = new System.Drawing.Point(6, 19);
            this.grdPesquisa.MultiSelect = false;
            this.grdPesquisa.Name = "grdPesquisa";
            this.grdPesquisa.ReadOnly = true;
            this.grdPesquisa.RowHeadersVisible = false;
            this.grdPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPesquisa.Size = new System.Drawing.Size(445, 148);
            this.grdPesquisa.TabIndex = 0;
            this.grdPesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPesquisa_CellClick);
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpPesquisa.ForeColor = System.Drawing.Color.DimGray;
            this.grpPesquisa.Location = new System.Drawing.Point(12, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(457, 58);
            this.grpPesquisa.TabIndex = 9;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisar por";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesquisa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(9, 20);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(442, 27);
            this.txtPesquisa.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(11)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(243, 668);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 42);
            this.btnLimpar.TabIndex = 43;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGravar.Location = new System.Drawing.Point(361, 668);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(108, 42);
            this.btnGravar.TabIndex = 42;
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
            this.btnCancelar.Location = new System.Drawing.Point(111, 668);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 42);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCliente
            // 
            this.AcceptButton = this.btnGravar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(481, 723);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisa)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.DataGridView grdPesquisa;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}