using System.Data.SqlClient;

namespace ADOTransaction
{
    public class DBConnection
    {
        public SqlConnection GetConnection()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}