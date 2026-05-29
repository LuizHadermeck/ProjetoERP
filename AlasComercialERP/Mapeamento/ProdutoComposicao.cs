using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlasComercialERP.Mapeamento
{
    public class ProdutoComposicao
    {
        public int IdComposicao { get; set; }

        public int IdProdutoFinal { get; set; }

        public int IdProdutoMaterial { get; set; }

        public decimal Quantidade { get; set; }

        public string NomeProdutoFinal { get; set; }

        public string NomeProdutoMaterial { get; set; }
    }
}
