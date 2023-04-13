using System;
using System.Collections.Generic;
using System.IO;

class Index
{
    // Ключ - слово, значение - список номеров страниц, на которых это слово встречается
    private Dictionary<string, List<int>> index = new Dictionary<string, List<int>>();

    // Добавление слова и номера страницы в индекс
    public void Add(string word, int page)
    {
        if (!index.ContainsKey(word))
        {
            index.Add(word, new List<int>());
        }
        index[word].Add(page);
    }

    // Вывод индекса на экран
    public void Display()
    {
        Console.WriteLine("Предметный указатель:");
        foreach (var entry in index)
        {
            Console.Write(entry.Key + ": ");
            foreach (int page in entry.Value)
            {
                Console.Write(page + " ");
            }
            Console.WriteLine();
        }
    }

    // Вывод номеров страниц для заданного слова
    public void DisplayPages(string word)
    {
        if (index.ContainsKey(word))
        {
            Console.WriteLine("Страницы, на которых встречается слово \"" + word + "\":");
            foreach (int page in index[word])
            {
                Console.Write(page + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Слово \"" + word + "\" не найдено в предметном указателе.");
        }
    }

    // Удаление элемента из индекса
    public void Remove(string word)
    {
        if (index.ContainsKey(word))
        {
            index.Remove(word);
            Console.WriteLine("Слово \"" + word + "\" удалено из предметного указателя.");
        }
        else
        {
            Console.WriteLine("Слово \"" + word + "\" не найдено в предметном указателе.");
        }
    }

    // Формирование индекса из файла
    public void ReadFromFile(string filename)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string word = parts[0];
                    for (int i = 1; i < parts.Length; i++)
                    {
                        int page = int.Parse(parts[i]);
                        Add(word, page);
                    }
                }
            }
            Console.WriteLine("Индекс успешно загружен из файла " + filename);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при чтении файла " + filename + ": " + ex.Message);
        }
    }

    // Формирование индекса с клавиатуры
    public void ReadFromConsole()
    {
        Console.WriteLine("Введите слова и номера страниц через пробел. Для окончания ввода введите пустую строку.");
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "") break;
            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string word = parts[0];
            for (int i = 1; i < parts.Length; i++)
            {
                int page = int.Parse(parts[i]);
                Add(word, page);
            }
        }
    }
}