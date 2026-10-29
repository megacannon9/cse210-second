using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Samuel","Math");
        Console.WriteLine(test.GetSummary());
        MathAssignment test2 = new MathAssignment("Samuel","Math","15", "1-9");
        Console.WriteLine(test2.GetHomeworkList());
        WritingAssignment test3 = new WritingAssignment("Samuel","European History","The battle of Bluffdale");
        Console.WriteLine(test3.GetWritingInformation());
    }
}