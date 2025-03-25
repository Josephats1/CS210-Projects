// --------------------------------------------------------
// Scripture Memorization Program
// Author: Baluku Josephats, Software Dev Student BYUI
// Date: 20, mar 2025
// Purpose: A simple console-based program that helps users
//          memorize scriptures by progressively hiding words.
// --------------------------------------------------------
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, 
            "For God so loved the world that he gave his only begotten Son, " +
            "that whosoever believeth in him should not perish, but have everlasting life.");

        Console.Clear();
        Console.WriteLine("Scripture Memorization Game");
        Console.WriteLine("===========================\n");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            scripture.HideRandomWords(3); // Hide 3 words at a time

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("You have fully memorized the scripture!\n");
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }

        Console.WriteLine("\nThank you for using the Scripture Memorizer Program!");
    }
}

// Class to represent a scripture reference
class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int Verse { get; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public string GetDisplayText()
    {
        return $"{Book} {Chapter}:{Verse}";
    }
}

// Class to handle scripture text and word hiding logic
class Scripture
{
    private Reference _reference;
    private string _originalText;
    private List<string> _words;
    private HashSet<int> _hiddenIndices;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _originalText = text;
        _words = new List<string>(text.Split(' '));
        _hiddenIndices = new HashSet<int>();
    }

    public string GetDisplayText()
    {
        string displayText = "";
        for (int i = 0; i < _words.Count; i++)
        {
            if (_hiddenIndices.Contains(i))
            {
                displayText += "_____ ";
            }
            else
            {
                displayText += _words[i] + " ";
            }
        }
        return $"{_reference.GetDisplayText()}\n{displayText.Trim()}";
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hiddenWords = 0;
        while (hiddenWords < count && _hiddenIndices.Count < _words.Count)
        {
            int index = rand.Next(_words.Count);
            if (!_hiddenIndices.Contains(index))
            {
                _hiddenIndices.Add(index);
                hiddenWords++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        return _hiddenIndices.Count == _words.Count;
    }
}