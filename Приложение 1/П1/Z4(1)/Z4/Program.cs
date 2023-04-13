using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текущий курс доллара к рублю:");
        double rate = Convert.ToDouble(Console.ReadLine());

        int dollars = 5;
        while (dollars <= 500)
        {
            double rubles = dollars * rate;
            Console.WriteLine($"{dollars} долларов = {rubles:F2} рублей");
            dollars += 5;
        }
    }
}
