class Scripture
{
    List<Word> _words;
    //TODO: add scripture reference
    ScriptureReference _reference;

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(bookName, chapter, verse);
        _words = ConvertToWords(text);
    }
    public Scripture(string bookName, int chapter, int verse, int endVerse, string text)
    {
        _reference = new ScriptureReference(bookName, chapter, verse, endVerse);
        _words = ConvertToWords(text);
    }

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWords(text);
    }

    public string GetScriptureReference()
    {
        return _reference.GetScriptureReference();
    }

    public bool HideWords()
    {
            
        for(int i =0 ;i<3;i++)
        {
            //make sure it can't pick a word that's already hidden for i
            Random hideWords = new Random();
            int wowrdCount = _words.Count;
            int index = hideWords.Next(wowrdCount);
            Word randomWord = _words[index];
            if(!randomWord.IsHidden())
            {
                randomWord.Hide();
            }
        }
        return(NumberOfHiddenWords()<_words.Count());
    }

    private int NumberOfHiddenWords()
    {
        int numberOfHiddenWords = 0;
        foreach(Word i in _words)
        {
            if(i.IsHidden())
            {
                numberOfHiddenWords += 1;
            }
        }
        return numberOfHiddenWords;
    }
    public void ShowScripture()
    {
        _reference.ShowReference();
        Console.WriteLine();
        foreach(Word word in _words)
        {
            word.Display();
        } 
    }

    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();

        string[] words = text.Split(' ');
        foreach(string word in words)
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }

        return tempWords;
    }
}