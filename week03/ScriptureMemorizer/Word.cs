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