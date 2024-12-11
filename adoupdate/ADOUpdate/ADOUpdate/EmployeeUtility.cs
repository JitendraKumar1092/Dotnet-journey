using System;
using System.Data.SqlClient;

namespace ADOUpdate
{
	public class EmployeeUtility
	{
		public bool UpdateEmployeeInfo(int id, string contact)
		{
			DBConnection dbConnection = new DBConnection();
			SqlConnection conn = dbConnection.GetConnection();

			try
			{
				conn.Open();
				string query = "UPDATE Employee SET Contact = @Contact WHERE Id = @Id";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@Id", id);
				cmd.Parameters.AddWithValue("@Contact", contact);

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