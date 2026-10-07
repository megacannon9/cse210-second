class JournalEntry
{
    public string _date;

    public string _prompt;

    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry()
    {
        _date = "October 7th, 2026";
        //create list of prompts and random generator
        _prompt = " ";

        Console.WriteLine($"{_prompt}");
        _response = Console.ReadLine();
    }
}