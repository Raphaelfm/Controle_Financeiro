using Contas_Pagar_Windows.Views;

namespace Contas_Pagar_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadContasReceber_Click(object sender, EventArgs e)
        {
            TelaCadastroContasPagar cPagar = new TelaCadastroContasPagar();
            cPagar.Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroContasPagar cPagar = new TelaCadastroContasPagar();
            cPagar.Show();
        }
    }
}