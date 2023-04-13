using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите начальную скорость v0:");
        double v0 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите ускорение a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите время t:");
        double t = double.Parse(Console.ReadLine());

        double S = v0 * t + (a * Math.Pow(t, 2)) / 2;
        double v = v0 + a * t;

        Console.WriteLine($"Расстояние S, пройденное за время {t} с начальной скоростью {v0} и ускорением {a} равно {S}");
        Console.WriteLine($"Скорость v, развиваемая за время {t} с начальной скоростью {v0} и ускорением {a} равна {v}");
    }
}
