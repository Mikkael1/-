using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        string pattern = @"\b\w+\b(?=[^\.\?\!]*[\.\?\!](\s|$))|\b\w+\b(?<=^|\s)[^\.\?\!]*[\.\?\!](\s|$)";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        Console.ReadKey();
    }
}