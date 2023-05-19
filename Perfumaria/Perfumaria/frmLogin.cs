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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private string ValidarPreenchimento()
        {
            string mensagemErro = string.Empty;
            if (txtUsuario.Text == string.Empty)
            {
                mensagemErro = "Preencha o usuário.\n";
            }
            if (txtSenha.Text == string.Empty)
            {
                mensagemErro += "Preencha a senha.";
            }
            return mensagemErro;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string msgErro = ValidarPreenchimento();
                if (msgErro != string.Empty)
                {
                    MessageBox.Show(msgErro, "Erro de Preenchimento",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Usuario usuario = new Usuario();
                usuario.Login = txtUsuario.Text;
                usuario.Consultar();

                if (txtUsuario.Text.Equals(usuario.Login) && txtSenha.Text.Equals(usuario.Senha))
                {
                    MessageBox.Show("Usuário autenticado com sucesso", "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Global.codigoUsuario = usuario.Codigo;
                    Global.nome = usuario.Nome;
                    Global.usuario = txtUsuario.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha incorretos","Erro de Preenchimento", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message,"Perfumaria", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbOlho_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar)
            {
                txtSenha.UseSystemPasswordChar= false;
                pcbOlho.Image = Perfumaria.Properties.Resources.eye_open;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                pcbOlho.Image = Perfumaria.Properties.Resources.eye_close;
            }
        }
    }
}
