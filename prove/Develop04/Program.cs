using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectionActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Please choose a number from 1 to 4. (Press enter to continue.)");
                    Console.ReadLine();
                    break;
            }
        }
    }
}