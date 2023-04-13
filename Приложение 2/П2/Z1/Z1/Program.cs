using System;

class A
{
    private int a, b;

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public double ComputeExpression()
    {
        return (Math.Sin(b) + 4) / (2 * a);
    }

    public int SquareSum()
    {
        return (a + b) * (a + b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        A obj = new A(3, 5);
        Console.WriteLine($"a = {obj.ComputeExpression():F2}");
        Console.WriteLine($"(a + b)^2 = {obj.SquareSum()}");
    }
}