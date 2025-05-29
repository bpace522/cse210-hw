using System;

public class Comment
{
    public string _acc_name;
    public string _content;

    public Comment(string acc_name, string content)
    {
        _acc_name = acc_name;
        _content = content;
    }

    public void GetDisplayText()
    {
        Console.WriteLine($"'{_content}' commented by: {_acc_name}");
    }
}