using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите порядковый номер дня месяца: ");
        int day = Convert.ToInt32(Console.ReadLine());
        int daysLeft;

        if (day < 1 || day > 31) // проверка корректности ввода
        {
            Console.WriteLine("Некорректный номер дня месяца.");
        }
        else
        {
            int daysInMonth = 31; // для примера, считаем, что месяц всегда имеет 31 день

            if (day > daysInMonth) // проверка корректности ввода
            {
                Console.WriteLine("Некорректный номер дня месяца.");
            }
            else
            {
                daysLeft = daysInMonth - day;
                Console.WriteLine($"Осталось {daysLeft} дней до конца месяца.");
            }
        }

        Console.ReadLine();
    }
}