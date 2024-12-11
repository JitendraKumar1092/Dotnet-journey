using System;

namespace ADOInsert
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeInfo employee = new EmployeeInfo();

            Console.WriteLine("Enter the id:");
            employee.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name:");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Enter the DOB:");
            employee.DOB = Console.ReadLine();

            Console.WriteLine("Enter the contact:");
            employee.Contact = Console.ReadLine();

            Console.WriteLine("Enter the address:");
            employee.Address = Console.ReadLine();

            Console.WriteLine("Enter the designation:");
            employee.Designation = Console.ReadLine();

            EmployeeUtility utility = new EmployeeUtility();
            bool isAdded = utility.AddEmployee(employee);

            if (isAdded)
            {
                Console.WriteLine("Added successfully");
            }
            else
            {
                Console.WriteLine("Not added");
            }
        }
    }
}