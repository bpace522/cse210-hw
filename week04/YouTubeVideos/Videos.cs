using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> Comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void GetDisplayText()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Channel: {_author}");
        Console.WriteLine($"Duration: {_length}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            comment.GetDisplayText();
        }
        Console.WriteLine(new string('-', 40));
    }
}