using System.Transactions;

public class Video
{
    string _title;
    string _author;
    int _length;
    List<Comment> _comment = new List<Comment>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void CreateCommentList(Comment comment)
    {
        _comment.Add(comment);
    }

    public void NumberOfComments()
    {
        Console.WriteLine($"Number of Comments {_comment.Count}");    
    
    }

    public void DisplayCommentList()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length}");

        foreach (Comment comment in _comment)
        {
            string commentText = comment.DisplayComment();
            Console.WriteLine(commentText);
        }

        
        
    }
}