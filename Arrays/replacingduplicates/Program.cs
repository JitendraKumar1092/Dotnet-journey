using System;
using System.Collections.Generic;

namespace ReplacingDuplicates //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());

            char[] chars = new char[size];

            Console.WriteLine("Enter the characters");
            for (int i = 0; i < size; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the special character");
            char specialChar = char.Parse(Console.ReadLine());

            Program program = new Program();
            program.ReplaceDuplicateWithSpecialChar(ref chars, specialChar);


        }

        public void ReplaceDuplicateWithSpecialChar(ref char[] chars, char specialChar)
        {
            HashSet<char> seen = new HashSet<char>();
            HashSet<char> duplicates = new HashSet<char>();

            for (int i = 0; i < chars.Length; i++)
            {
                if (seen.Contains(chars[i]))
                {
                    duplicates.Add(chars[i]);
                }
                else
                {
                    seen.Add(chars[i]);
                }
            }

            for (int i = 0; i < chars.Length; i++)
            {
                if (duplicates.Contains(chars[i]))
                {
                    chars[i] = specialChar;
                }
            }
            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }
        }
    }
}