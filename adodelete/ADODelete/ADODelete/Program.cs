using System;

namespace ADODelete
{
    public class Program
    {
        public static void Main(string[] args) //DO NOT change the 'Main' method signature
        {
            Console.WriteLine("Enter the id:");
            int id = Convert.ToInt32(Console.ReadLine());

            EmployeeUtility utility = new EmployeeUtility();
            bool isRemoved = utility.DeleteEmployee(id);

            if (isRemoved)
            {
                Console.WriteLine("Removed successfully");
            }
            else
            {
                Console.WriteLine("Not removed");
            }
        }
    }
}