using System.Runtime.CompilerServices;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private string _paragraph;
    private List<Comment> _comments= new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }
    public string DisplayText()
    {
        return $"TITLE: {_title}; AUTHOR: {_author}; LENGTH: {_length}; NUMBER OF COMMENTS: {NumberOfComments()}\nCOMMENTS\n{DisplayComment()}";
    }
    public string DisplayComment()
    {
        
        foreach (var item in _comments)
        {
            _paragraph += $"{item.DisplaySingleComment()} \n";
        }
        return _paragraph;
    }
    
    
}