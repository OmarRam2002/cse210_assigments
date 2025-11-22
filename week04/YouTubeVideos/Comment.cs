public class Comment
{
    private string _commentersName;
    private string _textOfComment;

    public Comment(string name, string text)
    {
        _commentersName = name;
        _textOfComment = text;
    }

    public string DisplaySingleComment()
    {
        return $"{_textOfComment}";
    }
}