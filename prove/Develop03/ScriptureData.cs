public class ScriptureData
{
    private string _book;
    private int _chapter; 
    private int _startVerse;
    private int _endVerse;
    public string _text;

    public ScriptureData(string book, int chapter, int startVerse, int endVerse, string text)//this will create a new scripture object and constructor will pass
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _text = text;
    }
    public string GetBook()
    {
        return _book;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public int GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public int GetStartVerse()
    {
        return _startVerse;
    }

    public void SetStartVerse(int startVerse)
    {
        _startVerse = startVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }
}