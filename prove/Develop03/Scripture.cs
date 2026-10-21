class Scripture
{
    List<Word> _words;
    //TODO: add scripture reference


    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWords(text);
    }
    public Scripture(string bookName, int chapter, int verse, int endVerse, string text)
    {
        // add ScriptureReference here. Use bookName, chapter and verse to create scripture reference
        _words = ConvertToWords(text);
    }

    public void ShowScripture()
    {
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