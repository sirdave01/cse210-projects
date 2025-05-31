using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


// Public class Word to represent a word in the scripture that has a text and a boolean indicating if it is hidden

public class Word
{

    // adding encapsulation in the word class

    private string _text;

    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Initially, the word is not hidden
    }

    public void Hide()
    {
        _isHidden = true; // Set the word to hidden
    }

    public bool IsHidden()
    {
        return _isHidden; // Return the hidden status of the word
    }
    
    // calling the display text method

    public string GetWordText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length); // Return underscores if the word is hidden
        }
        else
        {
            return _text; // Return the actual word text if not hidden
        }
    }

    // Calling the method to check if the word is hidden

}