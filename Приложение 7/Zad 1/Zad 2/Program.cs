using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        // Поиск цифр в тексте
        Match match = Regex.Match(text, @"\d");
        if (match.Success)
        {
            Console.WriteLine("Текст содержит цифру: " + match.Value);
        }
        else
        {
            Console.WriteLine("Текст не содержит цифр.");
        }
    }
}