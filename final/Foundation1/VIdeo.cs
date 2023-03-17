using System;

public class Video 
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();
    public Video()
    {
        _title = "This is a title";
        _author = "Jane Doe";
        _length = 25;
    }
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void ListComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CountComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} minutes");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }
        
    }
}