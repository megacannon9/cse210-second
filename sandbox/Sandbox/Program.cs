using System;
using System.Runtime.CompilerServices;

class Program
{
    
    static double AddNumbers(double x, int y)
        {
            return x+y;
        }

    static void DisplayGreeting(string name)
        {
            Console.WriteLine($"Welsomce {name}, pleased to meet you.");
        }
    
    static void Main(string[] args)
    {
        DisplayGreeting("Bob");
        double answer = AddNumbers(12.234, 10);
        Console.WriteLine(answer);
        
        // bool done = false;
        // while (! done)
        // {
        //     Console.WriteLine("Are we done yet (y/n): ");
        //     done=Console.ReadLine().ToLower()=="y";
        // }


        // do while loops guarantee it runs at least once, and then 
        // loops while the "while" is not met


        // bool done;

        // do
        // {
        //     Console.WriteLine("Are we done yet (y/n): ");
        //     done=Console.ReadLine().ToLower()=="y";
        // } while(!done);

        // for(int i =0; i<100; i-=5)
        // {
        //     Console.WriteLine(i);
        // }   
    
        // List<string> myFriends =new List<string> {"Bob","Betty","Bridger"};
        // //can also use syntax list<string> myFriends = ["Bob","Betty","Bridger"]
        // myFriends.Add("James");
        // foreach (string name in myFriends)
        // {
        //     Console.WriteLine(name);
        // }

        
    }
}