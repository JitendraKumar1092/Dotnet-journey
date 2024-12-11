using System;
using System.Data.SqlClient;
using System.Transactions;

namespace ADOTransactionScope
{
    public class CustomerUtility
    {
        public decimal Withdrawal(CustomerInfo customerInfoObj)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection conn = new DBConnection().GetConnection())
                {
                    conn.Open();

                    string query = "SELECT Balance FROM Customer WHERE AccNumber = @AccNumber";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AccNumber", customerInfoObj.AccountNumber);
                    decimal balance = (decimal)cmd.ExecuteScalar();

                    if (balance - (decimal)customerInfoObj.Balance >= 500)
                    {
                        query = "UPDATE Customer SET Balance = Balance - @Amount WHERE AccNumber = @AccNumber";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Amount", customerInfoObj.Balance);
                        cmd.Parameters.AddWithValue("@AccNumber", customerInfoObj.AccountNumber);
                        cmd.ExecuteNonQuery();

                        scope.Complete();
                        return balance - (decimal)customerInfoObj.Balance;
                    }
                    else
                    {
                        throw new Exception("The transaction failed");
                    }
                }
            }
        }
    }
}