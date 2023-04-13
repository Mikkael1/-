public class Program
{
    public static void Main(string[] args)
    {
        // Создаем объекты разных классов и вызываем их методы
        Toy toy = new Toy("Мяч", 10.99m, 3);
        toy.DisplayInfo();

        Commodity commodity = new Commodity("Шоколадка", 1.99m, 5);
        commodity.DisplayInfo();

        DateTime expirationDate = new DateTime(2023, 12, 31);
        DairyProduct dairyProduct = new DairyProduct("Молоко", 2.49m, expirationDate);
        dairyProduct.DisplayInfo();

        Console.ReadKey();
    }
}
