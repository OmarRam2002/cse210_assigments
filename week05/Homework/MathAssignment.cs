class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbooksection, string problem, string name, string topic): base(name, topic)
    {
       _problems = problem;
       _textbookSection = textbooksection; 
    }

    public string GetHomeworklist()
    {
        return $"{_textbookSection} {_problems}";
    }
}