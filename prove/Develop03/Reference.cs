public class Reference
{
    // attributes

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // methods

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }

}

//     public void SetReference(string book, int chapter, int verse, int endVerse)
//     {
//         _book = book;
//         _chapter = chapter;
//         _verse = verse;
//         _endVerse = endVerse;
//     }
// }