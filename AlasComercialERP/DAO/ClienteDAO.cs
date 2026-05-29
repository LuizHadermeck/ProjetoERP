using Dapper;
using AlasComercialERP.Mapeamento;
using System.Collections.Generic;
using System.Linq;

namespace AlasComercialERP.DAO
{
    public class ClienteDAO : Conexao
    {
        public List<Cliente> Listar()
        {
            return banco.Query<Cliente>(
                "select * from Clientes order by Nome"
            ).ToList();
        }

        public Cliente Buscar(int id)
        {
            return banco.Query<Cliente>(
                "select * from Clientes where IdCliente = @IdCliente",
                new { IdCliente = id }
            ).SingleOrDefault();
        }

        public void Inserir(Cliente cliente)
        {
            string sql =
                "insert into Clientes (Nome, CPF_CNPJ, Telefone, Email, Endereco) " +
                "values (@Nome, @CPF_CNPJ, @Telefone, @Email, @Endereco)";

            banco.Execute(sql, cliente);
        }

        public void Alterar(Cliente cliente)
        {
            string sql =
                "update Clientes set " +
                "Nome = @Nome, " +
                "CPF_CNPJ = @CPF_CNPJ, " +
                "Telefone = @Telefone, " +
                "Email = @Email, " +
                "Endereco = @Endereco " +
                "where IdCliente = @IdCliente";

            banco.Execute(sql, cliente);
        }

        public void Excluir(int id)
        {
            banco.Execute(
                "delete from Clientes where IdCliente = @IdCliente",
                new { IdCliente = id }
            );
        }
    }
}