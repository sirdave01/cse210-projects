using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Video
{

    // This line of code stores the title of the video
    public string Title { get; set; }

    // this line of code stores the author of the video
    public string Author { get; set; }

    // this line of code stores the length of the video in seconds

    public int LengthInSeconds { get; set; }

    // this line of code stores the comments for the video

    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    // this line of code adds a comment to the video

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // this line of code returns the number of comments on the video

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}