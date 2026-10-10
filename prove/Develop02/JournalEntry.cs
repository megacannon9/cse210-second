class JournalEntry
{
    public string _date;

    public string _prompt;

    public string _response;

    public List<string> _promptList = new List<string>();

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

    public void DisplayEntry()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
    }

    public void SaveJournalEntry()
    {
        Console.WriteLine("Please enter a filename.");
        string _fileName = Console.ReadLine();
        string _fileDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string _filePath = Path.Combine(_fileDir, _fileName);
        string _allText = ($"\n\n{_date} \n{_prompt} \n{_response}");
        File.AppendAllText(_filePath, _allText);
        Console.WriteLine($"Your file is saved to {_filePath}");
        Console.WriteLine();
    }

    public void LoadJournalEntry()
    {
        Console.WriteLine("What is the path to your file?");
        string _filePathLoad = Console.ReadLine().Trim();
        bool topFlag = true;
        while (topFlag == true)
        {
            if (File.Exists(_filePathLoad))
            {
                string text = File.ReadAllText(_filePathLoad);
                Console.WriteLine(text);
                topFlag = false;
            }
            else
            {
                Console.WriteLine("Invalid file path");
                Console.WriteLine("What is the path to your file? (there should be no quotations around the filepath)");
                _filePathLoad = Console.ReadLine().Trim();
            }
        }
    }
}