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
    
        
        Scripture myScripture = new Scripture("moses",1, 39, "Behold, this it my work and my glory to bring to pass the immortality and eternal life of man.");
        Console.Clear();
        myScripture.ShowScripture();

    }
}