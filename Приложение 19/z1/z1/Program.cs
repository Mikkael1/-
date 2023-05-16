
using System.Collections;

Console.Write("Enter line:");
string line = Console.ReadLine();

Stack stack = new Stack();

foreach (char c in line)
{

    if (c == '#' && stack.Count > 0)
    {
        stack.Pop();
    }
    else if (c != '#')
    {
        stack.Push(c);
    }
}

char[] arr = new char[stack.Count];
for (int i = stack.Count - 1; i >= 0; i--)
{
    arr[i] = (char)stack.Pop();
}


string result = new string(arr);
Console.WriteLine("Result: " + result);