using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

public class MathAssignment : Assignment
{
    private string _textbookSection = " ";

    private string _problems = " ";

    public MathAssignment(string studentName, string Topic, string textbookSection, string problems) : base(studentName, Topic)
    {

        _textbookSection = textbookSection;

        _problems = problems;
    }

    // getters and setters for the private variables

    public string GetTextbookSection()
    {
        return _textbookSection;
    }

    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"section {_textbookSection} Problems {_problems}";
    }
}