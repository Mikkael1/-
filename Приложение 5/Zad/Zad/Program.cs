using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите элементы массива через пробел: ");
        string[] input = Console.ReadLine().Split();

        int[] A = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            A[i] = int.Parse(input[i]);
        }

        int count = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < 0)
            {
                count++;
                Console.WriteLine($"Отрицательный элемент: {A[i]}");
            }
        }

        Console.WriteLine($"Количество отрицательных элементов: {count}");
    }
}