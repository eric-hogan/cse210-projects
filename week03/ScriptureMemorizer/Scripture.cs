public class Scripture
{
    Reference _reference;
    List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        Console.WriteLine($"{reference} {text}");
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "program complete";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}