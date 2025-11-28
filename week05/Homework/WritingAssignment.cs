class WritingAssignment: Assignment
{
    private string _title;

    public WritingAssignment(string studentname, string topic, string title): base(studentname, topic)
    {
        _title = title;
    
    }

    public string GetWritingIformation()
    {
        return $"{_title} by {_studentName}";
    }
}