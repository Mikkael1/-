using System;

namespace RecursiveFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            double result = Factorial(n + 2) / Factorial(n + 4);

            Console.WriteLine($"Результат: {result}");
        }

        static double Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
