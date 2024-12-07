public class Assignment
{
    //common member variables
    private string _studentName;
    private string _topic;

    //constructor to assign values to variables
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //common methods/functions
    public string GetSummary()
    {
        return $"{_studentName} -- {_topic}";
    }


}