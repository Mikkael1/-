using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Введите размерность массива: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите минимальное значение: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Введите максимальное значение: ");
        int max = int.Parse(Console.ReadLine());

        int[,] arr = new int[n, n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = rand.Next(min, max + 1);
            }
        }

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3}", arr[i, j]);
            }
            Console.WriteLine();
        }

        int sumFirstRow = 0;
        for (int j = 0; j < n; j++)
        {
            sumFirstRow += arr[0, j];
        }

        int sumLastButOneRow = 0;
        for (int j = 0; j < n; j++)
        {
            sumLastButOneRow += arr[n - 2, j];
        }

        if (sumFirstRow > sumLastButOneRow)
        {
            Console.WriteLine("Сумма элементов в первой строке больше.");
        }
        else if (sumFirstRow < sumLastButOneRow)
        {
            Console.WriteLine("Сумма элементов в предпоследней строке больше.");
        }
        else
        {
            Console.WriteLine("Суммы элементов в первой и предпоследней строках равны.");
        }

        Console.ReadLine();
    }
}