public class Video
{
//create member variables for the Video class
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

//initalize parameters for the Video function
    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

//method to add to Comment list
public void AddComment(Comment comment)
{
    _comments.Add(comment);
}

//method to return the number of comments
public int GetNumberOfComments()
{
    return _comments.Count;
}

//method to access comments in list
    public List<Comment> GetComments()
    {
        return _comments;
    }

//create a way to access member variable data without compromising Encapsulation "rules" with Get functions
    public string GetTitle()
    {
        return _title;
    }
    
    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthSeconds()
    {
        return _lengthSeconds;
    }

}