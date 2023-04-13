using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите цену за 1 кг конфет: ");
        int price = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Стоимость {0} кг конфет: {1}", i, price * i);
        }
    }
}
