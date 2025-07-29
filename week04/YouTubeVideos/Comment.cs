using System.Security.Cryptography.X509Certificates;

public class Comment
{
    string _userName;
    string _text;

    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;
    }


    public string DisplayComment()
    {
        return $"{_userName}: {_text}";
    }
}