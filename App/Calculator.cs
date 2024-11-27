using System;

class Calculator
{
    public void Add()
    {
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The sum of {a} and {b} is {a + b}");
    }

    public void Subtract()
    {
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The difference of {a} and {b} is {a - b}");
    }

    public void Multiply()
    {
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The product of {a} and {b} is {a * b}");
    }

    public void Divide()
    {
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            Console.WriteLine($"The division of {a} by {b} is {a / b}");
        }
    }

    public void Remainder()
    {
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The remainder of {a} divided by {b} is {a % b}");
    }

    public void Factorial()
    {
        Console.WriteLine("Enter a non-negative integer:");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a < 0)
        {
            Console.WriteLine("Error: Factorial of a negative number is not defined.");
            return;
        }

        int fact = 1;
        for (int i = 1; i <= a; i++)
        {
            fact *= i;
        }
        Console.WriteLine($"The factorial of {a} is {fact}");
    }

    public void Power()
    {
        Console.WriteLine("Enter the base number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the exponent (power number):");
        int b = Convert.ToInt32(Console.ReadLine());

        int result = 1;
        for (int i = 1; i <= b; i++)
        {
            result *= a;
        }
        Console.WriteLine($"{a} raised to the power of {b} is {result}");
    }

    public void SquareRoot()
    {
        Console.WriteLine("Enter a non-negative number:");
        double a = Convert.ToDouble(Console.ReadLine());

        if (a < 0)
        {
            Console.WriteLine("Error: Square root of a negative number is not defined.");
            return;
        }

        Console.WriteLine($"The square root of {a} is {Math.Sqrt(a)}");
    }

    public void Absolute()
    {
        Console.WriteLine("Enter a number:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The absolute value of {a} is {Math.Abs(a)}");
    }

    public void Exponential()
    {
        Console.WriteLine("Enter the exponent for e (Euler's number):");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"e raised to the power of {a} is {Math.Exp(a)}");
    }

    public void Max()
    {
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The maximum of {a} and {b} is {Math.Max(a, b)}");
    }

    public void Min()
    {
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The minimum of {a} and {b} is {Math.Min(a, b)}");
    }

    public void Average()
    {
        Console.WriteLine("Enter the number of values:");
        int count = Convert.ToInt32(Console.ReadLine());
        double sum = 0;

        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine($"Enter number {i}:");
            sum += Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine($"The average of the entered numbers is {sum / count}");
    }

    public void Sum()
    {
        
        Console.WriteLine("Enter the number of values:");
        int count = Convert.ToInt32(Console.ReadLine());
        double sum = 0;
        // take n numbers from user and add them
        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine($"Enter number {i}:");
            sum += Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine($"The sum of the entered numbers is {sum}");
    }
}
