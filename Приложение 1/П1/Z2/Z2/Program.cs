Console.WriteLine("Введите длины сторон треугольника:");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}