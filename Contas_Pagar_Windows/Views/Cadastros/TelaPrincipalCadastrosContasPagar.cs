using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contas_Pagar_Windows.Views.Cadastros
{
    public partial class TelaPrincipalCadastrosContasPagar : Form
    {
        public TelaPrincipalCadastrosContasPagar()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastroContasPagar cadastroContasPagar = new TelaCadastroContasPagar();
            cadastroContasPagar.Show();
        }
    }
}
