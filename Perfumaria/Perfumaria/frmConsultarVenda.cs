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
    public partial class frmConsultarVenda : Form
    {
        public frmConsultarVenda()
        {
            InitializeComponent();
        }

        Venda venda = new Venda();
        Cliente cliente = new Cliente();
        
        private void CarregarClientes()
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
                grdClientes.Columns[7].HeaderText = "CPF";

                grdClientes.Columns[1].Width = 248;
                grdClientes.Columns[7].Width = 96;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message,"Perfumaria da Lú", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void LimparCliente()
        {
            cliente = new Cliente();
            txtCPF.Clear();
            txtNome.Clear();
            txtCliente.Clear();
        }
        private void Limpar()
        {
            btnLimparCliente.PerformClick();
            venda = new Venda();
            grdProdutos.DataSource = null;
            grdVenda.DataSource = null;
            txtNotaFiscal.Clear();
            txtDataEmissao.Clear();
            dtpInicio.Checked = false;
            dtpTermino.Checked = false;
        }
        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in grdProdutos.Rows)
            {
                total += Convert.ToDecimal(linha.Cells[4].Value.ToString().Replace("R$", "").Trim());
            }
            lblValorTotal.Text = total.ToString("C");
        }

        private void frmConsultarVenda_Load(object sender, EventArgs e)
        {
            CarregarClientes();
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
            CarregarClientes();
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            LimparCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                venda = new Venda();
                venda.CodigoCliente = cliente.Codigo;
                venda.Numero = txtNotaFiscal.Text;
                DateTime? inicio = null;
                DateTime? termino = null;
                if (dtpInicio.Checked)
                {
                    inicio = dtpInicio.Value;
                }
                if (dtpTermino.Checked)
                {
                    termino = dtpTermino.Value;
                }
                grdVenda.DataSource = venda.Consultar(inicio, termino);

                grdVenda.Columns[0].Visible = false;
                grdVenda.Columns[5].Visible = false;

                grdVenda.Columns[1].HeaderText = "Nº Nota Fiscal";
                grdVenda.Columns[2].HeaderText = "Data Emissão";
                grdVenda.Columns[3].HeaderText = "Cliente";
                grdVenda.Columns[4].HeaderText = "Emitido por";

                grdVenda.Columns[1].Width = 100;
                grdVenda.Columns[2].Width = 100;
                grdVenda.Columns[3].Width = 350;
                grdVenda.Columns[4].Width = 350;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message,"Perfumaria da Lú", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void grdVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                venda = new Venda();
                venda.Codigo = Convert.ToInt32(grdVenda.SelectedRows[0].Cells[0].Value);
                grdProdutos.DataSource = venda.Consultar(null, null);

                grdProdutos.Columns[0].HeaderText = "SKU";
                grdProdutos.Columns[1].HeaderText = "Produto";
                grdProdutos.Columns[2].HeaderText = "Preço Unitário";
                grdProdutos.Columns[3].HeaderText = "Qtde";
                grdProdutos.Columns[4].HeaderText = "Valor Total";

                grdProdutos.Columns[0].Width = 75;
                grdProdutos.Columns[1].Width = 350;
                grdProdutos.Columns[2].Width = 100;
                grdProdutos.Columns[3].Width = 75;
                grdProdutos.Columns[4].Width = 100;

                grdProdutos.Columns[2].DefaultCellStyle.Format = "c";
                grdProdutos.Columns[4].DefaultCellStyle.Format = "c";

                cliente = new Cliente();
                cliente.Codigo = venda.CodigoCliente;
                cliente.Consultar();

                txtClienteCPFCNPJ.Text = cliente.Cpf;
                txtNomeCliente.Text = cliente.Nome;

                txtNumero.Text = venda.Numero;
                txtDataEmissao.Text = venda.Data.ToShortDateString();

                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message,"Perfumaria da Lú", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void grdClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente = new Cliente();
            cliente.Codigo = Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value);
            cliente.Consultar();
            txtCPF.Text = cliente.Cpf;
            txtNome.Text = cliente.Nome;
        }
    }
}
