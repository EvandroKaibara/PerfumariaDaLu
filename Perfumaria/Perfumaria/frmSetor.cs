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
    public partial class frmSetor : Form
    {
        public frmSetor()
        {
            InitializeComponent();
        }

        Setor setor = new Setor();

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
            setor.Descricao = txtDescricao.Text;
        }
        private void Limpar()
        {
            setor = new Setor();
            txtDescricao.Clear();
            txtPesquisa.Clear();
            txtPesquisa.Focus();
        }
        private string ValidarPreenchimento()
        {
            string mensagemErro = string.Empty;

            if(txtDescricao.Text == string.Empty)
            {
                mensagemErro += "Preencha o campo DESCRIÇÃO.\n";
            }
            else
            {
                Setor s = new Setor();
                s.Descricao = txtDescricao.Text;
                s.Consultar();
                if ((setor.Codigo == 0 && s.Codigo != 0) || (setor.Codigo != 0 && s.Codigo != 0 && s.Codigo != setor.Codigo))
                {
                    mensagemErro += "SETOR já existente.\n";
                }
            }

            return mensagemErro;
        }

        private void frmSetor_Load(object sender, EventArgs e)
        {
            setor = new Setor();
            CarregarSetor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            setor = new Setor();
            setor.Descricao = txtPesquisa.Text;
            CarregarSetor();
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
                setor.ExecutarSQL();
                setor = new Setor();
                MessageBox.Show("Setor cadastrado com sucesso.", "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarSetor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Perfumaria da Lú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
