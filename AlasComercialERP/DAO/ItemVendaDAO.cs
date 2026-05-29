using Dapper;
using AlasComercialERP.Mapeamento;
using System.Collections.Generic;
using System.Linq;

namespace AlasComercialERP.DAO
{
    public class ItemVendaDAO : Conexao
    {
        public List<ItemVenda> ListarPorVenda(int idVenda)
        {
            return banco.Query<ItemVenda>(
                "select * from ItensVenda where IdVenda = @IdVenda",
                new { IdVenda = idVenda }
            ).ToList();
        }

        public ItemVenda Buscar(int id)
        {
            return banco.Query<ItemVenda>(
                "select * from ItensVenda where IdItemVenda = @IdItemVenda",
                new { IdItemVenda = id }
            ).SingleOrDefault();
        }

        public void Inserir(ItemVenda item)
        {
            string sql =
                "insert into ItensVenda (IdVenda, IdProduto, Quantidade, PrecoUnitario) " +
                "values (@IdVenda, @IdProduto, @Quantidade, @PrecoUnitario)";

            banco.Execute(sql, item);
        }

        public void Alterar(ItemVenda item)
        {
            string sql =
                "update ItensVenda set " +
                "IdVenda = @IdVenda, " +
                "IdProduto = @IdProduto, " +
                "Quantidade = @Quantidade, " +
                "PrecoUnitario = @PrecoUnitario " +
                "where IdItemVenda = @IdItemVenda";

            banco.Execute(sql, item);
        }

        public void Excluir(int id)
        {
            banco.Execute(
                "delete from ItensVenda where IdItemVenda = @IdItemVenda",
                new { IdItemVenda = id }
            );
        }

        public decimal CalcularTotalVenda(int idVenda)
        {
            string sql =
                "select isnull(sum(Quantidade * PrecoUnitario), 0) " +
                "from ItensVenda " +
                "where IdVenda = @IdVenda";

            return banco.Query<decimal>(
                sql,
                new { IdVenda = idVenda }
            ).Single();
        }
    }
}