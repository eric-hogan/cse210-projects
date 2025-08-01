public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0; //default value

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

    }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}: {_verse}";
        }

        else
        {
            return $"{_book} {_chapter}: {_verse}-{_endVerse}";
        }
    }

    public override string ToString()
    {
        return GetDisplayText().ToString();
    }
}