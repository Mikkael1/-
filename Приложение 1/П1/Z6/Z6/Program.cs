using System;

class Program
{
    static void Main(string[] args)
    {
        const double A = 0; 
        const double B = Math.PI / 2; 
        const int M = 20; 

        double h = (B - A) / M; 

        for (int i = 0; i <= M; i++)
        {
            double x = A + i * h; 
            double f = Math.Sin(x) - Math.Cos(x); 
            Console.WriteLine($"F({x:F2}) = {f:F2}"); 
        }

        Console.ReadKey();
    }
}