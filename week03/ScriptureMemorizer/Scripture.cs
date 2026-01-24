using System.Data;
using System.Runtime.CompilerServices;

public class Scripture
{
    Reference _reference;
    List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitText = text.Split(" ");
        _words = new List<Word>();
        foreach (string wordString in splitText)
        {
            Word word = new Word(wordString);
            _words.Add(word);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;
        do
        {
            Random randomWordHider = new Random();
            int index = randomWordHider.Next(0,_words.Count);
            if (!_words[index].IsHidden())
            {
               _words[index].Hide();
               hiddenCount++; 
            }
            if (this.IsCompletelyHidden())
            {
                hiddenCount = numberToHide;
            }
        }
        while (hiddenCount < numberToHide);
       
    }

    public string GetDisplayText()
    {
        string verse = _reference.GetDisplayText();
        string verseText = "";
        foreach (Word word in _words)
        {
            verseText = verseText + " " + word.GetDisplayText();
        }
        return $"{verse}{verseText}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
            
        }
        return true; 
    }
}