using System;

namespace Array_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of applications:");
            int numApplications = int.Parse(Console.ReadLine());
            int verifiedCount = 0;
            int notVerifiedCount = 0;

            Console.WriteLine("Enter the applicant names:");
            for (int i = 0; i < numApplications; i++)
            {
                string applicantName = Console.ReadLine();
                if (IsNameValid(applicantName))
                {
                    verifiedCount++;
                }
                else
                {
                    notVerifiedCount++;
                }
            }

            Console.WriteLine($"Verified = {verifiedCount}");
            Console.WriteLine($"Not verified = {notVerifiedCount}");
        }

        private static bool IsNameValid(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}