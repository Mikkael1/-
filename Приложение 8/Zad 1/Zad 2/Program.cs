using System;

struct TRAIN
{
    public string destination;
    public int trainNumber;
    public DateTime departureTime;
}

class Program
{
    static void Main(string[] args)
    {
        TRAIN[] trains = new TRAIN[8];

        Console.WriteLine("Введите данные о 8 поездах:");

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Поезд #{i + 1}\nНазвание пункта назначения: ");
            trains[i].destination = Console.ReadLine();

            Console.Write("Номер поезда: ");
            trains[i].trainNumber = int.Parse(Console.ReadLine());

            Console.Write("Время отправления (в формате ДД.ММ.ГГГГ ЧЧ:ММ): ");
            trains[i].departureTime = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm", null);
        }

        Array.Sort(trains, (a, b) => a.trainNumber.CompareTo(b.trainNumber));

        Console.Write("Введите номер поезда: ");
        int number = int.Parse(Console.ReadLine());

        int index = Array.FindIndex(trains, t => t.trainNumber == number);

        if (index == -1)
        {
            Console.WriteLine($"Поезд #{number} не найден.");
        }
        else
        {
            Console.WriteLine($"Информация о поезде #{number}:\n" +
                              $"Пункт назначения: {trains[index].destination}\n" +
                              $"Время отправления: {trains[index].departureTime}");
        }
    }
}