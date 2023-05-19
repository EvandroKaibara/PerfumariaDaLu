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
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            lblSistema.Text = "Perfumaria da Lú\n";
            lblSistema.Text += "Versão 1.0\n";
            lblSistema.Text += "© 2023 - Pascal Tecnologias\n";
            lblSistema.Text += "Todos os direitos reservados";

            lblTexto.Text = "Aviso: este programa de computador é protegido por leis de direitos autorais e tratados internacionais. A reprodução ou distribuição não autorizada deste programa, ou de qualquer parte dele, poderá resultar em severas punições civis e criminais, e os infratores serão punidos dentro do máximo rigor permitido por lei";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
