using System;
using System.Data.SqlClient;

namespace ADOTransaction
{
    public class CustomerUtility
    {
        public decimal Withdrawal(CustomerInfo customerInfoObj)
        {
            using (SqlConnection conn = new DBConnection().GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string query = "SELECT Balance FROM Customer WHERE AccNumber = @AccNumber";
                    SqlCommand cmd = new SqlCommand(query, conn, transaction);
                    cmd.Parameters.AddWithValue("@AccNumber", customerInfoObj.AccountNumber);
                    decimal balance = (decimal)cmd.ExecuteScalar();

                    if (balance - (decimal)customerInfoObj.Balance >= 500)
                    {
                        query = "UPDATE Customer SET Balance = Balance - @Amount WHERE AccNumber = @AccNumber";
                        cmd = new SqlCommand(query, conn, transaction);
                        cmd.Parameters.AddWithValue("@Amount", customerInfoObj.Balance);
                        cmd.Parameters.AddWithValue("@AccNumber", customerInfoObj.AccountNumber);
                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                        return balance - (decimal)customerInfoObj.Balance;
                    }
                    else
                    {
                        transaction.Rollback();
                        return 0;
                    }
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return 0;
                }
            }
        }
    }
}