var fileName = "D:\\Valya\\collage\\z2.txt";
var NumberQueue = new Queue<char>();

using (var reader = File.OpenText(fileName))
    while (!reader.EndOfStream)
    {
        var symbol = (char)reader.Read();
        if (char.IsDigit(symbol))
            NumberQueue.Enqueue(symbol);
        else
            Console.Write(symbol);
    }

while (NumberQueue.TryDequeue(out var digit))
    Console.Write(digit);