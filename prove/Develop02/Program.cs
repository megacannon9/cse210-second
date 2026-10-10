using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int response = 0;
        JournalEntry newEntry = new JournalEntry();

        while (response !=5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Console.WriteLine("Create");
                    newEntry.CreateJournalEntry();
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Display");
                    newEntry.DisplayEntry();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Save");
                    newEntry.SaveJournalEntry();
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Read");
                    newEntry.LoadJournalEntry();
                    Console.WriteLine();
                    break;                
            }
        }
    }
}