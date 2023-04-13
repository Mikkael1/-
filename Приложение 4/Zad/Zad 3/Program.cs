using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод значений N, a и b с клавиатуры
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите значение a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите значение b: ");
        int b = int.Parse(Console.ReadLine());

        // Создание матрицы и заполнение ее случайными числами
        int[,] matrix = new int[n, n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.Next(a, b + 1);
            }
        }

        // Вывод исходной матрицы на экран
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }

        // Вычисление среднего арифметического элементов, больших заданного G
        Console.Write("Введите значение G: ");
        int g = int.Parse(Console.ReadLine());

        int sum = 0;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > g)
                {
                    sum += matrix[i, j];
                    count++;
                }
            }
        }

        if (count > 0)
        {
            double average = (double)sum / count;
            Console.WriteLine("Среднее арифметическое элементов, больших {0}: {1:F2}", g, average);
        }
        else
        {
            Console.WriteLine("Нет элементов, больших {0}", g);
        }

        // Вычисление количества чётных элементов k-той строки
        Console.Write("Введите номер строки k (от 0 до {0}): ", n - 1);
        int k = int.Parse(Console.ReadLine());

        int evenCount = 0;
        for (int j = 0; j < n; j++)
        {
            if (matrix[k, j] % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine("Количество чётных элементов в строке {0}: {1}", k, evenCount);

        // Ожидание нажатия клавиши Enter перед выходом из программы
        Console.ReadLine();
    }
}