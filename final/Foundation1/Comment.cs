public class Comment
{
    // attributes
    private string _name;
    private string _content;

    // behaviors

    public Comment(string name, string content)
    {
        _name = name;
        _content = content;
    }

    public string GetComment()
    {
        return $"{_name}: {_content}";
    }
}