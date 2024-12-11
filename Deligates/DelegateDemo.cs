using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Sum is {0}", result);
            return result;
        }
        public int Subtract(int num1, int num2)
        {
            // sub method

            int result = num1 - num2;
            Console.WriteLine("Subtract is {0}", result);
            return result;
        }


    }
}