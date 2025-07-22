using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Scripture
{
    Reference _reference;
    public List<Word> _words = new List<Word>();

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

<<<<<<< HEAD
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
=======
        for (int i = 0; i < numberToHide; i++)
        {

            Random random = new Random();
            int randomIndex = random.Next(_words.Count);
            Word randomWord = _words[randomIndex];
            randomWord.Hide();
    

        } 
        
>>>>>>> 5128cea3be34a88e51c9bf4ab3e4b3d1180f05ea
    }

    public string GetDisplayText()
    {
        StringBuilder displaytext = new StringBuilder();

        foreach (Word word in _words)
        {
            displaytext.Append($"{word.GetDisplayText()} ");
        }

<<<<<<< HEAD

        return $"{displaytext}";

=======
        return displaytext.ToString();

    
>>>>>>> 5128cea3be34a88e51c9bf4ab3e4b3d1180f05ea
    }
    

    public bool IsCompletelyHidden()
    {
<<<<<<< HEAD
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }

        }

        return true;


=======

        return false;
>>>>>>> 5128cea3be34a88e51c9bf4ab3e4b3d1180f05ea
    }
}