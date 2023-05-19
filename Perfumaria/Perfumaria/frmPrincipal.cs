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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        DateTime dttLogin;

        private void FecharFormulario()
        {
            this.Close();
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now.Subtract(dttLogin);
            lblTempo.Text = string.Format("{0}:{1}:{2}", ts.Hours.ToString("00"), ts.Minutes.ToString("00"), ts.Seconds.ToString("00"));
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dttLogin = DateTime.Now;
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            tmrTempo.Enabled = true;
            lblUsuario.Text = string.Format("Usuário: {0} ({1})", Global.nome, Global.usuario);
            lblBancoDados.Text = string.Format("{0}.{1}", Global.servidor, Global.banco);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar a aplicação?", "Perfumaria da Lú", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void AbrirForm(Form form)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.Name == form.Name)
                {
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            AbrirForm(frm);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            AbrirForm(frm);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frm = new frmProduto();
            AbrirForm(frm);
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetor frm = new frmSetor();
            AbrirForm(frm);
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaVenda frm = new frmNovaVenda();
            AbrirForm(frm);
        }

        private void mnuConsultarVenda_Click(object sender, EventArgs e)
        {
            frmConsultarVenda frm = new frmConsultarVenda();
            AbrirForm(frm);
        }

        private void mnuEntrada_Click(object sender, EventArgs e)
        {
            frmEntradaEstoque frm = new frmEntradaEstoque();
            AbrirForm(frm);
        }

        private void mnuConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarEstoque frm = new frmConsultarEstoque();
            AbrirForm(frm);
        }

        private void mnuPrecoPorSetor_Click(object sender, EventArgs e)
        {
            frmAlterarSetor frm = new frmAlterarSetor();
            AbrirForm(frm);
        }

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            AbrirForm(frm);
        }
        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}