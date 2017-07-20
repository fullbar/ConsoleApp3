using System;

class Program
{
    static void Main(string[] args)
    {
        int b;
        string baseTestValue = Console.ReadLine();
        b = int.Parse(baseTestValue);

        int p;
        string powerTextValue = Console.ReadLine();
        p = int.Parse(powerTextValue);

        Console.WriteLine(Math.Pow(b, p));
    }
}

