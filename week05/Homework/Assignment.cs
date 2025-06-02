using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

//calling the assignment class to have some private methods as a base class
public class Assignment
{
    private string _studentName = " ";

    private string _topic = " ";

    // calling the constructor to initialize the student name and topic

    public Assignment(string studentName, string Topic)
    {
        _studentName = studentName;

        _topic = Topic;

    }

    // calling getters and setter to access the private variables

    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string Topic)
    {
        _topic = Topic;
    }

    // to get the summary of the student's name and topic

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}

