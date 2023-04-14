using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        MatchCollection matches = Regex.Matches(text, "[бвгджзйклмнпрстфхцчшщbcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ]");

        Console.WriteLine($"Найдены следующие согласные буквы:");
        foreach (Match match in matches)
        {
            Console.Write(match.Value + " ");
        }

        Console.WriteLine($"\nКоличество согласных букв в тексте: {matches.Count}");
    }
}