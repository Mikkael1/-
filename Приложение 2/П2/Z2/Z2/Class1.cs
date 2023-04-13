public class Product
{
    protected string name;
    protected decimal price;
    public Product(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Название товара: {name}, Цена: {price:C}");
    }
}

public class Toy : Product
{
    protected int recommendedAge;
    public Toy(string name, decimal price, int recommendedAge) : base(name, price)
    {
        this.recommendedAge = recommendedAge;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Название игрушки: {name}, Цена: {price:C}, Рекомендуемый возраст: {recommendedAge}");
    }
}
public class Commodity : Product
{
    protected int quantity;
    public Commodity(string name, decimal price, int quantity) : base(name, price)
    {
        this.quantity = quantity;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Название товара: {name}, Цена: {price:C}, Количество: {quantity}");
    }
}
public class DairyProduct : Product
{
    protected DateTime expirationDate;
    public DairyProduct(string name, decimal price, DateTime expirationDate) : base(name, price)
    {
        this.expirationDate = expirationDate;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Название молочного продукта: {name}, Цена: {price:C}, Срок годности до: {expirationDate.ToShortDateString()}");
    }
}