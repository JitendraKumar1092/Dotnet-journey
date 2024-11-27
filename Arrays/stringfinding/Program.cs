using System;
using System.Collections.Generic;

namespace Finding //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            Console.WriteLine("Enter values separated by colon");
            string s = Console.ReadLine();
            string[] values = s.Split(':');

            List<string> stringList = new List<string>();

            foreach (string value in values)
            {
                // Check if the value is not a number, boolean, or single character
                if (!int.TryParse(value, out _) && !double.TryParse(value, out _) && !bool.TryParse(value, out _) && value.Length > 1)
                {
                    stringList.Add(value);
                }
            }

            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }
        }
    }
}