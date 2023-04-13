using System;

namespace ConsoleApp
{
    class Program
    {
        static void f(double x, out double y)
        {
            if (x < 0)
            {
                y = Math.Pow(x * x - 1, 2);
            }
            else if (x > 5 && x < 20)
            {
                y = 1 / Math.Pow(1 + x, 2);
            }
            else
            {
                y = 0;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите значение h: ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Таблица значений функции y = f(x):");
            Console.WriteLine("------------------------------------");

            for (double x = a; x <= b; x += h)
            {
                f(x, out double y);
                Console.WriteLine($"x = {x:f2}, y = {y:f4}");
            }

            Console.ReadLine();
        }
    }
}