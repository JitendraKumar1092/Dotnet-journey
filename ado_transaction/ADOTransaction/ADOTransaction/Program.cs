using System;

namespace ADOTransaction
{
    public class Program
    {
        public static void Main(string[] args)
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
            decimal remainingBalance = utility.Withdrawal(customerInfo);

            if (remainingBalance == 0)
            {
                Console.WriteLine("The transaction failed due to a lack of the required minimum balance");
            }
            else
            {
                Console.WriteLine("The amount was successfully withdrawn");
                Console.WriteLine($"Available balance is : {remainingBalance:F2}");
            }
        }
    }
}