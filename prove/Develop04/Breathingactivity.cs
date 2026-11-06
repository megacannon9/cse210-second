using System;
using System.Diagnostics;

class BreathingActivity : Activity
{
    private const int BreatheInSeconds = 4;
    private const int BreatheOutSeconds = 6;

    public BreathingActivity()
        : base("Breathing",
               "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Each class owns its whole flow: the shared bookends come from the
    // base class, and the middle part is unique to this activity.
    public void Run()
    {
        DisplayStartingMessage();

        Stopwatch timer = Stopwatch.StartNew();

        do
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountdown(BreatheInSeconds);

            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountdown(BreatheOutSeconds);
            Console.WriteLine();
        } while (timer.Elapsed.TotalSeconds < GetDuration());

        DisplayEndingMessage();
    }
}