using System;

namespace ADOUpdate
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the id:");
			int id = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the contact:");
			string contact = Console.ReadLine();

			EmployeeUtility utility = new EmployeeUtility();
			bool isUpdated = utility.UpdateEmployeeInfo(id, contact);

			if (isUpdated)
			{
				Console.WriteLine("Updated successfully");
			}
			else
			{
				Console.WriteLine("Not updated");
			}
		}
	}
}