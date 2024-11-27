class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        
        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Remainder");
            Console.WriteLine("6. Factorial");
            Console.WriteLine("7. Power");
            Console.WriteLine("8. Square Root");
            Console.WriteLine("9. Absolute");
            Console.WriteLine("10. Exponential");
            Console.WriteLine("11. Max");
            Console.WriteLine("12. Min");
            Console.WriteLine("13. Average");
            Console.WriteLine("14. Sum");
            Console.WriteLine("15. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: calculator.Add(); break;
                case 2: calculator.Subtract(); break;
                case 3: calculator.Multiply(); break;
                case 4: calculator.Divide(); break;
                case 5: calculator.Remainder(); break;
                case 6: calculator.Factorial(); break;
                case 7: calculator.Power(); break;
                case 8: calculator.SquareRoot(); break;
                case 9: calculator.Absolute(); break;
                case 10: calculator.Exponential(); break;
                case 11: calculator.Max(); break;
                case 12: calculator.Min(); break;
                case 13: calculator.Average(); break;
                case 14: calculator.Sum(); break;
                case 15: return; // Exit
                default: Console.WriteLine("Invalid choice. Please try again."); break;
            }

            Console.WriteLine(); // Blank line for better readability
        }
    }
}
