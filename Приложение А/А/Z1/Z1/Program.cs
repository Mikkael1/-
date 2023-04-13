using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        double sum = num1 + num2;

        Console.WriteLine("Сумма чисел: {0:0.00}", sum);

        Console.ReadKey();
    }
}
