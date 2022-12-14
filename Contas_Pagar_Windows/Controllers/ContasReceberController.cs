using Contas_Pagar_Windows.Banco;
using Contas_Pagar_Windows.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Pagar_Windows.Controllers
{
    public class ContasReceberController
    {
        ContasReceber contas;
        ConexaoBd banco;
        public ContasReceberController()
        {
            banco = new ConexaoBd();
            contas = new ContasReceber();
        }

        public void CadastrarContaReceber(TextBox textBoxOrigem, TextBox textBoxValor, DateTimePicker dataPickerContPagar, TextBox textBoxObservacao)
        {
            contas.Pagador = textBoxOrigem.Text;
            double valor = Convert.ToDouble((textBoxValor.Text.Trim()));
            contas.Valor = valor;
            contas.Observacao = textBoxObservacao.Text;

            // Converte o valor String para Date
            DateTime dt = Convert.ToDateTime(dataPickerContPagar.Text);

            // Cria uma nova cadeia de carecteres colocando os valores da data na ordem aceitada pelo MySQL.
            string data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            contas.Data = Convert.ToDateTime(data);

            MySqlDataReader reader;
            this.banco.conectar();
            this.banco.nonQuery("insert into contasreceber (Pagador,Valor,DataPagamento,Observacao)  values " +
                "('" + contas.Pagador + "', '" +
                contas.Valor.ToString().Replace(",", ".") + "','" +
                data + "','" +
                contas.Observacao + "')");
            this.banco.close();
        }
    }
}
