using System;

class Program
{
    static void Main(string[] args)
    { 
        WelcomeMessage();
        string userName = UserInputName();
        int userNumber = UserInputNumber();
        int squared = NumberSquared(userNumber);
        int userBirth = BirthYear();
        int age = UserAge(userBirth);
        FinalDisplay(userName, squared, age);
    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string UserInputName()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();

        return userName;
    }

    static int UserInputNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string userNumberInput = Console.ReadLine();
        int userNumber = int.Parse(userNumberInput);

        return userNumber;
    }

    static int BirthYear()
    {
        Console.WriteLine("What is your birth year?");
        string userBirthInput = Console.ReadLine();
        int userBirth = int.Parse(userBirthInput);

        return userBirth;
    }

    static int NumberSquared(int userNumber)
    {
        int squared = userNumber * userNumber;
        return squared;
    }

    static int UserAge(int userBirth)
    {
        int age = 2025 - userBirth;
        return age;
    }

    static void FinalDisplay(string userName, int squared, int age)
    {
        Console.WriteLine($"{userName}, your number squared is {squared}.");
        Console.WriteLine($"{userName}, you will be {age} this year.");
    }
}