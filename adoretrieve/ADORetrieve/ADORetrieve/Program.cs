using System;

namespace ADORetrieve
{
	public class Program
	{
		public static void Main(string[] args) //DO NOT change the 'Main' method signature
		{
			Console.WriteLine("Enter the employee id:");
			int id = Convert.ToInt32(Console.ReadLine());

			EmployeeUtility utility = new EmployeeUtility();
			EmployeeInfo employee = utility.GetEmployeeInfo(id);

			if (employee != null)
			{
				Console.WriteLine("Id\tName\tDOB\tContact\tAddress\tDesignation");
				Console.WriteLine($"{employee.Id}\t{employee.Name}\t{employee.DOB}\t{employee.Contact}\t{employee.Address}\t{employee.Designation}");
			}
			else
			{
				Console.WriteLine("Employee not found");
			}
		}
	}
}