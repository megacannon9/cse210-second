class JournalEntry
{
    public string _date;

    public string _prompt;

    public string _response;

    public List<string> _promptList = new List<string>();

    public void DisplayEntry()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry()
    {
        _date = "October 7th, 2026";
        _promptList.Add("What did you do that was exciting today?");
        _promptList.Add("What was something the frustrated you today?");
        _promptList.Add("Who did you talk to today, and what about?");
        //make sure the generated prompt is saved with the response using save() 
        // and that it is displayed without being saved because the prompt won't have changed yet
        Random _randomPrompt = new Random();
        int index = _randomPrompt.Next(_promptList.Count);
        _prompt = _promptList[index];

        Console.WriteLine($"{_prompt}");
        _response = Console.ReadLine();
    }
}