using Dapper;
using AlasComercialERP.Mapeamento;
using System.Collections.Generic;
using System.Linq;

namespace AlasComercialERP.DAO
{
    public class FornecedorDAO : Conexao
    {
        public List<Fornecedor> Listar()
        {
            return banco.Query<Fornecedor>(
                "select * from Fornecedores order by Nome"
            ).ToList();
        }

        public Fornecedor Buscar(int id)
        {
            return banco.Query<Fornecedor>(
                "select * from Fornecedores where IdFornecedor = @IdFornecedor",
                new { IdFornecedor = id }
            ).SingleOrDefault();
        }

        public void Inserir(Fornecedor fornecedor)
        {
            string sql =
                "insert into Fornecedores (Nome, CNPJ, Telefone, Email) " +
                "values (@Nome, @CNPJ, @Telefone, @Email)";

            banco.Execute(sql, fornecedor);
        }

        public void Alterar(Fornecedor fornecedor)
        {
            string sql =
                "update Fornecedores set " +
                "Nome = @Nome, " +
                "CNPJ = @CNPJ, " +
                "Telefone = @Telefone, " +
                "Email = @Email " +
                "where IdFornecedor = @IdFornecedor";

            banco.Execute(sql, fornecedor);
        }

        public void Excluir(int id)
        {
            banco.Execute(
                "delete from Fornecedores where IdFornecedor = @IdFornecedor",
                new { IdFornecedor = id }
            );
        }
    }
}
