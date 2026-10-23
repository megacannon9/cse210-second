using System;

class Program
{
    static void Main(string[] args)
    {   
        Scripture myScripture = new Scripture("Moses",1, 39, "Behold, this it my work and my glory to bring to pass the immortality and eternal life of man.");
        Console.Clear();
        myScripture.ShowScripture();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press 'Enter' to continue, or 'Quit' to end the program.");
        string input;
        while(myScripture.HideWords())
        {
            input = Console.ReadLine();
            if(input.ToLower() == "quit")
            {
                break;
            }
            Console.Clear();
            myScripture.ShowScripture();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 'Enter' to continue, or 'Quit' to end the program.");
        }
        Console.ReadLine();
        Console.Clear();
        myScripture.ShowScripture();
        //program runs these bottom three lines of code after 'quit' is input, 
        // but without them the program ends with one or two words still hidden
    }
}