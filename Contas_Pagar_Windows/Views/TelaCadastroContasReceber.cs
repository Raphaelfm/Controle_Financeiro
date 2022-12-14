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
    public partial class TelaCadastroContasReceber : Form
    {
        ContasReceberController contas;
        public TelaCadastroContasReceber()
        {
            InitializeComponent();
            contas = new ContasReceberController();
        }

        private void limparCampos()
        {
            textBoxOrigem.Text = "";
            textBoxValor.Text = "";
            dataPickerContPagar.Text = "";
            textBoxObservacao.Text = "";
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            contas.CadastrarContaReceber(
                textBoxOrigem,
                textBoxValor,
                dataPickerContPagar,
                textBoxObservacao
                );

            MessageBox.Show("Cadastro realizado com sucesso!");
            limparCampos();
        }
    }
}
