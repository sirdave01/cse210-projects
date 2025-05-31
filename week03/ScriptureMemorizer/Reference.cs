using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// these lines of code calls the public class Reference and its methods
public class Reference
{
    // adding encapsulation in the reference class

    private string _book;

    private string _chapterAndVerse;

    public Reference(string book, string chapterAndVerse)
    {
        _book = book;
        _chapterAndVerse = chapterAndVerse;
    }

    public string GetReferenceText()
    {
        return $"{_book} {_chapterAndVerse}";
    }
    // private string _book;

    // private int _chapter;

    // private int _verse;

    // private int _endVerse;

    // // Public properties to access the private fields
    // public Reference(string book, int chapter, int verse)
    // {
    //     _book = book;
    //     _chapter = chapter;
    //     _verse = verse;
    //     _endVerse = verse;
    // }

    // public Reference(string book, int chapter, int verse, int endVerse)
    // {
    //     _book = book;
    //     _chapter = chapter;
    //     _verse = verse;
    //     _endVerse = endVerse;
    // }

    // // calling the display text method

    // public string GetReferenceText()
    // {
    //     if (_verse == _endVerse)
    //     {
    //         return $"{_book} {_chapter}:{_verse}";
    //     }
    //     else
    //     {
    //         return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    //     }
    // }
}