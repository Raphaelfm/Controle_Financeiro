using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contas_Pagar_Windows.Models;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Contas_Pagar_Windows.Banco
{
    internal class ConexaoBd
    {
        private string host = "localhost";
        private string database = "";
        private string user = "";
        private string password = "";
        private int port = 0;
        private MySqlConnection con;
        private MySqlCommand cmd;
        public ConexaoBd()
        {
            conectar();
        }
        public void conectar()
        {
            string strCon = @"server=" + this.host + "; database=" + this.database + "; user=" + this.user + "; password=" + this.password + "; port=" + this.port + ";";
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
