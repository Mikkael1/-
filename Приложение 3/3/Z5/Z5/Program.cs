class Program
{
    static void Main(string[] args)
    {
        Index index = new Index();

        index.ReadFromConsole();

        index.Display();

        Console.WriteLine("Введите слово для поиска:");
        string word = Console.ReadLine();
        index.DisplayPages(word);

        Console.WriteLine("Введите слово для удаления:");
        word = Console.ReadLine();
        index.Remove(word);

        Console.WriteLine("Введите имя файла для загрузки индекса:");
        string filename = Console.ReadLine();
        index.ReadFromFile(filename);

        index.Display();

        Console.ReadLine();
    }
}
