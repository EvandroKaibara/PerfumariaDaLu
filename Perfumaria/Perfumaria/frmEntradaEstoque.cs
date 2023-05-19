using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfumaria
{
    public partial class frmEntradaEstoque : Form
    {
        public frmEntradaEstoque()
        {
            InitializeComponent();
        }

        Produto produto = new Produto();
        Estoque estoque = new Estoque();

        private void ConfigurarGridProdutos()
        {
            grdEstoque.Columns.Add("Codigo", "Codigo");
            grdEstoque.Columns.Add("SKU", "SKU");
            grdEstoque.Columns.Add("Descricao", "Descrição");
            grdEstoque.Columns.Add("Qtde", "Qtde");
            grdEstoque.Columns[0].Visible = false;
            grdEstoque.Columns[1].Width = 127;
            grdEstoque.Columns[2].Width = 500;
            grdEstoque.Columns[3].Width = 100;
        }
        private void CarregarProdutos()
        {
            try
            {

                grdProdutos.DataSource = produto.Consultar();
                for (int i = 0; i <= 10; i++)
                {
                    if (i != 1 && i != 2)
                    {
                        grdProdutos.Columns[i].Visible = false;
                    }
                }

                grdProdutos.Columns[1].Width = 150;
                grdProdutos.Columns[2].Width = 275;

                grdProdutos.Columns[1].HeaderText = "SKU";
                grdProdutos.Columns[2].HeaderText = "Descrição";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpar()
        {
            produto = new Produto();
            estoque = new Estoque();
            txtProduto.Clear();
            nudQtde.Value = 0;
            grdEstoque.Rows.Clear();
        }
        private void PreencherClasse()
        {
            estoque.Data = DateTime.Now;
            foreach (DataGridViewRow linha in grdEstoque.Rows)
            {
                Produto p = new Produto();
                p.Codigo = Convert.ToInt32(linha.Cells[0].Value);
                p.Quantidade = Convert.ToInt32(linha.Cells[3].Value);
                estoque.produtos.Add(p);
            }
        }
        private string ValidarPreenchimento()
        {
            string mensagemErro = string.Empty;
            
            if (grdEstoque.Rows.Count == 0)
            {
                mensagemErro += "Informe os PRODUTOS\n";
            }
            return mensagemErro;
        }

        private void frmEntradaEstoque_Load(object sender, EventArgs e)
        {
            ConfigurarGridProdutos();
            CarregarProdutos();
            txtDataEmissao.Text = DateTime.Now.ToString();
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            produto = new Produto();
            if (rdbSKU.Checked)
            {
                produto.Sku = txtProduto.Text;
            }
            else
            {
                produto.Descricao = txtProduto.Text;
            }
            CarregarProdutos();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            if (grdProdutos.SelectedRows.Count == 0)
            {
                return;
            }
            if (nudQtde.Value == 0)
            {
                MessageBox.Show("Informe a QUANTIDADE.", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                produto = new Produto();
                produto.Codigo = Convert.ToInt32(grdProdutos.SelectedRows[0].Cells[0].Value);
                produto.Consultar();
                string[] linha = new string[4];
                linha[0] = produto.Codigo.ToString();
                linha[1] = produto.Sku;
                linha[2] = produto.Descricao;
                linha[3] = nudQtde.Value.ToString();
                grdEstoque.Rows.Add(linha);
                nudQtde.Value = 0;
                txtProduto.Clear();
                txtProduto.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message,"Perfumaria da Lú", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (grdEstoque.SelectedRows.Count == 0)
            {
                return;
            }
            grdEstoque.Rows.Remove(grdEstoque.SelectedRows[0]);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string msgErro = ValidarPreenchimento();
                if (msgErro != string.Empty)
                {
                    MessageBox.Show(msgErro, "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                estoque.EfetivarEntrada();
                MessageBox.Show("Entrada de Estoque efetivada com sucesso.", "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
