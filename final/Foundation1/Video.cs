using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length) {
        _comments = new List<Comment>();
        _title = title;
        _author = author;
        _length = length;
    }

    public void newComment(string name, string text) {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public void display()
    {
        Console.WriteLine(_title + "; by " + _author + ", " + _length + "s\n" + _comments.Count() + " comments:");

        for (int i = 0; i < _comments.Count(); i++) {
            Console.WriteLine(_comments[i].getString());
        }
    }
}