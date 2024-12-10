using System;
using System.Data.SqlClient;

namespace ADODelete
{
    public class EmployeeUtility
    {
        public bool DeleteEmployee(int employeeId)
        {
            DBConnection dbConnection = new DBConnection();
            SqlConnection conn = dbConnection.GetConnection();

            try
            {
                conn.Open();
                string query = "DELETE FROM Employee WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", employeeId);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}