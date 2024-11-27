namespace TemperatureCalculation //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public bool ValidateTemperature(double temperature)
        {
            return temperature > 0;
        }

        public void FindFahrenheitAndKelvinFromCelsius(double celsius, out double fahrenheit, out double kelvin)
        {
            fahrenheit = (celsius * 1.8) + 32;
            kelvin = celsius + 273;
        }

        public static void Main(string[] args)  //DO NOT change the method signature
        {
            Console.WriteLine("Enter the temperature in Celsius:");
            double celsius = double.Parse(Console.ReadLine());

            Program program = new Program();

            if (program.ValidateTemperature(celsius))
            {
                Console.WriteLine("The given temperature is positive");
            }
            else
            {
                Console.WriteLine("The given temperature is negative");
            }

            program.FindFahrenheitAndKelvinFromCelsius(celsius, out double fahrenheit, out double kelvin);

            Console.WriteLine($"{celsius} degrees Celsius is equal to {fahrenheit} Fahrenheit");
            Console.WriteLine($"{celsius} degrees Celsius is equal to {kelvin} Kelvin");
        }
    }
}
