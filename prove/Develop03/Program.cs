using System;

class Program
{
    static void Main(string[] args)
    {
        Word test = new Word("testing");
        test.Display();
        test.Hide();
        Console.WriteLine();
        test.Display();
    }
}