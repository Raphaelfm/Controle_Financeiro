using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contas_Pagar_Windows.Models;
using Contas_Pagar_Windows.Utils;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Contas_Pagar_Windows.Banco
{
    public class ConexaoBd
    {
        DadosBd config = new DadosBd();
        ContasPagar contas = new ContasPagar();
        private string host = "localhost";
        //private string database = "";
        //private string user = "";
        private string password = "";
        //private int port = this.config.GetPorta();
        private MySqlConnection con;
        private MySqlCommand cmd;
        public ConexaoBd()
        {
            conectar();
        }
        public void conectar()
        {
            config.GetDadosAcesso();
            string strCon = @"server=" + this.host + "; database=" + config.BancoDados + "; user=" + config.Usuario + "; password=" + config.Senha + "; port=" + config.Porta + ";";
            this.con = new MySqlConnection(strCon);
            this.cmd = this.con.CreateCommand();
            this.con.Open();
        }
        public void close()
        {
            this.con.Close();
        }
        public void nonQuery(string sql)
        {
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public MySqlDataReader Query(string sql)
        {            
            this.cmd.CommandText = sql;            
            return this.cmd.ExecuteReader();
        }
    }
}
