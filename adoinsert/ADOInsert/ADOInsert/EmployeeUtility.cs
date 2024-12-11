using System;
using System.Data.SqlClient;

namespace ADOInsert
{
    public class EmployeeUtility
    {
        public bool AddEmployee(EmployeeInfo employeeInfoObj)
        {
            DBConnection dbConnection = new DBConnection();
            SqlConnection conn = dbConnection.GetConnection();

            try
            {
                conn.Open();
                string query = "INSERT INTO Employee (Id, Name, DOB, Contact, Address, Designation) VALUES (@Id, @Name, @DOB, @Contact, @Address, @Designation)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", employeeInfoObj.Id);
                cmd.Parameters.AddWithValue("@Name", employeeInfoObj.Name);
                cmd.Parameters.AddWithValue("@DOB", employeeInfoObj.DOB);
                cmd.Parameters.AddWithValue("@Contact", employeeInfoObj.Contact);
                cmd.Parameters.AddWithValue("@Address", employeeInfoObj.Address);
                cmd.Parameters.AddWithValue("@Designation", employeeInfoObj.Designation);

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