using Dapper;
using AlasComercialERP.Mapeamento;
using System.Collections.Generic;
using System.Linq;

namespace AlasComercialERP.DAO
{
    public class ProdutoComposicaoDAO : Conexao
    {
        public List<ProdutoComposicao> Listar()
        {
            string sql =
                "select " +
                "pc.IdComposicao, " +
                "pc.IdProdutoFinal, " +
                "pf.Nome as NomeProdutoFinal, " +
                "pc.IdProdutoMaterial, " +
                "pm.Nome as NomeProdutoMaterial, " +
                "pc.Quantidade " +
                "from ProdutoComposicao pc " +
                "inner join Produtos pf on pf.IdProduto = pc.IdProdutoFinal " +
                "inner join Produtos pm on pm.IdProduto = pc.IdProdutoMaterial " +
                "order by pf.Nome, pm.Nome";

            return banco.Query<ProdutoComposicao>(sql).ToList();
        }

        public List<ProdutoComposicao> ListarPorProdutoFinal(int idProdutoFinal)
        {
            string sql =
                "select " +
                "pc.IdComposicao, " +
                "pc.IdProdutoFinal, " +
                "pf.Nome as NomeProdutoFinal, " +
                "pc.IdProdutoMaterial, " +
                "pm.Nome as NomeProdutoMaterial, " +
                "pc.Quantidade " +
                "from ProdutoComposicao pc " +
                "inner join Produtos pf on pf.IdProduto = pc.IdProdutoFinal " +
                "inner join Produtos pm on pm.IdProduto = pc.IdProdutoMaterial " +
                "where pc.IdProdutoFinal = @IdProdutoFinal " +
                "order by pm.Nome";

            return banco.Query<ProdutoComposicao>(
                sql,
                new { IdProdutoFinal = idProdutoFinal }
            ).ToList();
        }

        public ProdutoComposicao Buscar(int id)
        {
            string sql =
                "select * " +
                "from ProdutoComposicao " +
                "where IdComposicao = @IdComposicao";

            return banco.Query<ProdutoComposicao>(
                sql,
                new { IdComposicao = id }
            ).SingleOrDefault();
        }

        public void Inserir(ProdutoComposicao composicao)
        {
            string sql =
                "insert into ProdutoComposicao " +
                "(IdProdutoFinal, IdProdutoMaterial, Quantidade) " +
                "values " +
                "(@IdProdutoFinal, @IdProdutoMaterial, @Quantidade)";

            banco.Execute(sql, composicao);
        }

        public void Alterar(ProdutoComposicao composicao)
        {
            string sql =
                "update ProdutoComposicao set " +
                "IdProdutoFinal = @IdProdutoFinal, " +
                "IdProdutoMaterial = @IdProdutoMaterial, " +
                "Quantidade = @Quantidade " +
                "where IdComposicao = @IdComposicao";

            banco.Execute(sql, composicao);
        }

        public void Excluir(int id)
        {
            string sql =
                "delete from ProdutoComposicao " +
                "where IdComposicao = @IdComposicao";

            banco.Execute(sql, new { IdComposicao = id });
        }

        public void ExcluirPorProdutoFinal(int idProdutoFinal)
        {
            string sql =
                "delete from ProdutoComposicao " +
                "where IdProdutoFinal = @IdProdutoFinal";

            banco.Execute(sql, new { IdProdutoFinal = idProdutoFinal });
        }
    }
}