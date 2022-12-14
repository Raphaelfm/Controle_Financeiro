using Contas_Pagar_Windows.Controllers;
using MySql.Data.MySqlClient;
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
    public partial class TelaRelatorioContasReceber : Form
    {
        ContasReceberController contas;
        public TelaRelatorioContasReceber()
        {
            InitializeComponent();
            contas = new ContasReceberController();
            atualizarDataGrid();
        }

        private void atualizarDataGrid()
        {
            MySqlDataReader temp = contas.listarContasReceber();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dataGridContasReceber.DataSource = dt;
        }
    }
}
