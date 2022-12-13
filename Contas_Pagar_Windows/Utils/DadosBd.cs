using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI;

namespace Contas_Pagar_Windows.Utils
{
    public class DadosBd
    {
        public string? Porta { get; set; }
        public string? Senha { get; set; }
        public string? Usuario { get; set; }
        public string? BancoDados { get; set; }

        //public void GetPorta()
        //{
        //    //StreamReader r = new StreamReader("F:\\Desenvolvimento\\C#\\Contas_Pagar_Windows\\Contas_Pagar_Windows\\Utils\\ConfigBD.json");
        //    string jsonString = File.ReadAllText("F:\\Desenvolvimento\\C#\\Contas_Pagar_Windows\\Contas_Pagar_Windows\\Utils\\ConfigBD.json");
        //    DadosBd m = JsonSerializer.Deserialize<DadosBd>(jsonString)!;
        //}

        public void GetDadosAcesso()
        {
            //StreamReader r = new StreamReader("F:\\Desenvolvimento\\C#\\Contas_Pagar_Windows\\Contas_Pagar_Windows\\Utils\\ConfigBD.json");
            string jsonString = File.ReadAllText("F:\\Desenvolvimento\\C#\\Contas_Pagar_Windows\\Contas_Pagar_Windows\\Utils\\ConfigBD.json");
            DadosBd m = JsonSerializer.Deserialize<DadosBd>(jsonString)!;
            this.Porta = m.Porta;
            this.Senha = m.Senha;
            this.Usuario = m.Usuario;
        }
    }
}
