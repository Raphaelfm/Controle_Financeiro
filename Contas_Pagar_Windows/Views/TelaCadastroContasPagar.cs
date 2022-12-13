using Contas_Pagar_Windows.Banco;
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
        
    }
}
