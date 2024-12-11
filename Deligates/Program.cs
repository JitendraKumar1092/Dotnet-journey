using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class Program
    {
        
        public delegate int DelegateCalcultor(int num1, int num2);
        static void Main(string[] args)
        {
            Calculator obj = new Calculator();

            //2)Instilized the Delegate 
            //Single cast Delegate 
            DelegateCalcultor delAdd = new DelegateCalcultor(obj.Add);
            DelegateCalcultor delSubtact = new DelegateCalcultor(obj.Subtract);
            
           

            //3)Calling the Delegate
            int sum = delAdd(30, 20);
            Console.WriteLine("Sum of the TwoNumber is {0}", sum);
            int subtract = delSubtact(30, 20);
            Console.WriteLine("subtract of the TwoNumber is {0}", subtract);
            int multiply = delMultiply(30, 20);
            Console.WriteLine("multiply of the TwoNumber is {0}", multiply);

            int divid = delDivid(30, 2);
            Console.WriteLine("divid of the TwoNumber is {0}", divid);




            //Multicast cast Delegate 
            DelegateCalcultor delMultiCast;//= new DelegateCalcultor();
            DelegateCalcultor delAdd1 = new DelegateCalcultor(obj.Add);
            DelegateCalcultor delSubtact1 = new DelegateCalcultor(obj.Subtract);
            DelegateCalcultor delMultiply1 = new DelegateCalcultor(obj.Muliply);
            DelegateCalcultor delDivid1 = new DelegateCalcultor(obj.Divid);
            Console.WriteLine("\n\n\n\n");

            delMultiCast = delAdd1;
            delMultiCast += delSubtact1;
            delMultiCast -= delMultiply1;
            delMultiCast += delDivid1;

            int result = delMultiCast(30, 2);

            Console.WriteLine("\n\n\n\nResult is {0}", result);



            Console.ReadKey();

        }
    }
}
