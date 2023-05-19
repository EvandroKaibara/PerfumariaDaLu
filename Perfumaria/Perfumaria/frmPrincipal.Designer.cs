namespace Perfumaria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.setorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlteracao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrecoPorSetor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBancoDados = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastro,
            this.mnuVenda,
            this.mnuAlteracao,
            this.mnuEstoque,
            this.mnuSobre,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuClientes,
            this.mnuProdutos,
            this.setorToolStripMenuItem});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnuCadastro.Text = "&Cadastro";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("mnuUsuarios.Image")));
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuUsuarios.Size = new System.Drawing.Size(163, 22);
            this.mnuUsuarios.Text = "&Usuários";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuClientes
            // 
            this.mnuClientes.Image = ((System.Drawing.Image)(resources.GetObject("mnuClientes.Image")));
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuClientes.Size = new System.Drawing.Size(163, 22);
            this.mnuClientes.Text = "&Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // mnuProdutos
            // 
            this.mnuProdutos.Image = global::Perfumaria.Properties.Resources.produto;
            this.mnuProdutos.Name = "mnuProdutos";
            this.mnuProdutos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuProdutos.Size = new System.Drawing.Size(163, 22);
            this.mnuProdutos.Text = "&Produtos";
            this.mnuProdutos.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // setorToolStripMenuItem
            // 
            this.setorToolStripMenuItem.Image = global::Perfumaria.Properties.Resources.setor;
            this.setorToolStripMenuItem.Name = "setorToolStripMenuItem";
            this.setorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.setorToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.setorToolStripMenuItem.Text = "&Setores";
            this.setorToolStripMenuItem.Click += new System.EventHandler(this.setorToolStripMenuItem_Click);
            // 
            // mnuVenda
            // 
            this.mnuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNovaVenda,
            this.mnuConsultarVenda});
            this.mnuVenda.Name = "mnuVenda";
            this.mnuVenda.Size = new System.Drawing.Size(51, 20);
            this.mnuVenda.Text = "&Venda";
            // 
            // mnuNovaVenda
            // 
            this.mnuNovaVenda.Image = global::Perfumaria.Properties.Resources.nova_venda;
            this.mnuNovaVenda.Name = "mnuNovaVenda";
            this.mnuNovaVenda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNovaVenda.Size = new System.Drawing.Size(203, 22);
            this.mnuNovaVenda.Text = "&Nova Venda";
            this.mnuNovaVenda.Click += new System.EventHandler(this.novaVendaToolStripMenuItem_Click);
            // 
            // mnuConsultarVenda
            // 
            this.mnuConsultarVenda.Image = global::Perfumaria.Properties.Resources.consultar_venda;
            this.mnuConsultarVenda.Name = "mnuConsultarVenda";
            this.mnuConsultarVenda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuConsultarVenda.Size = new System.Drawing.Size(203, 22);
            this.mnuConsultarVenda.Text = "&Consultar Venda";
            this.mnuConsultarVenda.Click += new System.EventHandler(this.mnuConsultarVenda_Click);
            // 
            // mnuAlteracao
            // 
            this.mnuAlteracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrecoPorSetor});
            this.mnuAlteracao.Name = "mnuAlteracao";
            this.mnuAlteracao.Size = new System.Drawing.Size(69, 20);
            this.mnuAlteracao.Text = "&Alteração";
            // 
            // mnuPrecoPorSetor
            // 
            this.mnuPrecoPorSetor.Image = global::Perfumaria.Properties.Resources.preco_setor;
            this.mnuPrecoPorSetor.Name = "mnuPrecoPorSetor";
            this.mnuPrecoPorSetor.Size = new System.Drawing.Size(155, 22);
            this.mnuPrecoPorSetor.Text = "&Preço por Setor";
            this.mnuPrecoPorSetor.Click += new System.EventHandler(this.mnuPrecoPorSetor_Click);
            // 
            // mnuEstoque
            // 
            this.mnuEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEntrada,
            this.mnuConsultar});
            this.mnuEstoque.Name = "mnuEstoque";
            this.mnuEstoque.Size = new System.Drawing.Size(61, 20);
            this.mnuEstoque.Text = "&Estoque";
            // 
            // mnuEntrada
            // 
            this.mnuEntrada.Image = global::Perfumaria.Properties.Resources.entrada;
            this.mnuEntrada.Name = "mnuEntrada";
            this.mnuEntrada.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEntrada.Size = new System.Drawing.Size(165, 22);
            this.mnuEntrada.Text = "&Entrada";
            this.mnuEntrada.Click += new System.EventHandler(this.mnuEntrada_Click);
            // 
            // mnuConsultar
            // 
            this.mnuConsultar.Image = global::Perfumaria.Properties.Resources.consulta_entrada;
            this.mnuConsultar.Name = "mnuConsultar";
            this.mnuConsultar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuConsultar.Size = new System.Drawing.Size(165, 22);
            this.mnuConsultar.Text = "&Consultar";
            this.mnuConsultar.Click += new System.EventHandler(this.mnuConsultar_Click);
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(49, 20);
            this.mnuSobre.Text = "S&obre";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(38, 20);
            this.mnuSair.Text = "&Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblBancoDados,
            this.lblTempo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(261, 17);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = "Usuário:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBancoDados
            // 
            this.lblBancoDados.Name = "lblBancoDados";
            this.lblBancoDados.Size = new System.Drawing.Size(261, 17);
            this.lblBancoDados.Spring = true;
            this.lblBancoDados.Text = "Banco de Dados";
            // 
            // lblTempo
            // 
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(261, 17);
            this.lblTempo.Spring = true;
            this.lblTempo.Text = "00:00:00";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrTempo
            // 
            this.tmrTempo.Interval = 1000;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Perfumaria.Properties.Resources.bc;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Perfumaria da Lú";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblBancoDados;
        private System.Windows.Forms.ToolStripStatusLabel lblTempo;
        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuProdutos;
        private System.Windows.Forms.ToolStripMenuItem setorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuVenda;
        private System.Windows.Forms.ToolStripMenuItem mnuNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultarVenda;
        private System.Windows.Forms.ToolStripMenuItem mnuAlteracao;
        private System.Windows.Forms.ToolStripMenuItem mnuPrecoPorSetor;
        private System.Windows.Forms.ToolStripMenuItem mnuEstoque;
        private System.Windows.Forms.ToolStripMenuItem mnuEntrada;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultar;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
    }
}

