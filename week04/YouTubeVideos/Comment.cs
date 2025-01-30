using System;

public class Comment
{
    public string Commenter { get; set; }
    public string Text { get; set; }

    public Comment(string commenter, string text)
    {
        Commenter = commenter;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Commenter}: {Text}";
    }
}