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
<<<<<<< HEAD
        _isHidden = true;
=======

        // Random random = new Random();
        // randomIndex = random.Next(_words.Count);
        // Word randomWord = _words[randomIndex];
        // string randomWordAsString = randomWord.ToString();
        // randomWordAsString = "_";

        Console.WriteLine("words hidden");

>>>>>>> 5128cea3be34a88e51c9bf4ab3e4b3d1180f05ea
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        // if (IsHidden())
        // {
        //     _text = "_________";
        // }
        return _isHidden ? "_______" :_text;
    }
}