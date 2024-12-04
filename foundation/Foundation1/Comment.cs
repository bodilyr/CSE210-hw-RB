public class Comment
{
//list member variables and their data types
    private string _name;
    private string _text;

//define parameters of Comment function
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }


//create a way to access member variable data without compromising Encapsulation "rules" with Get functions
    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }

}