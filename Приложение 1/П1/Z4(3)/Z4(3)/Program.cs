class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текущий курс доллара к рублю:");
        double rate = Convert.ToDouble(Console.ReadLine());

        for (int dollars = 5; dollars <= 500; dollars += 5)
        {
            double rubles = dollars * rate;
            Console.WriteLine($"{dollars} долларов = {rubles:F2} рублей");
        }
    }
}
