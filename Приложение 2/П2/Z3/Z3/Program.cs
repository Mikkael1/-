using System;

class Program
{
    static void Main(string[] args)
    {
        Polynomial p1 = new Polynomial(2, -3, 1);
        Polynomial p2 = new Polynomial(1, 2, -1);

        Console.WriteLine("Polynomial 1:");
        p1.Display();

        Console.WriteLine("Polynomial 2:");
        p2.Display();

        double x = 3;
        Console.WriteLine($"p1({x}) = {p1.Calculate(x)}");
        Console.WriteLine($"p2({x}) = {p2.Calculate(x)}");

        Polynomial sum = p1.Add(p2);
        Console.WriteLine("Sum of polynomials:");
        sum.Display();

        Polynomial diff = p1.Subtract(p2);
        Console.WriteLine("Difference of polynomials:");
        diff.Display();

        Polynomial product = p1.Multiply(p2);
        Console.WriteLine("Product of polynomials:");
        product.Display();

        Console.ReadLine();
    }
}