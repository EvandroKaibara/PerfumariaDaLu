namespace Perfumaria
{
    partial class frmAlterarSetor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarSetor));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.grpMetodo = new System.Windows.Forms.GroupBox();
            this.rdbPorcentagem = new System.Windows.Forms.RadioButton();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lvlValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.grdSetores = new System.Windows.Forms.DataGridView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.grpDados.SuspendLayout();
            this.grpMetodo.SuspendLayout();
            this.grpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSetores)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(11)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(219, 435);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 42);
            this.btnLimpar.TabIndex = 59;
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
            this.btnCancelar.Location = new System.Drawing.Point(87, 435);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 42);
            this.btnCancelar.TabIndex = 57;
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
            this.btnGravar.Location = new System.Drawing.Point(337, 435);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(108, 42);
            this.btnGravar.TabIndex = 58;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.grpMetodo);
            this.grpDados.Controls.Add(this.txtValor);
            this.grpDados.Controls.Add(this.lvlValor);
            this.grpDados.Controls.Add(this.lblDescricao);
            this.grpDados.Controls.Add(this.txtDescricao);
            this.grpDados.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpDados.ForeColor = System.Drawing.Color.DimGray;
            this.grpDados.Location = new System.Drawing.Point(11, 292);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(434, 134);
            this.grpDados.TabIndex = 56;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados para Cadastro";
            // 
            // grpMetodo
            // 
            this.grpMetodo.Controls.Add(this.rdbPorcentagem);
            this.grpMetodo.Controls.Add(this.rdbAdicao);
            this.grpMetodo.ForeColor = System.Drawing.Color.Gray;
            this.grpMetodo.Location = new System.Drawing.Point(160, 75);
            this.grpMetodo.Name = "grpMetodo";
            this.grpMetodo.Size = new System.Drawing.Size(267, 51);
            this.grpMetodo.TabIndex = 28;
            this.grpMetodo.TabStop = false;
            this.grpMetodo.Text = "Método de Alteração";
            // 
            // rdbPorcentagem
            // 
            this.rdbPorcentagem.AutoSize = true;
            this.rdbPorcentagem.Location = new System.Drawing.Point(116, 25);
            this.rdbPorcentagem.Name = "rdbPorcentagem";
            this.rdbPorcentagem.Size = new System.Drawing.Size(135, 18);
            this.rdbPorcentagem.TabIndex = 21;
            this.rdbPorcentagem.Text = "Porcentagem [%]";
            this.rdbPorcentagem.UseVisualStyleBackColor = true;
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Checked = true;
            this.rdbAdicao.Location = new System.Drawing.Point(19, 25);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(83, 18);
            this.rdbAdicao.TabIndex = 22;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "Fixo [+/-]";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Control;
            this.txtValor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(5, 95);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValor.MaxLength = 100;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(148, 27);
            this.txtValor.TabIndex = 26;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lvlValor
            // 
            this.lvlValor.AccessibleDescription = "";
            this.lvlValor.AutoSize = true;
            this.lvlValor.Font = new System.Drawing.Font("Verdana", 11F);
            this.lvlValor.ForeColor = System.Drawing.Color.DimGray;
            this.lvlValor.Location = new System.Drawing.Point(6, 75);
            this.lvlValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlValor.Name = "lvlValor";
            this.lvlValor.Size = new System.Drawing.Size(45, 18);
            this.lvlValor.TabIndex = 27;
            this.lvlValor.Text = "Valor";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblDescricao.Location = new System.Drawing.Point(3, 21);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(143, 18);
            this.lblDescricao.TabIndex = 20;
            this.lblDescricao.Text = "Setor Selecionado";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescricao.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(5, 42);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(422, 27);
            this.txtDescricao.TabIndex = 14;
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdSetores);
            this.grpLista.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpLista.ForeColor = System.Drawing.Color.DimGray;
            this.grpLista.Location = new System.Drawing.Point(11, 71);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(434, 215);
            this.grpLista.TabIndex = 55;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Setores Cadastrados";
            // 
            // grdSetores
            // 
            this.grdSetores.AllowUserToAddRows = false;
            this.grdSetores.AllowUserToDeleteRows = false;
            this.grdSetores.AllowUserToResizeColumns = false;
            this.grdSetores.AllowUserToResizeRows = false;
            this.grdSetores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSetores.Location = new System.Drawing.Point(5, 19);
            this.grdSetores.MultiSelect = false;
            this.grdSetores.Name = "grdSetores";
            this.grdSetores.ReadOnly = true;
            this.grdSetores.RowHeadersVisible = false;
            this.grdSetores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSetores.Size = new System.Drawing.Size(422, 190);
            this.grdSetores.TabIndex = 0;
            this.grdSetores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSetores_CellClick);
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpPesquisa.ForeColor = System.Drawing.Color.DimGray;
            this.grpPesquisa.Location = new System.Drawing.Point(11, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(434, 53);
            this.grpPesquisa.TabIndex = 54;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisar por";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesquisa.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(5, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(422, 27);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // frmAlterarSetor
            // 
            this.AcceptButton = this.btnGravar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(456, 486);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarSetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Preço por Setor";
            this.Load += new System.EventHandler(this.frmAlterarSetor_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpMetodo.ResumeLayout(false);
            this.grpMetodo.PerformLayout();
            this.grpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSetores)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.DataGridView grdSetores;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbPorcentagem;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lvlValor;
        private System.Windows.Forms.GroupBox grpMetodo;
    }
}