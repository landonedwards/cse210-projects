using System.Reflection.PortableExecutable;

public class Word
{
    // attributes

    private string _text;
    private string _visibility;
    private List<string> _charInWord;

    // methods

    public Word(string text, string visibility = "visible")
    {
        _text = text;
        _visibility = visibility;

        _charInWord = new();
        
        foreach (char c in _text)
        {
            string character = c.ToString();

            _charInWord.Add(character);
        }
    }

    public void Hide()
    {
        for (int i = 0; i < _charInWord.Count(); i += 1)
        {
            _charInWord[i] = "_";
        }

        _visibility = "hidden";
    }

    public void Show()
    {
        if (_visibility == "hidden")
        {
            foreach (char c in _text)
            {
                string character = c.ToString();

                _charInWord.Add(character);
            }        
        }

        _visibility = "visible";
    }

    public bool IsHidden()
    {
        return _visibility == "hidden";
    }

    public string GetRenderedText()
    {
        string renderedText = string.Join("", _charInWord);
        return renderedText;
    }
}