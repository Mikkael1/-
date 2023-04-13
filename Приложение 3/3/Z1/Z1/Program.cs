using System;

namespace ConsoleApp1
{
    class Program
    {
        static double f(int n, double x)
        {
            double result = 0;
            for (int i = 2; i <= n; i += 2)
            {
                result += Math.Pow(x, i) / i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n:");
            int n = int.Parse(Console.ReadLine());

            double x = 5; 

            double expressionValue = f(n, x);
            Console.WriteLine($"Значение выражения: {expressionValue}");
        }
    }
}