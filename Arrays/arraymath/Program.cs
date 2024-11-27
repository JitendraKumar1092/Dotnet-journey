using System;

namespace Array_2 //DO NOT change the namespace name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input 1:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the input 2:");
            string input2 = Console.ReadLine();

            if (input1.Length != input2.Length)
            {
                Console.WriteLine("Invalid inputs");
                return;
            }

            int sum = 0;
            for (int i = 0; i < input1.Length; i++)
            {
                int digit1 = int.Parse(input1[i].ToString());
                int digit2 = int.Parse(input2[i].ToString());
                sum += digit1 * digit2;
            }

            Console.WriteLine(sum);
        }
    }
}