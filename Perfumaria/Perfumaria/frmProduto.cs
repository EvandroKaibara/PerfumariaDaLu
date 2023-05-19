using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Perfumaria
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        Produto produto = new Produto();
        NCM ncm = new NCM();
        Setor setor = new Setor();
        string simboloMonetario = NumberFormatInfo.CurrentInfo.CurrencySymbol;

        bool load = false;

        private void CarregarProdutos()
        {
            try
            {

                grdProdutos.DataSource = produto.Consultar();
                for (int i = 0; i <= 10; i++)
                {
                    if (i != 1 && i != 2 && i != 10)
                    {
                        grdProdutos.Columns[i].Visible = false;
                    }
                }

                grdProdutos.Columns[1].Width = 150;
                grdProdutos.Columns[2].Width = 275;
                grdProdutos.Columns[8].Width = 100;

                grdProdutos.Columns[1].HeaderText = "SKU";
                grdProdutos.Columns[2].HeaderText = "Descrição";
                grdProdutos.Columns[10].HeaderText = "Setor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarNCM()
        {
            try
            {
                grdNCM.DataSource = ncm.Consultar();
                grdNCM.Columns[0].Visible = false;

                grdNCM.Columns[1].Width = 100;
                grdNCM.Columns[2].Width = 300;

                grdNCM.Columns[1].HeaderText = "NCM";
                grdNCM.Columns[2].HeaderText = "Descrição";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarSetores()
        {
            try
            {
                cboSetor.DataSource = Global.ConsultarSetores();
                cboSetor.DisplayMember = "descricao";
                cboSetor.ValueMember = "codigo";
                cboSetor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherFormulario()
        {
            cboSetor.Text = string.Empty;
            cboSetor.SelectedIndex = -1;
            txtSku.Text = produto.Sku;
            txtDescricao.Text = produto.Descricao;
            txtPrecoUnitario.Text = produto.PrecoUnitario.ToString("C", CultureInfo.CurrentCulture);
            if(produto.Importado)
            {
                rdbSim.Checked = true;
            }
            else
            {
                rdbNao.Checked = true;
            }
            txtQuantidade.Text = Convert.ToString(produto.Quantidade);
            NCM n = new NCM();
            n.Codigo = produto.CodigoNCM;
            n.Consultar();
            txtNCM.Text = n.Ncm;
            if (produto.CodigoSetor != 0)
            {
                cboSetor.SelectedValue = produto.CodigoSetor;
            }
            else
            {
                chkSetor.Checked = true;
            }
            if (produto.Imagem == null)
            {
                pctImagem.Image = Properties.Resources.placeholder;
            }
            else
            {
                pctImagem.Image = Global.BytesToImage(produto.Imagem);
            }
        }
        private void Limpar()
        {
            produto = new Produto();
            txtSku.Clear();
            txtDescricao.Clear();
            txtPrecoUnitario.Clear();
            txtQuantidade.Clear();
            txtNCM.Clear();
            txtPesquisa.Clear();
            chkSetor.Checked = true;
            rdbNao.Checked = true;
            txtPesquisa.Focus();
            pctImagem.Image = Perfumaria.Properties.Resources.placeholder;
        }
        private void PreencherClasse()
        {
            produto.Sku = txtSku.Text;
            produto.Descricao = txtDescricao.Text;
            produto.PrecoUnitario = decimal.Parse(txtPrecoUnitario.Text.Replace(simboloMonetario, "").Trim());
            produto.Importado = rdbSim.Checked;
            produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            if (cboSetor.SelectedIndex != -1)
            {
                produto.CodigoSetor = Convert.ToInt32(cboSetor.SelectedValue);
            }
            else
            {
                produto.CodigoSetor = 0;
            }
            produto.CodigoNCM = Convert.ToInt32(grdNCM.SelectedRows[0].Cells[0].Value);
            produto.Imagem = Global.ImageToBytes(pctImagem);
        }
        private string ValidarPreenchimento()
        {
            string mensagemErro = string.Empty;
            decimal aux = 0;

            try
            {
                if (txtSku.Text == string.Empty)
                {
                    mensagemErro = "Preencha o campo SKU.\n";
                }
                else
                {
                    Produto p = new Produto();
                    p.Sku = txtSku.Text;
                    p.Consultar();
                    if ((produto.Codigo == 0 && p.Codigo != 0) || (produto.Codigo != 0 && p.Codigo != 0 && p.Codigo != produto.Codigo))
                    {
                        mensagemErro += "SKU já existente.\n";
                    }
                }
                if (txtDescricao.Text == string.Empty)
                {
                    mensagemErro += "Preencha o campo DESCRIÇÃO.\n";
                }
                if (txtPrecoUnitario.Text == simboloMonetario + " 0,00")
                {
                    mensagemErro += "Preencha o campo PREÇO UNITÁRIO.\n";
                }
                else if (!decimal.TryParse(txtPrecoUnitario.Text.Replace(simboloMonetario, "").Trim(), out aux))
                {
                    mensagemErro += "PREÇO UNITÁRIO inválido.\n";
                }
                if(txtQuantidade.Text == string.Empty)
                {
                    mensagemErro += "Preencha o campo QUANTIDADE.\n";
                }
                else if (!decimal.TryParse(txtQuantidade.Text, out aux))
                {
                    mensagemErro += "QUANTIDADE inválida.\n";
                }
                if(txtNCM.Text == string.Empty)
                {
                    mensagemErro += "Preencha o campo NCM.\n";
                }
                else if (txtNCM.TextLength != 8)
                {
                    mensagemErro += "NCM inválido.\n";
                }
                else if (grdNCM.RowCount == 0)
                {
                    mensagemErro += "NCM inválido.\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mensagemErro;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            CarregarSetores();
            CarregarProdutos();
            CarregarNCM();
            load = true;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            produto = new Produto();
            produto.Descricao = txtPesquisa.Text;
            CarregarProdutos();
        }

        private void txtPrecoUnitario_Enter(object sender, EventArgs e)
        {
            txtPrecoUnitario.Text = txtPrecoUnitario.Text.Replace(simboloMonetario, "").Trim();
        }

        private void txtPrecoUnitario_Leave(object sender, EventArgs e)
        {
            if (txtPrecoUnitario.Text == string.Empty)
            {
                txtPrecoUnitario.Text = simboloMonetario + " 0,00";
            }
            else
            {
                txtPrecoUnitario.Text = simboloMonetario + " " + txtPrecoUnitario.Text.Trim();
            }
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
                produto.Gravar();
                MessageBox.Show("Produto gravado com sucesso.", "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                CarregarProdutos();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNCM_TextChanged(object sender, EventArgs e)
        {
            ncm = new NCM();
            ncm.Ncm = txtNCM.Text;
            CarregarNCM();
        }

        private void grdNCM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ncm.Codigo = Convert.ToInt32(grdNCM.SelectedRows[0].Cells[0].Value);
            ncm.Consultar();
            txtNCM.Text = ncm.Ncm;
        }

        private void chkSetor_CheckedChanged(object sender, EventArgs e)
        {
            if (!load)
            {
                return;
            }
            if (chkSetor.Checked)
            {
                cboSetor.SelectedIndex = -1; 
                cboSetor.Text = string.Empty;
            }
        }

        private void cboSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!load)
            {
                return;
            }
            if (cboSetor.SelectedIndex!=-1)
            {
                chkSetor.Checked = false;
                setor = new Setor();
            }
        }

        private void grdProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            produto = new Produto();
            produto.Codigo = Convert.ToInt32(grdProdutos.SelectedRows[0].Cells[0].Value);
            produto.Consultar();
            PreencherFormulario();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',') || (e.KeyChar == ',' && txtPrecoUnitario.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void txtNCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            try
            {
                ofdImagem.FileName = string.Empty;
                ofdImagem.Filter = "jpeg|*.jpg|bmp|*.bmp|png|*.png|all files|*.*";
                if (ofdImagem.ShowDialog() == DialogResult.OK)
                {
                    pctImagem.Image = Image.FromFile(ofdImagem.FileName);
                    pctImagem.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }
    }
}
