using Perfumaria;
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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        bool load = false;
        Cliente cliente = new Cliente();
        private void frmCliente_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            CarregarCliente();
            load = true;
        }

        private void CarregarEstados()
        {
            try
            {
                cboUF.DataSource = Global.ConsultarEstados();
                cboUF.DisplayMember = "UF";
                cboUF.ValueMember = "codigo";
                cboUF.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCidades(int CodigoUF)
        {
            try
            {
                cboCidade.DataSource = Global.ConsultarCidades(CodigoUF);
                cboCidade.DisplayMember = "cidade";
                cboCidade.ValueMember = "codigo";
                cboCidade.SelectedIndex = -1;
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
                grdPesquisa.DataSource = cliente.Consultar();
                for (int i = 0; i <= 10; i++)
                {
                    if (i != 1 && i != 8)
                    {
                        grdPesquisa.Columns[i].Visible = false;
                    }
                }
                grdPesquisa.Columns[1].HeaderText = "Nome";
                grdPesquisa.Columns[8].HeaderText = "CPF/CNPJ";

                grdPesquisa.Columns[1].Width = 264;
                grdPesquisa.Columns[8].Width = 160;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            try
            {
                txtNome.Text = cliente.Nome;
                txtCPF.Text = cliente.Cpf;
                txtEndereco.Text = cliente.Endereco;
                txtNumero.Text = cliente.Numero;
                txtComplemento.Text = cliente.Complemento;
                txtBairro.Text = cliente.Bairro;
                txtCEP.Text = cliente.Cep;
                txtNumero.Text = cliente.Numero;
                txtTelefone.Text = cliente.Telefone;
                int CodigoEstado = Global.ConsultarEstados(cliente.CodigoCidade);
                cboUF.SelectedValue = CodigoEstado;
                cboCidade.SelectedValue = cliente.CodigoCidade;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherClasse()
        {
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCPF.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = txtNumero.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cep = txtCEP.Text;
            cliente.Numero = txtNumero.Text;
            cliente.Telefone = txtTelefone.Text;

            cliente.CodigoCidade = Convert.ToInt32(cboCidade.SelectedValue);
        }

        private void Limpar()
        {
            cliente = new Cliente();
            txtNome.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtCEP.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtTelefone.Clear();
            cboCidade.Text = string.Empty;
            cboCidade.SelectedIndex = -1;
            cboUF.SelectedIndex = -1;
            txtPesquisa.Clear();
            txtPesquisa.Focus();
        }
        private string ValidarPreenchimento()
        {
            string mensagemErro = string.Empty;
            try
            {

                if (txtNome.Text == string.Empty)
                {
                    mensagemErro = "Preencha o Preencha o campo NOME.\n";
                }
                if (txtCPF.Text == string.Empty)
                {
                    mensagemErro += "Preencha o Preencha o campo CPF.\n";
                }
                else if (!Global.IsValid(txtCPF.Text))
                {
                    mensagemErro += "CPF inválido.\n";
                }
                else
                {
                    Cliente u = new Cliente();
                    u.Cpf = txtCPF.Text;
                    u.Consultar();
                    if ((cliente.Codigo == 0 && u.Codigo != 0) || (cliente.Codigo != 0 && u.Codigo != 0 && u.Codigo != cliente.Codigo))
                    {
                        mensagemErro += "CPF já existente.\n";
                    }
                }
                if (txtEndereco.Text == string.Empty)
                {
                    mensagemErro += "Preencha o campo ENDEREÇO.\n";
                }
                if (txtNumero.Text == string.Empty)
                {
                    mensagemErro += "Preencha o campo NÚMERO.\n";
                }
                if (txtCEP.Text == string.Empty)
                {
                    mensagemErro += "Preencha o campo CEP.\n";
                }
                if (txtBairro.Text == string.Empty)
                {
                    mensagemErro += "Preencha o campo BAIRRO.\n";
                }
                if (cboCidade.SelectedIndex == -1)
                {
                    mensagemErro += "Selecione a CIDADE.\n";
                }
                if (cboUF.SelectedIndex == -1)
                {
                    mensagemErro += "Selecione a UF.\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return mensagemErro;
        }

        private void cboUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!load)
            {
                return;
            }
            if (cboUF.SelectedIndex != -1)
            {
                CarregarCidades((int)cboUF.SelectedValue);
            }
        }
        private void grdPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cliente = new Cliente();
                cliente.Codigo = Convert.ToInt32(grdPesquisa.SelectedRows[0].Cells[0].Value);
                cliente.Consultar();
                PreencherFormulario();
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
                cliente.Gravar();
                MessageBox.Show("Cliente gravado com sucesso.", "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                CarregarCliente();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
