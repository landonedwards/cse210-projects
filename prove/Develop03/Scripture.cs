using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    // attributes

    private Reference _reference;
    private List<Word> _wordsInScripture;
    private List<int> _hiddenIndexes;

    // methods

    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        _wordsInScripture = new();
        _hiddenIndexes = new();

        foreach (string word in scripture.Split(" "))
        {
            Word newWord = new(word, "visible");

            _wordsInScripture.Add(newWord);
        }
    }

    public void HideWords()
    {
        Random randomWord = new Random();
        int hiddenCount = 0;

        int maxNumHidden = Math.Min(3, _wordsInScripture.Count - _hiddenIndexes.Count);

        while (hiddenCount < maxNumHidden)
            {
                int wordIndex = randomWord.Next(0, _wordsInScripture.Count);

                if (!_hiddenIndexes.Contains(wordIndex) && !_wordsInScripture[wordIndex].IsHidden())
                {
                    _wordsInScripture[wordIndex].Hide();
                    _hiddenIndexes.Add(wordIndex);
                    hiddenCount += 1;
                }
            }

    }

    public string GetRenderedText()
    {
        string renderedText = _reference.GetReference() + " ";

        foreach (Word word in _wordsInScripture)
        {
            renderedText += word.GetRenderedText() + " ";
        }

        return renderedText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _wordsInScripture)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }

}