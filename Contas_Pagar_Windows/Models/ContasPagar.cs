using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Pagar_Windows.Models
{
    internal class ContasPagar
    {
        public string? Recebedor { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public string? Observacao { get; set; }
    }
}
