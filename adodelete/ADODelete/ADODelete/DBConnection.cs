using System.Data.SqlClient;

namespace ADODelete  //DO NOT change the namespace name
{
    public class DBConnection  //DO NOT change the class name
    {
        public SqlConnection GetConnection() //DO NOT change the method signature
        {
            SqlConnection conn = null;

            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\OFFICE\\Projects\\ADODelete\\ADODelete\\Database1.mdf; Integrated Security = True";
            conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}