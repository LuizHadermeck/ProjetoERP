using Dapper;
using AlasComercialERP.Mapeamento;
using System.Collections.Generic;
using System.Linq;

namespace AlasComercialERP.DAO
{
    public class VendaDAO : Conexao
    {
        public List<Venda> Listar()
        {
            return banco.Query<Venda>(
                "select * from Vendas order by DataVenda desc"
            ).ToList();
        }

        public Venda Buscar(int id)
        {
            return banco.Query<Venda>(
                "select * from Vendas where IdVenda = @IdVenda",
                new { IdVenda = id }
            ).SingleOrDefault();
        }

        public int Inserir(Venda venda)
        {
            string sql =
                "insert into Vendas (IdCliente, DataVenda, ValorTotal, StatusVenda) " +
                "values (@IdCliente, @DataVenda, @ValorTotal, @StatusVenda); " +
                "select cast(scope_identity() as int);";

            return banco.Query<int>(sql, venda).Single();
        }

        public void Alterar(Venda venda)
        {
            string sql =
                "update Vendas set " +
                "IdCliente = @IdCliente, " +
                "DataVenda = @DataVenda, " +
                "ValorTotal = @ValorTotal, " +
                "StatusVenda = @StatusVenda " +
                "where IdVenda = @IdVenda";

            banco.Execute(sql, venda);
        }

        public void AtualizarTotal(int idVenda, decimal valorTotal)
        {
            string sql =
                "update Vendas set " +
                "ValorTotal = @ValorTotal " +
                "where IdVenda = @IdVenda";

            banco.Execute(sql, new
            {
                IdVenda = idVenda,
                ValorTotal = valorTotal
            });
        }

        public void Excluir(int id)
        {
            banco.Execute(
                "delete from Vendas where IdVenda = @IdVenda",
                new { IdVenda = id }
            );
        }
    }
}