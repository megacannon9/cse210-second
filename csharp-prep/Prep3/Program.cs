using System;

class Program
{
    static void Main(string[] args)
    {
        bool flag = true;

        Random rnd = new Random();
        int magicNumber = rnd.Next(1, 1000);

        Console.WriteLine("Try and guess the magic number like you didn't just input it.");

        while (flag == true)
        {
            string inputTwo = Console.ReadLine();
            int guessedNumber = int.Parse(inputTwo);

            if (guessedNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessedNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You have guessed the Magic Number. Congrats");
                flag = false;
            }
        }
    }
}