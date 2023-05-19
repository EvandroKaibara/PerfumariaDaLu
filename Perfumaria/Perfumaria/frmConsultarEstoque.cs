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
    public partial class frmConsultarEstoque : Form
    {
        public frmConsultarEstoque()
        {
            InitializeComponent();
        }

        Produto produto = new Produto();
        Estoque estoque = new Estoque();

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
        private void LimparProduto()
        {
            produto = new Produto();
            txtSKU.Clear();
            txtDescricao.Clear();
            txtProduto.Focus();
        }
        private void Limpar()
        {
            produto = new Produto();
            estoque = new Estoque();
            grdEstoque.DataSource = null;
            txtSKU.Clear();
            txtDescricao.Clear();
            txtProduto.Clear();
            dtpInicio.Checked = false;
            dtpTermino.Checked = false;
        }

        private void frmConsultarEstoque_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
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

        private void grdProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                produto = new Produto();
                produto.Codigo = Convert.ToInt32(grdProdutos.SelectedRows[0].Cells[0].Value);
                produto.Consultar();
                txtSKU.Text = produto.Sku;
                txtDescricao.Text = produto.Descricao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message,"Perfumaria da Lú", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {
            LimparProduto();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
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
                grdEstoque.DataSource = estoque.ConsultarEntradas(produto.Codigo,inicio,termino);
                grdEstoque.Columns[0].Visible = false;

                grdEstoque.Columns[1].HeaderText = "Data Emissão";
                grdEstoque.Columns[2].HeaderText = "SKU";
                grdEstoque.Columns[3].HeaderText = "Produto";
                grdEstoque.Columns[4].HeaderText = "Qtde";
                grdEstoque.Columns[5].HeaderText = "Usuário";
                grdEstoque.Columns[6].HeaderText = "Nome";

                grdEstoque.Columns[1].Width = 100;
                grdEstoque.Columns[2].Width = 100;
                grdEstoque.Columns[3].Width = 375;
                grdEstoque.Columns[4].Width = 50;
                grdEstoque.Columns[5].Width = 130;
                grdEstoque.Columns[6].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message,"Perfumaria da Lú", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
