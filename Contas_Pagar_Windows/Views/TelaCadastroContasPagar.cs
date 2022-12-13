using Contas_Pagar_Windows.Banco;
using Contas_Pagar_Windows.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contas_Pagar_Windows.Views
{
    public partial class TelaCadastroContasPagar : Form
    {
        ConexaoBd banco;
        ContasPagarController contas = new ContasPagarController();
        public TelaCadastroContasPagar()
        {
            InitializeComponent();
            this.banco= new ConexaoBd();
            Conec();
        }

        public void Conec()
        {
            banco.conectar();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            contas.CadastrarContaPagar(
                textBoxRecebedor,
                textBoxValor,
                dataPickerContPagar,
                textBoxObservacao
                );
        }
    }
}
