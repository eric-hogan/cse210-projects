public class Word
{
    string _text;
    bool _isHidden;

    public Word(string text)
    {
        _text = text;
     
    }

    public void Hide()
    {

        // Random random = new Random();
        // randomIndex = random.Next(_words.Count);
        // Word randomWord = _words[randomIndex];
        // string randomWordAsString = randomWord.ToString();
        // randomWordAsString = "_";

        Console.WriteLine("words hidden");

    }

    public void Show()
    {

    }

    public bool IsHidden()
    {
        _isHidden = false;
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}