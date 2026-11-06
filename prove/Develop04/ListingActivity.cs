using System;
using System.Collections.Generic;
using System.Diagnostics;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _items = new List<string>();

    public ListingActivity()
        : base("Listing",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

        // In ListingActivity.cs — replaces the old RunActivity()
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomItem(_prompts)} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        _items.Clear();
        Stopwatch timer = Stopwatch.StartNew();

        while (timer.Elapsed.TotalSeconds < GetDuration())
        {
            Console.Write("> ");
            string entry = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(entry))
            {
                _items.Add(entry);
            }
        }

        Console.WriteLine($"\nYou listed {_items.Count} items!");

        DisplayEndingMessage();
    }
}