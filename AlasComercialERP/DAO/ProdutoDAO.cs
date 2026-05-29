using Dapper;
using AlasComercialERP.Mapeamento;
using System.Collections.Generic;
using System.Linq;

namespace AlasComercialERP.DAO
{
    public class ProdutoDAO : Conexao
    {
        public List<Produto> Listar()
        {
            return banco.Query<Produto>(
                "select * from Produtos order by Nome"
            ).ToList();
        }

        public Produto Buscar(int id)
        {
            return banco.Query<Produto>(
                "select * from Produtos where IdProduto = @IdProduto",
                new { IdProduto = id }
            ).SingleOrDefault();
        }

        public int ContarPorFornecedor(int idFornecedor)
        {
            return banco.Query<int>(
                "select count(*) from Produtos where IdFornecedor = @IdFornecedor",
                new { IdFornecedor = idFornecedor }
            ).Single();
        }

        public void Inserir(Produto produto)
        {
            string sql =
                "insert into Produtos " +
                "(Nome, Descricao, PrecoCusto, PrecoVenda, Estoque, IdFornecedor) " +
                "values " +
                "(@Nome, @Descricao, @PrecoCusto, @PrecoVenda, @Estoque, @IdFornecedor)";

            banco.Execute(sql, produto);
        }

        public void Alterar(Produto produto)
        {
            string sql =
                "update Produtos set " +
                "Nome = @Nome, " +
                "Descricao = @Descricao, " +
                "PrecoCusto = @PrecoCusto, " +
                "PrecoVenda = @PrecoVenda, " +
                "Estoque = @Estoque, " +
                "IdFornecedor = @IdFornecedor " +
                "where IdProduto = @IdProduto";

            banco.Execute(sql, produto);
        }

        public void Excluir(int id)
        {
            banco.Execute(
                "delete from Produtos where IdProduto = @IdProduto",
                new { IdProduto = id }
            );
        }

        public void BaixarEstoque(int idProduto, int quantidade)
        {
            string sql =
                "update Produtos set " +
                "Estoque = Estoque - @Quantidade " +
                "where IdProduto = @IdProduto";

            banco.Execute(sql, new
            {
                IdProduto = idProduto,
                Quantidade = quantidade
            });
        }

        public void AdicionarEstoque(int idProduto, int quantidade)
        {
            string sql =
                "update Produtos set " +
                "Estoque = Estoque + @Quantidade " +
                "where IdProduto = @IdProduto";

            banco.Execute(sql, new
            {
                IdProduto = idProduto,
                Quantidade = quantidade
            });
        }
    }
}
