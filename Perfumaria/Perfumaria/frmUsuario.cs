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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        Usuario usuario = new Usuario();

        private void CarregarUsuario()
        {
            try
            {
                grdUsuarios.DataSource = usuario.Consultar();
                grdUsuarios.Columns[0].Visible = false;
                grdUsuarios.Columns[2].Visible = false;

                grdUsuarios.Columns[1].Width = 155;
                grdUsuarios.Columns[3].Width = 246;

                grdUsuarios.Columns[1].HeaderText = "Usuário";
                grdUsuarios.Columns[3].HeaderText = "Nome";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            txtNome.Text = usuario.Nome;
            txtSenha.Text = usuario.Senha;
            txtUsuario.Text = usuario.Login;
            txtConfirmacao.Text = usuario.Senha;
            txtUsuario.Focus();
        }

        private void PreencherClasse()
        {
            usuario.Login = txtUsuario.Text;
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
        }
        private void Limpar()
        {
            usuario = new Usuario();
            txtUsuario.Clear();
            txtConfirmacao.Clear();
            txtSenha.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();
            txtPesquisa.Focus();
        }
        private string ValidarPreenchimento()
        {
            string mensagemErro = string.Empty;

            try
            {
                if (txtUsuario.Text == string.Empty)
                {
                    mensagemErro = "Preencha o campo USUÁRIO.\n";
                }
                else
                {
                    Usuario u = new Usuario();
                    u.Login = txtUsuario.Text;
                    u.Consultar();
                    if ((usuario.Codigo == 0 && u.Codigo != 0) || (usuario.Codigo != 0 && u.Codigo != 0 && u.Codigo != usuario.Codigo))
                    {
                        mensagemErro += "USUÁRIO já existente.\n";
                    }
                }
                if (txtNome.Text == string.Empty)
                {
                    mensagemErro += "Preencha o campo NOME.\n";
                }
                if (txtSenha.Text == string.Empty)
                {
                    mensagemErro += "Preencha o campo SENHA.\n";
                }
                else if (txtConfirmacao.Text != txtSenha.Text)
                {
                    mensagemErro += "Confirmação de senha não confere.\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mensagemErro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            usuario = new Usuario();
            CarregarUsuario();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            usuario = new Usuario();
            usuario.Nome = txtPesquisa.Text;
            CarregarUsuario();
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
                usuario.ExecutarSQL();
                MessageBox.Show("Usuário cadastrado com sucesso.", "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                CarregarUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbOlho_1_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar)
            {
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.Text = txtSenha.Text;
                pcbOlho_1.Image = Perfumaria.Properties.Resources.eye_open;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                pcbOlho_1.Image = Perfumaria.Properties.Resources.eye_close;
            }
        }

        private void pcbOlho_2_Click(object sender, EventArgs e)
        {
            if (txtConfirmacao.UseSystemPasswordChar)
            {
                txtConfirmacao.UseSystemPasswordChar = false;
                pcbOlho_2.Image = Perfumaria.Properties.Resources.eye_open;
            }
            else
            {
                txtConfirmacao.UseSystemPasswordChar = true;
                pcbOlho_2.Image = Perfumaria.Properties.Resources.eye_close;
            }
        }

        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuario = new Usuario();
                usuario.Codigo = Convert.ToInt32(grdUsuarios.SelectedRows[0].Cells[0].Value);
                usuario.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
