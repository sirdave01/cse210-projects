using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

public class WritingAssignment : Assignment
{
    private string _title = " ";

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Getter and setter for the private variable _title

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"{GetStudentName()} - {GetTopic()} - {_title}";
    }
}