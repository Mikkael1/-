using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем двумерный массив
        DoubleArray da = new DoubleArray(3, 3);
        da[0, 0] = 1.0; da[0, 1] = 2.0; da[0, 2] = 3.0;
        da[1, 0] = 4.0; da[1, 1] = 5.0; da[1, 2] = 6.0;
        da[2, 0] = 7.0; da[2, 1] = 8.0; da[2, 2] = 9.0;

        Console.WriteLine("Original array:");
        PrintArray(da);

        // Создаем столбец для добавления
        DoubleArray column = new DoubleArray(3, 1);
        column[0, 0] = 0.1; column[1, 0] = 0.2; column[2, 0] = 0.3;

        // Добавляем столбец
        DoubleArray newDa = da + column;

        Console.WriteLine("New array:");
        PrintArray(newDa);

        Console.ReadKey();
    }

    static void PrintArray(DoubleArray da)
    {
        for (int i = 0; i < da.Rows; i++)
        {
            for (int j = 0; j < da.Cols; j++)
            {
                Console.Write(da[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
