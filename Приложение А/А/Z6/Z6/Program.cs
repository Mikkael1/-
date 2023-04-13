using System;

class Program
{
    static void Main(string[] args)
    {
        double x = 2.7;
        double y = Math.Log(x + Math.Sqrt(Math.Pow(x, 2) + 9)) - x + 1 / Math.Pow(Math.Atan(x), 2);

        Console.WriteLine($"Ответ: {y}");
    }
}
