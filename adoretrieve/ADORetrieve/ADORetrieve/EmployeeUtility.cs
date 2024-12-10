using System;
using System.Data.SqlClient;

namespace ADORetrieve
{
    public class EmployeeUtility
    {
        public EmployeeInfo GetEmployeeInfo(int id)
        {
            DBConnection dbConnection = new DBConnection();
            SqlConnection conn = dbConnection.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT * FROM Employee WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    EmployeeInfo employee = new EmployeeInfo
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        DOB = reader["DOB"].ToString(),
                        Contact = reader["Contact"].ToString(),
                        Address = reader["Address"].ToString(),
                        Designation = reader["Designation"].ToString()
                    };
                    return employee;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}