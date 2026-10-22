using System.Reflection.Metadata.Ecma335;

class ScriptureReference
{
    private string _bookName;

    private int _chapter;

    private int _verse;

    private int _endVerse;


    //getter for each variable
    public string GetScriptureReference()
    {
        return GetScriptureReferenceString();
    }

    public ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }
    public ScriptureReference(string name, int chapter, int verse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public void ShowReference()
    {
        Console.Write(GetScriptureReference());
    }

    private string GetScriptureReferenceString()
    {
        string returnReferenceString;
        if(_endVerse == -1)
        {
            returnReferenceString = $"{_bookName} {_chapter}:{_verse}";
        }
        else
        {
            returnReferenceString = $"{_bookName} {_chapter}:{_verse}-{_endVerse}";
        }
        return returnReferenceString;
    }
}