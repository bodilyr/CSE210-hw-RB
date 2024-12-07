public class MathAssignment : Assignment
{
    //member variables
    private string _textbookSection;
    private string _problems;

    //constructor to assign values to variables
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //methods/functions
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection}  Problems {_problems}";
    }
}