using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите трехзначное число с различными цифрами: ");
        int num = int.Parse(Console.ReadLine());

        int digit1 = num / 100;
        int digit2 = (num / 10) % 10;
        int digit3 = num % 10;

        int num1 = digit1 * 100 + digit2 * 10 + digit3;
        int num2 = digit1 * 100 + digit3 * 10 + digit2;
        int num3 = digit2 * 100 + digit1 * 10 + digit3;
        int num4 = digit2 * 100 + digit3 * 10 + digit1;
        int num5 = digit3 * 100 + digit1 * 10 + digit2;
        int num6 = digit3 * 100 + digit2 * 10 + digit1;

        Console.WriteLine("Числа, образованные при перестановке цифр заданного числа:");
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
        Console.WriteLine(num4);
        Console.WriteLine(num5);
        Console.WriteLine(num6);

        Console.ReadKey();
    }
}
