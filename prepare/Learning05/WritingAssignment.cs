public class WritingAssignment : Assignment
{
    //member variables
    private string _title;

    //constructor to assign values to variable
    public WritingAssignment(string studentName, string topic, string title)
        : base (studentName, topic)
    {
        _title = title;
    }

    //method/function
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

    public string GetStudentName()
    {
        return GetSummary().Split(' ')[0];
    }
}