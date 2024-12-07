using System.Configuration.Assemblies;
using System.Reflection;

public class Video
{
    // attributes
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    // behaviors
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new();
    }

    public void AddComment(Comment comment1, Comment comment2, Comment comment3, Comment comment4) 
    {
        _comments.Add(comment1);
        _comments.Add(comment2);
        _comments.Add(comment3);
        _comments.Add(comment4);
    }

    public int ReturnNumOfComments()
    {   
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_title}\n{_author}\n{_length} seconds\n{ReturnNumOfComments()}");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetComment());
        }
    }

}