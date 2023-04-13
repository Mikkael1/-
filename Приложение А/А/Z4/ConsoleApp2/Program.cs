using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите величину временного интервала (в минутах):");
        int minutes = Convert.ToInt32(Console.ReadLine());

        int hours = minutes / 60; // находим количество часов в заданном интервале
        int remainingMinutes = minutes % 60; // находим количество оставшихся минут

        Console.WriteLine($"{minutes} минут - это {hours} ч. {remainingMinutes} мин.");
    }
}
