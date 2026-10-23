using System;

class Program
{
    static void Main(string[] args)
    {   
        Scripture myScripture = new Scripture("Moses",1, 39, "Behold, this it my work and my glory to bring to pass the immortality and eternal life of man.");
        Console.Clear();
        myScripture.ShowScripture();
        while(myScripture.HideWords())
        {
            Console.ReadLine();
            Console.Clear();
            myScripture.ShowScripture();
        }
        Console.ReadLine();
        Console.Clear();
        myScripture.ShowScripture();
    }
}