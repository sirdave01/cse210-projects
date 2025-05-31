using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// Public class Word to represent the reference and the list of words in the scripture

public class Scripture
{

    private Reference _reference;

    private List<Word> _words;

    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Word>();

        _random = new Random();

        string[] words = text.Split(' '); // Split the text into words

        foreach (string word in words)
        {
            _words.Add(new Word(word)); // Create Word objects for each word and add to the list
        }
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        var visibleWords = _words.FindAll(word => !word.IsHidden()); // Get the list of visible words

        if (visibleWords.Count == 0)
        {
            return; // If there are no visible words, return
        }

        int actualWordsToHide = Math.Min(numberOfWordsToHide, visibleWords.Count); // Ensure we don't try to hide more words than available

        for (int i = 0; i < numberOfWordsToHide && visibleWords.Count > 0; i++)
        {
            var word = visibleWords[_random.Next(visibleWords.Count)]; // Get a random visible word

            word.Hide(); // Hide the word

            visibleWords.Remove(word); // Remove the word from the list to avoid hiding it again
        }
    }

    public string GetScriptureText()
    {
        return $"{_reference.GetReferenceText()}\n{string.Join(" ", _words.Select(word => word.GetWordText()))}"; // Return the scripture text with reference and words
    }

    public bool IsCompletelyHidden()
    {
        return _words.TrueForAll(word => word.IsHidden()); // Check if all words are hidden
    }

    // public Scripture(Reference reference, string text)
    // {
    //     _reference = reference;
    //     _words = text.Split(' ').Select(word => new Word(word)).ToList(); // Split the text into words and create Word objects
    // }

    // public void HideRandomWord(int numberOfWordsToHide)
    // {
    //     Random random = new Random();

    //     var visibleWords = _words.Where(word => !word.IsHidden()).ToList(); // Get the list of visible words

    //     for (int i = 0; i < numberOfWordsToHide && visibleWords.Count > 0; i++)
    //     {
    //         int randomIndex = random.Next(visibleWords.Count); // Get a random index from the visible words

    //         visibleWords[randomIndex].Hide(); // Hide the word at the random index

    //         visibleWords.RemoveAt(randomIndex); // Remove the word from the list to avoid hiding it again
    //     }
    // }

    // public string GetScriptureText()
    // {
    //     return $"{_reference.GetReferenceText()} {string.Join(" ", _words.Select(word => word.GetWordText()))}"; // Return the scripture text with reference and words
    // }

    // public bool IsCompletelyHidden()
    // {
    //     return _words.All(word => word.IsHidden()); // Check if all words are hidden
    // }

}