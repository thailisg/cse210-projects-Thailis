using System;

public class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }

    public int NumberComments()
    {
        return _comments.Count;
    }

    public void AddCommentToList(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public string DisplayInformation()
    {
        return $"Title: {_title}, Author: {_author}, Length: {_lenght}sec, Comments: {NumberComments()}";
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetUserName()} : {comment.GetText()}");
        }
    }
}