namespace CalculatorApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator App!");
            Console.WriteLine("Insert the first number: ");
            double a = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Insert the second number: ");
            double b = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Choose an operation (+ or  *): ");
            char op = Console.ReadLine()[0];

            double result = op == '+' ? a + b : a * b;
            Console.WriteLine($"Summary: {result}");
        }
    }
}
