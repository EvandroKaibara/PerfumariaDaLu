using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Perfumaria
{
    public partial class frmAlterarSetor : Form
    {
        public frmAlterarSetor()
        {
            InitializeComponent();
        }

        Setor setor = new Setor();
        Produto produto = new Produto();

        private void CarregarSetor()
        {
            try
            {
                grdSetores.DataSource = setor.Consultar();
                grdSetores.Columns[0].Visible = false;

                grdSetores.Columns[1].Width = 402;

                grdSetores.Columns[1].HeaderText = "Descrição";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            txtDescricao.Text = setor.Descricao;
            txtDescricao.Focus();
        }
        private void PreencherClasse()
        {
            produto.CodigoSetor = Convert.ToInt32(grdSetores.SelectedRows[0].Cells[0].Value);
            produto.PrecoUnitario = Convert.ToDecimal(txtValor.Text);
        }
        private void Limpar()
        {
            setor = new Setor();
            produto = new Produto();
            txtDescricao.Clear();
            txtPesquisa.Clear();
            txtPesquisa.Focus();
            txtValor.Clear();
            rdbAdicao.Checked = true;
        }
        private string ValidarPreenchimento()
        {
            string mensagemErro = string.Empty;



            if (txtDescricao.Text == string.Empty)
            {
                mensagemErro += "Informe o SETOR.\n";
            }
            if (txtValor.Text == string.Empty)
            {
                mensagemErro += "Informe o VALOR.\n";
            }
            else if (!decimal.TryParse(txtValor.Text, out decimal aux))
            {
                mensagemErro += "Valor inválido.\n";
            }
            else if ((rdbPorcentagem.Checked) && (Decimal.Parse(txtValor.Text) <= -100))
            {
                mensagemErro += "Valor inválido.\n";
            }
            else if (!produto.ValidarValorSetor(Convert.ToDecimal(txtValor.Text), Convert.ToInt32(grdSetores.SelectedRows[0].Cells[0].Value)) && rdbAdicao.Checked == true && txtDescricao.Text != string.Empty)
            {
                mensagemErro += "Há produtos com preço menor do que o valor que deseja deduzir.";
            }

            return mensagemErro;
        }

        private void frmAlterarSetor_Load(object sender, EventArgs e)
        {
            CarregarSetor();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            setor = new Setor();
            setor.Descricao = txtPesquisa.Text;
            CarregarSetor();
        }

        private void grdSetores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setor = new Setor();
                setor.Codigo = Convert.ToInt32(grdSetores.SelectedRows[0].Cells[0].Value);
                setor.Consultar();
                PreencherFormulario();
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
                if (rdbPorcentagem.Checked)
                {
                    PreencherClasse();
                    produto.AlterarPrecoSetor(Convert.ToDecimal(txtValor.Text), true);
                }
                else
                {
                    PreencherClasse();
                    produto.AlterarPrecoSetor(Convert.ToDecimal(txtValor.Text), false);
                }
                MessageBox.Show("Preço do setor alterado com sucesso.", "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '-') ||
                (e.KeyChar == ',' && txtValor.Text.Contains(',')) ||
                (e.KeyChar == '-' && (txtValor.Text.Contains('-'))))
            {
                e.Handled = true;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text.IndexOf("-") > 0)
            {
                txtValor.Text = txtValor.Text.Replace("-", "");
                txtValor.SelectionStart = txtValor.Text.Length;
            }
        }
    }
}
