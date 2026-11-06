// class BaseActivity
// {
//     public BaseActivity()
//     {
        
//     }

//     public void RunCountdownMessage(string message, int seconds)
//     {
//         Console.CursorVisible = false;
//         for(int i=seconds; i>=1;i--)
//         {
//             Console.Clear();
//             Console.Write($"{message} - {i}");
//             Thread.Sleep(1000);
//         }
//         Console.CursorVisible = true;
//     }

//     public void DisplaySpinnerMessage(string message, int seconds)
//     {
//         Console.CursorVisible = false;
//         Console.Clear();
//         Console.Write($"{message} - ");
//         string spinnerAnimation = "-\\|/";
//         DateTime endTime = DateTime.Now.AddSeconds(seconds);
//         // for(int i=0;i<seconds;i++)
//         while(DateTime.Now<endTime)
//         {
//             foreach(char c in spinnerAnimation)
//             {
//                 Console.Write(c);
//                 Thread.Sleep(100);
//                 Console.Write("\b");
//                 Console.Write(c);
//                 Thread.Sleep(100);
//                 Console.Write("\b");
//             }
//         }
//         Console.CursorVisible = true;
//     }
// }

using System;
using System.Collections.Generic;
using System.Threading;

// The base class. It holds everything every activity shares: the name,
// the description, the duration, the starting and ending messages, and
// the spinner / countdown animations. Each child class calls these shared
// helpers from its own Run() method.
class Activity
{
    private static readonly Random _random = new Random();

    private string _name;
    private string _description;
    private int _duration;

    // protected: only the activity classes themselves ever construct an Activity.
    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description + "\n");

        _duration = ReadDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.WriteLine();
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(4);
    }

    private int ReadDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");

        int seconds;
        while (!int.TryParse(Console.ReadLine(), out seconds) || seconds <= 0)
        {
            Console.Write("Please enter a positive whole number: ");
        }

        return seconds;
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> frames = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(frames[index]);
            Thread.Sleep(250);
            Console.Write("\b \b"); // erase the character
            index = (index + 1) % frames.Count;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string number = i.ToString();
            Console.Write(number);
            Thread.Sleep(1000);

            Console.Write(new string('\b', number.Length));
            Console.Write(new string(' ', number.Length));
            Console.Write(new string('\b', number.Length));
        }
    }

    protected string GetRandomItem(List<string> items)
    {
        return items[_random.Next(items.Count)];
    }

    protected string GetRandomAndRemove(List<string> items)
    {
        int index = _random.Next(items.Count);
        string item = items[index];
        items.RemoveAt(index);
        return item;
    }
}