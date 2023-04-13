using System;

class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[99];
        for (int i = 0; i < 99; i++)
        {
            a[i] = i + 1;
        }

        Console.WriteLine("Исходный массив:");
        foreach (int item in a)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        int min = a[0];
        int max = a[0];
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
                minIndex = i;
            }
            if (a[i] > max)
            {
                max = a[i];
                maxIndex = i;
            }
        }

        int[] b = new int[a.Length - 2];
        int j = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (i != minIndex && i != maxIndex)
            {
                b[j] = a[i];
                j++;
            }
        }

        Console.WriteLine("Новый массив:");
        foreach (int item in b)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        Array.Sort(b);

        Console.WriteLine("Отсортированный массив:");
        foreach (int item in b)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        Console.Write("Введите число k для поиска: ");
        int k = int.Parse(Console.ReadLine());

        int left = 0;
        int right = b.Length - 1;
        int mid;

        while (left <= right)
        {
            mid = (left + right) / 2;
            if (b[mid] == k)
            {
                Console.WriteLine($"Число {k} найдено в массиве на позиции {mid}");
                return;
            }
            if (b[mid] > k)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        Console.WriteLine($"Число {k} не найдено в массиве");
    }
}