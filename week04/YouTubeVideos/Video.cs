public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments= new List<Comment>();

    public Video(string title, string author, int length, Comment comment)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments.Add(comment);
    }

    public int numberOfComments()
    {
        return _comments.Count();
    }
    
}