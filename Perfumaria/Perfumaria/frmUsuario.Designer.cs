namespace Perfumaria
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.pcbOlho_2 = new System.Windows.Forms.PictureBox();
            this.pcbOlho_1 = new System.Windows.Forms.PictureBox();
            this.txtConfirmacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOlho_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOlho_1)).BeginInit();
            this.grpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.pcbOlho_2);
            this.grpDados.Controls.Add(this.pcbOlho_1);
            this.grpDados.Controls.Add(this.txtConfirmacao);
            this.grpDados.Controls.Add(this.label5);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Controls.Add(this.label2);
            this.grpDados.Controls.Add(this.txtUsuario);
            this.grpDados.Controls.Add(this.label4);
            this.grpDados.Controls.Add(this.txtSenha);
            this.grpDados.Controls.Add(this.label3);
            this.grpDados.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpDados.ForeColor = System.Drawing.Color.DimGray;
            this.grpDados.Location = new System.Drawing.Point(12, 292);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(434, 183);
            this.grpDados.TabIndex = 5;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados para Cadastro";
            // 
            // pcbOlho_2
            // 
            this.pcbOlho_2.BackColor = System.Drawing.SystemColors.Control;
            this.pcbOlho_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbOlho_2.Image = ((System.Drawing.Image)(resources.GetObject("pcbOlho_2.Image")));
            this.pcbOlho_2.Location = new System.Drawing.Point(399, 146);
            this.pcbOlho_2.Name = "pcbOlho_2";
            this.pcbOlho_2.Size = new System.Drawing.Size(26, 21);
            this.pcbOlho_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOlho_2.TabIndex = 51;
            this.pcbOlho_2.TabStop = false;
            this.pcbOlho_2.Click += new System.EventHandler(this.pcbOlho_2_Click);
            // 
            // pcbOlho_1
            // 
            this.pcbOlho_1.BackColor = System.Drawing.SystemColors.Control;
            this.pcbOlho_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbOlho_1.Image = ((System.Drawing.Image)(resources.GetObject("pcbOlho_1.Image")));
            this.pcbOlho_1.Location = new System.Drawing.Point(184, 146);
            this.pcbOlho_1.Name = "pcbOlho_1";
            this.pcbOlho_1.Size = new System.Drawing.Size(26, 21);
            this.pcbOlho_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOlho_1.TabIndex = 50;
            this.pcbOlho_1.TabStop = false;
            this.pcbOlho_1.Click += new System.EventHandler(this.pcbOlho_1_Click);
            // 
            // txtConfirmacao
            // 
            this.txtConfirmacao.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirmacao.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtConfirmacao.Location = new System.Drawing.Point(221, 143);
            this.txtConfirmacao.MaxLength = 50;
            this.txtConfirmacao.Name = "txtConfirmacao";
            this.txtConfirmacao.Size = new System.Drawing.Size(207, 27);
            this.txtConfirmacao.TabIndex = 21;
            this.txtConfirmacao.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11F);
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNome.Location = new System.Drawing.Point(6, 90);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(422, 27);
            this.txtNome.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(6, 38);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(422, 27);
            this.txtUsuario.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F);
            this.label4.Location = new System.Drawing.Point(218, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirmação";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtSenha.Location = new System.Drawing.Point(6, 143);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(207, 27);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Senha";
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdUsuarios);
            this.grpLista.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpLista.ForeColor = System.Drawing.Color.DimGray;
            this.grpLista.Location = new System.Drawing.Point(12, 71);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(434, 215);
            this.grpLista.TabIndex = 4;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Usuários Cadastrados";
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUserToAddRows = false;
            this.grdUsuarios.AllowUserToDeleteRows = false;
            this.grdUsuarios.AllowUserToResizeColumns = false;
            this.grdUsuarios.AllowUserToResizeRows = false;
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Location = new System.Drawing.Point(6, 19);
            this.grdUsuarios.MultiSelect = false;
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            this.grdUsuarios.RowHeadersVisible = false;
            this.grdUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsuarios.Size = new System.Drawing.Size(422, 190);
            this.grdUsuarios.TabIndex = 0;
            this.grdUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuarios_CellClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(168)))), ((int)(((byte)(11)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(220, 481);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 42);
            this.btnLimpar.TabIndex = 49;
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
            this.btnCancelar.Location = new System.Drawing.Point(88, 481);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 42);
            this.btnCancelar.TabIndex = 47;
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
            this.btnGravar.Location = new System.Drawing.Point(338, 481);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(108, 42);
            this.btnGravar.TabIndex = 48;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpPesquisa.ForeColor = System.Drawing.Color.DimGray;
            this.grpPesquisa.Location = new System.Drawing.Point(12, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(434, 53);
            this.grpPesquisa.TabIndex = 3;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisar por";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesquisa.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtPesquisa.Location = new System.Drawing.Point(6, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(422, 27);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // frmUsuario
            // 
            this.AcceptButton = this.btnGravar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(461, 541);
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
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOlho_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOlho_1)).EndInit();
            this.grpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.TextBox txtConfirmacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.PictureBox pcbOlho_2;
        private System.Windows.Forms.PictureBox pcbOlho_1;
    }
}