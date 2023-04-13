namespace FormulaCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = Convert.ToDouble(Console.ReadLine());

            double z1, z2;

            z1 = (((a + 2) / (Math.Sqrt(2 * a))) - (a / (Math.Sqrt(2 * a) + 2)) + (2 / (a - Math.Sqrt(2 * a)))) * (Math.Sqrt(a) - Math.Sqrt(2)) / (a + 2);
            z2 = 1 / (Math.Sqrt(a) + Math.Sqrt(2));

            Console.WriteLine($"z1 = {z1} z2 = {z2}");
        }
    }
}