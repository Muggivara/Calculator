


namespace Lessons_Csharp
{
    internal class Program
    {
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static double Residual(double a, double b)
        {
            return a - b;
        }
        static double Product_of_numbers(double a, double b)
        {
            return a * b;
        }
        static double Private(double a, double b)
        {
            return a / b;
        }
        static void Main()
        {
            double a, b;
            while (true)
            {
                Console.Clear();
                string action;
                try
                {
                    Console.WriteLine("Enter numer 1");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number 2");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Choose action: + - * /");
                    action = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Nooup");
                    Console.ReadLine();
                    continue;
                }

                if (action == "+")
                {
                    Console.WriteLine(Sum(a, b));
                }
                else if (action == "-")
                {
                    Console.WriteLine(Residual(a, b));
                }
                else if (action == "*")
                {
                    Console.WriteLine(Product_of_numbers(a, b));
                }
                else if (action == "/")
                {
                    Console.WriteLine(Private(a, b));
                }
                Console.ReadLine();
            }
        }
    }
}
