using System;

namespace ADOTransactionScope
{
    public class Program
    {
        public static void Main(string[] args) //DO NOT change the 'Main' method signature
        {
            Console.WriteLine("Enter the account number");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the amount to withdraw");
            double amount = Convert.ToDouble(Console.ReadLine());

            CustomerInfo customerInfo = new CustomerInfo
            {
                AccountNumber = accountNumber,
                Balance = amount
            };

            CustomerUtility utility = new CustomerUtility();
            try
            {
                decimal remainingBalance = utility.Withdrawal(customerInfo);
                Console.WriteLine("The amount was successfully withdrawn");
                Console.WriteLine($"Available balance is: {remainingBalance:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}