class Scripture
{
    private List<Word> _words;

    private ScriptureReference _reference;

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
        if(NumberOfHiddenWords() == _words.Count())
        {
            return false;
        }
        Random hideWords = new Random();
        for(int i=0;i<3;i++)
        {
            if(NumberOfHiddenWords() == _words.Count())
            {
                break;
            }
            int wordCount = _words.Count;
            int index = hideWords.Next(wordCount);
            Word randomWord = _words[index];
            while(randomWord.IsHidden())
            {
                index = hideWords.Next(wordCount);
                randomWord = _words[index];
            }
            randomWord.Hide();
        }
        // return NumberOfHiddenWords()<=_words.Count;
        return true;
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