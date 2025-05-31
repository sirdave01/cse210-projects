using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Comment
{
    // this line of code stores the name of the person that comment

    public string Name { get; set; }

    // this line of code stores the text of the comment

    public string Text { get; set; }

    // this line of code stores the date and time of the comment

    public DateTime DateTime { get; set; }

    public Comment(string name, string text, DateTime dateTime)
    {
        Name = name;
        Text = text;
        DateTime = dateTime;
    }

    // this line of code returns the name of the person that commented

    public string GetName()
    {
        return Name;
    }
}