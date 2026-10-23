using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine("Pick a reference, using numbers 1, 2, or 3");
        Console.WriteLine("1. Moses 1:39");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.WriteLine("3. Alma 37:35");
        int response = int.Parse(Console.ReadLine());
        Scripture myScripture = null;                         
        switch(response)
        {
            case 1:
                myScripture = new Scripture("Moses",1,39,"For behold, this is my work and my glory- to bring to pass the immortality and eternal life of man.");
                break;
            case 2:
                myScripture = new Scripture("Proverbs",3,5,6,"Trust in the Lord with all your heart and lean not unto thine own understanding; in all your ways submit to him, and he will make your paths straight.");
                break;
            case 3:
                myScripture = new Scripture("Alma",37,35,"O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God.");
                break;
            default:
                Console.WriteLine("That's an invalid response. Please pick 1, 2, or 3.");
                return;
        }

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
        // Console.ReadLine();
        // Console.Clear();
        // myScripture.ShowScripture();
        //program runs these bottom three lines of code after 'quit' is input, 
        // but without them the program ends with one or two words still hidden
    }
}