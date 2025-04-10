using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int wordsHidden = 0;
        while (wordsHidden < count && !IsCompletelyHidden())
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}