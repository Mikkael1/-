public class Polynomial
{
    private double a, b, c;

    public Polynomial(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Calculate(double x)
    {
        return a * x * x + b * x + c;
    }

    public Polynomial Add(Polynomial p)
    {
        double newA = this.a + p.a;
        double newB = this.b + p.b;
        double newC = this.c + p.c;
        return new Polynomial(newA, newB, newC);
    }

    public Polynomial Subtract(Polynomial p)
    {
        double newA = this.a - p.a;
        double newB = this.b - p.b;
        double newC = this.c - p.c;
        return new Polynomial(newA, newB, newC);
    }

    public Polynomial Multiply(Polynomial p)
    {
        double newA = this.a * p.a;
        double newB = this.a * p.b + this.b * p.a;
        double newC = this.a * p.c + this.b * p.b + this.c * p.a;
        return new Polynomial(newA, newB, newC);
    }

    public void Display()
    {
        Console.WriteLine($"{a}x^2 + {b}x + {c}");
    }
}