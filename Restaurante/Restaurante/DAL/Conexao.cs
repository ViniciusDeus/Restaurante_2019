using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.DAL
{
    public class Conexao
    {
        static string stringConexao = ConfigurationManager.ConnectionStrings["ConexaoSqlServer"].ConnectionString;
        public static SqlConnection connection = new SqlConnection(stringConexao);

        public static SqlConnection fechaConexao()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }

        public static SqlConnection abreConexao()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

    }
}