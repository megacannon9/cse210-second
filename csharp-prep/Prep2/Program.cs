using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage grade? (Maximum 100): ");
        string input=Console.ReadLine();
        int grade = int.Parse(input);
        string letterGrade;

        if (grade >= 90)
        {
            letterGrade= "a";
            Console.WriteLine("Your grade is: A");
        }
        else if(grade >= 80)
        {
            letterGrade= "b";
            Console.WriteLine("Your grade is: B");
        }
        else if(grade >= 70)
        {
            letterGrade= "c";
            Console.WriteLine("Your grade is: C");
        }
        else if(grade >= 60)
        {
            letterGrade= "d";
            Console.WriteLine("Your grade is: D");
        }
        else if(grade < 60)
        {
            letterGrade= "f";
            Console.WriteLine("Your grade is: F");
        }
        else if(grade >100)
        {
            Console.WriteLine("Extra credit still only counts as 100% here. Retry the input with 100.");
        }
        else
        {
            Console.WriteLine("That's not a valid percentage.");
        }

        if (grade < 70)
        {
            Console.WriteLine("I'm sorry, but you failed the course."); 
            Console.WriteLine("Try again though. You only truly fail if you quit.");
        }
        else
        {
            Console.WriteLine("Congratulations! You passed");
        }
    }
}