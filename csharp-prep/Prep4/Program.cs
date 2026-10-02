using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Give me a number. Type 0 to finish");
        string input = Console.ReadLine();
        int inputNumber = int.Parse(input);
        if (inputNumber != 0)
        {
            numbers.Add(inputNumber);
        }

        while (!numbers.Contains(0))
        {
            Console.WriteLine("Another number:");
            string input2 = Console.ReadLine();
            int inputNumber2 = int.Parse(input2);
            numbers.Add(inputNumber2);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The total sum of the numbers in your list is:{sum}");

        int countMinus = numbers.Count - 1;
        float avg = ((float)sum) / countMinus;
        Console.WriteLine($"The average of the numbers in your list is: {avg}");

        int max = 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The highest number in youe list is: {max}");

        Console.WriteLine("Numbers in your list:");
        foreach (int number in numbers)
        {
            if (number != 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}