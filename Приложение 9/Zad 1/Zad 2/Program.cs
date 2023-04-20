using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace task2
{
    internal class Product : IComparable<Product>
    {
        private string _name;
        private string _store;
        private int _price;

        public string Name { get { return _name; } set { _name = value; } }
        public string Store { get { return _store; } set { _store = value; } }
        public int Price { get { return _price; } set { _price = value; } }

        public Product(string name, string store, int price)
        {
            _name = name;
            _store = store;
            _price = price;
        }
        public override string ToString()
        {
            return String.Format($"Товар: {Name} ({Store}, {Price:C})");
        }

        public int CompareTo(Product other)
        {
            return Name.CompareTo(other.Name);
        }

        public static bool operator <(Product product1, Product product2)
        {
            return product1.Price < product2.Price;
        }

        public static bool operator >(Product product1, Product product2)
        {
            return product1.Price > product2.Price;
        }
    }

    class Warehouse
    {
        private List<Product> products;

        public Warehouse()
        {
            products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Remove(Product product)
        {
            products.Remove(product);
        }

        public void Display(int index)
        {
            Console.WriteLine(products[index]);
        }

        public void SortByName()
        {
            products.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
        }

        public void SortByStore()
        {
            products.Sort((p1, p2) => p1.Store.CompareTo(p2.Store));
        }

        public void SortByPrice()
        {
            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
        }

        public Product[] GetAll()
        {
            return products.ToArray();
        }
    }
}
namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();

            Product product1 = new Product("Книга", "Книжный магазин", 500);
            Product product2 = new Product("Мыло", "Супермаркет", 50);
            Product product3 = new Product("Футболка", "Магазин Одежды", 1000);
            Product product4 = new Product("Кросовки", "Обувной магазин", 200);


            warehouse.Add(product1);
            warehouse.Add(product2);
            warehouse.Add(product3);
            warehouse.Add(product4);

            Console.WriteLine("Выберите сортировку: \n 1 - по названию Товара \n 2 - по названию магазина \n 3 - по цене ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    warehouse.SortByName(); // сортировка товаров по названию Товара
                    break;
                case 2:
                    warehouse.SortByStore(); // сортировка товаров по названию магазина
                    break;
                case 3:
                    warehouse.SortByPrice(); // сортировка товаров по цене
                    break;
            }



            foreach (Product product in warehouse.GetAll())
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Введите индекс элемента который хотите вывести: ");
            int index = int.Parse(Console.ReadLine());

            warehouse.Display(index - 1); // вывод информации о товаре по номеру с помощью индекса
        }
    }
}