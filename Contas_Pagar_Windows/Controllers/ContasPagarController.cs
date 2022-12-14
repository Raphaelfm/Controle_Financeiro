using Contas_Pagar_Windows.Banco;
using Contas_Pagar_Windows.Models;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Pagar_Windows.Controllers
{
    public class ContasPagarController
    {
        ContasPagar contas;
        ConexaoBd banco;
        public ContasPagarController()
        {            
            banco = new ConexaoBd();
            contas = new ContasPagar();
        }

        public void CadastrarContaPagar(TextBox textBoxRecebedor, TextBox textBoxValor, DateTimePicker dataPickerContPagar, TextBox textBoxObservacao)
        {
            contas.Recebedor = textBoxRecebedor.Text;
            double valor = Convert.ToDouble((textBoxValor.Text.Trim()));
            contas.Valor = valor;
            //contas.Data = Convert.ToDateTime(dataPickerContPagar.Text);
            contas.Observacao = textBoxObservacao.Text;

            // Converte o valor String para Date
            DateTime dt = Convert.ToDateTime(dataPickerContPagar.Text);

            // Cria uma nova cadeia de carecteres colocando os valores da data na ordem aceitada pelo MySQL.
            string data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            contas.Data = Convert.ToDateTime(data);

            MySqlDataReader reader;
            this.banco.conectar();
            this.banco.nonQuery("insert into contaspagar (Recebedor,Valor,DataPagamento,Observacao)  values " +
                "('" + contas.Recebedor + "', '" +
                contas.Valor.ToString().Replace(",",".") + "','" +
                data + "','" +
                contas.Observacao + "')");
            this.banco.close();
        }

        public MySqlDataReader listarContasPagar()
        {
            this.banco.conectar();
            return this.banco.Query("select * from contaspagar");
        }
    }
}
