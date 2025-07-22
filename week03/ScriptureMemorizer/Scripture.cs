using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        Console.WriteLine(reference);
        string[] words = text.Split(" ");
        // foreach (string t in words)
        // {
        //     Console.WriteLine(t);
        // }

        foreach (string i in words)
        {
            Word newWord = new Word(i);
            _words.Add(newWord);

        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenWord = 0;

        while (hiddenWord < numberToHide)
        {
            int index = random.Next(_words.Count);
            Word word = _words[index];

            if (!word.IsHidden())
            {
                word.Hide();
                hiddenWord++;
            }

            Console.Clear();
        }
    }

    public string GetDisplayText()
    {
        StringBuilder displaytext = new StringBuilder();

        foreach (Word word in _words)
        {
            displaytext.Append($"{word.GetDisplayText()} ");
        }


        return $"{displaytext}";

    }
    

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }

        }

        return true;


    }
}