using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlasComercialERP.Mapeamento
{
    public class ItemVenda
    {
        public int IdItemVenda { get; set; }
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public decimal Subtotal
        {
            get { return Quantidade * PrecoUnitario; }
        }
    }
}
