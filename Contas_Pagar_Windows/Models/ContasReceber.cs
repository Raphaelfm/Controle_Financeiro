using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Pagar_Windows.Models
{
    public class ContasReceber
    {
        public string? Pagador { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public string? Observacao { get; set; }
        public string? StatusPG { get; set; }
    }
}
