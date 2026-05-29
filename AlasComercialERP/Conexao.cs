using System.Configuration;
using System.Data.SqlClient;

namespace AlasComercialERP
{
    public class Conexao
    {
        public SqlConnection banco = null;

        public Conexao()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AlasComercialERP"]?.ConnectionString;

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=alascomercialerp;Integrated Security=true;Column Encryption Setting=enabled;Connect Timeout=3;";
            }

            banco = new SqlConnection(connectionString);
        }
    }
}
