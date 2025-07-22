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
        _isHidden = true;
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