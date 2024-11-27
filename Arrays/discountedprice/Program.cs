namespace BoxingUnBoxing //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        public object CalculateDiscountedPrice(object totalCost)
        {
            
            double cost = (double)totalCost;
            double discount = 0;

            // Calculate the discount based on the total cost
            if (cost >= 100 && cost <= 500)
            {
                discount = 0.05 * cost;
            }
            else if (cost > 500 && cost <= 1000)
            {
                discount = 0.15 * cost;
            }
            else if (cost > 1000)
            {
                discount = 0.30 * cost;
            }

    
            double discountedPrice = cost - discount;

            
            return (object)discountedPrice;
        }

        public static void Main(string[] args)  
        {

            Console.WriteLine("Enter the total cost");
            double totalCost = double.Parse(Console.ReadLine());

            Program program = new Program();
            object result = program.CalculateDiscountedPrice((object)totalCost);

            Console.WriteLine($"Price after discount is {result}");
        }
    }
}