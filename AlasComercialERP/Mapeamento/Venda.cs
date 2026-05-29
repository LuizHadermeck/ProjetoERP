using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlasComercialERP.Mapeamento
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public string StatusVenda { get; set; }
    }
}
