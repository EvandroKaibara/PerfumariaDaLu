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
    public partial class frmNovaVenda : Form
    {
        public frmNovaVenda()
        {
            InitializeComponent();
        }

        Cliente cliente = new Cliente();
        Produto produto = new Produto();
        Venda venda = new Venda();

        private void Limpar()
        {
            cliente = new Cliente();
            produto = new Produto();
            venda = new Venda();
            txtCliente.Clear();
            txtProduto.Clear();
            nudQtde.Value = 0;
            txtCPFCNPJ.Clear();
            txtNome.Clear();
            txtNotaFiscal.Clear();
            txtDataEmissao.Clear();
            grdItens.Rows.Clear();
            cboMetodoPagamento.SelectedIndex = -1;
            lblValorTotal.Text = "R$ 0,00";
        }
        private void CarregarProduto()
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
                grdProdutos.Columns[2].Width = 270;

                grdProdutos.Columns[1].HeaderText = "SKU";
                grdProdutos.Columns[2].HeaderText = "Descrição";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarCliente()
        {
            try
            {
                grdClientes.DataSource = cliente.Consultar();
                for (int i = 0; i <= 10; i++)
                {
                    if (i != 1 && i != 8)
                    {
                        grdClientes.Columns[i].Visible = false;
                    }
                }
                grdClientes.Columns[1].HeaderText = "Nome";
                grdClientes.Columns[8].HeaderText = "CPF";

                grdClientes.Columns[1].Width = 270;
                grdClientes.Columns[8].Width = 110;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ValidarPreenchimento()
        {
            string mensagemErro = string.Empty;
            if (cliente.Codigo == 0)
            {
                mensagemErro = "Selecione o Cliente.\n";
            }
            if (grdItens.Rows.Count == 0)
            {
                mensagemErro += "Informe os PRODUTOS\n";
            }
            if (cboMetodoPagamento.SelectedIndex == -1)
            {
                mensagemErro += "Informe o Método de Pagamento\n";
            }
            
            return mensagemErro;
        }
        private void SelecionarCliente()
        {
            if (grdClientes.SelectedRows.Count == 0)
            {
                return;
            }
            cliente = new Cliente();
            cliente.Codigo = Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value);
            cliente.Consultar();
            txtCPFCNPJ.Text = cliente.Cpf;
            txtNome.Text = cliente.Nome;
            txtDataEmissao.Text = DateTime.Now.ToShortDateString();
            txtNotaFiscal.Text = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
        private void SelecionarProduto()
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
            produto = new Produto();
            produto.Codigo = Convert.ToInt32(grdProdutos.SelectedRows[0].Cells[0].Value);
            produto.Consultar();
            string[] linha = new string[6];
            linha[0] = produto.Codigo.ToString();
            linha[1] = produto.Sku;
            linha[2] = produto.Descricao;
            linha[3] = nudQtde.Value.ToString();
            linha[4] = produto.PrecoUnitario.ToString("C");
            linha[5] = (nudQtde.Value * produto.PrecoUnitario).ToString("C");
            grdItens.Rows.Add(linha);
            nudQtde.Value = 0;
            txtProduto.Clear();
            txtProduto.Focus();
            CalcularTotal();
        }
        private void ConfigurarGridProdutos()
        {
            grdItens.Columns.Add("Codigo", "Codigo");
            grdItens.Columns.Add("SKU", "SKU");
            grdItens.Columns.Add("Descricao", "Descrição");
            grdItens.Columns.Add("Qtde", "Qtde");
            grdItens.Columns.Add("PrecoUnitario", "Preço Unitário");
            grdItens.Columns.Add("Valor", "Valor");
            grdItens.Columns[0].Visible = false;
            grdItens.Columns[1].Width = 100;
            grdItens.Columns[2].Width = 375;
            grdItens.Columns[3].Width = 50;
            grdItens.Columns[4].Width = 100;
            grdItens.Columns[5].Width = 100;
        }

        private void PreencherClasse()
        {
            venda.Data = DateTime.Now;
            venda.CodigoCliente = cliente.Codigo;
            venda.Numero = txtNotaFiscal.Text;
            foreach (DataGridViewRow linha in grdItens.Rows)
            {
                Produto p = new Produto();
                p.Codigo = Convert.ToInt32(linha.Cells[0].Value);
                p.Consultar();

                p.Quantidade = Convert.ToInt32(linha.Cells[3].Value);
                venda.itens.Add(p);
            }
            venda.CodigoPagamento = Convert.ToInt32(cboMetodoPagamento.SelectedValue);
        }
        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in grdItens.Rows)
            {
                total += Convert.ToDecimal(linha.Cells[5].Value.ToString().Replace("R$", "").Trim());
            }
            lblValorTotal.Text = total.ToString("C");
        }
        private void CarregarMetodoPagamento()
        {
            try
            {
                cboMetodoPagamento.DataSource = Global.ConsultarMetodoPagamento();
                cboMetodoPagamento.DisplayMember = "metodo";
                cboMetodoPagamento.ValueMember = "codigo";
                cboMetodoPagamento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            cliente = new Cliente();
            if (rdbCPF.Checked)
            {
                cliente.Cpf = txtCliente.Text;
            }
            else
            {
                cliente.Nome = txtCliente.Text;
            }
            CarregarCliente();
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
            CarregarProduto();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            if (!venda.ValidarQuantidade(Convert.ToInt32(nudQtde.Value)))
            {
                MessageBox.Show("Quantidade em estoque menor do que a de venda.", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelecionarProduto();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            SelecionarCliente();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (grdItens.SelectedRows.Count == 0)
            {
                return;
            }
            grdItens.Rows.Remove(grdItens.SelectedRows[0]);
            CalcularTotal();
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
                venda.Emitir();
                MessageBox.Show("Nota Fiscal emititida com sucesso.", "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void frmNovaVenda_Load_1(object sender, EventArgs e)
        {
            ConfigurarGridProdutos();
            CarregarMetodoPagamento();
            CarregarProduto();
            CarregarCliente();            
        }

        private void grdClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarCliente();
        }

        private void grdProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!venda.ValidarQuantidade(Convert.ToInt32(nudQtde.Value)))
            {
                MessageBox.Show("Quantidade em estoque menor do que a de venda.", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelecionarProduto();
        }
    }
}
