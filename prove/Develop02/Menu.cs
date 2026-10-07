class Menu
{
    
    public int ProcessMenu()
    {
        int response = 0;

        while (response < 1 || response > 5)
        {
            Console.WriteLine("Welcome to the journaling program.");
            Console.WriteLine("Create, Display, Save, or Read journal entries.");
            Console.WriteLine("1. Create New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Today's Entry");
            Console.WriteLine("4. Read Journal Entry");
            Console.WriteLine("5. Quit");

            response = int.Parse(Console.ReadLine());                         
        }

        return response;
    }
}