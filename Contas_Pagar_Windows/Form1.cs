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

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroContasPagar cPagar = new TelaCadastroContasPagar();
            cPagar.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroContasReceber cReceber = new TelaCadastroContasReceber();
            cReceber.Show();
        }

        private void contasAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaRelatorioContasPagar rPagar = new TelaRelatorioContasPagar();
            rPagar.Show();
        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaRelatorioContasReceber rReceber = new TelaRelatorioContasReceber();
            rReceber.Show();
        }
    }
}