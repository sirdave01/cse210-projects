using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        //    this line of code creates 4 videos with comments with the commentors names and text


        var videos = new List<Video>
        {

            new Video("video1", "author1", 300),
            new Video("video2", "author2", 600),
            new Video("video3", "author3", 900),
            new Video("video4", "author4", 1200)


        };

        // this line of code adds comments to the videos
        videos[0].AddComment(new Comment("Alice", "Great video!", DateTime.Now));
        videos[0].AddComment(new Comment("Bob", "Very informative.", DateTime.Now));
        videos[0].AddComment(new Comment("Charlie", "Loved it!", DateTime.Now));
        videos[0].AddComment(new Comment("David", "Thanks for sharing!", DateTime.Now));

        videos[1].AddComment(new Comment("Eve", "Nice content!", DateTime.Now));
        videos[1].AddComment(new Comment("Frank", "I learned a lot.", DateTime.Now));
        videos[1].AddComment(new Comment("Grace", "Keep it up!", DateTime.Now));
        videos[1].AddComment(new Comment("Heidi", "Very helpful.", DateTime.Now));

        videos[2].AddComment(new Comment("Ivan", "Amazing video!", DateTime.Now));
        videos[2].AddComment(new Comment("Judy", "I really enjoyed this.", DateTime.Now));
        videos[2].AddComment(new Comment("Karl", "Great explanation.", DateTime.Now));
        videos[2].AddComment(new Comment("Leo", "This was awesome!", DateTime.Now));

        videos[3].AddComment(new Comment("Mallory", "Fantastic video!", DateTime.Now));
        videos[3].AddComment(new Comment("Nina", "Very engaging.", DateTime.Now));
        videos[3].AddComment(new Comment("Oscar", "I appreciate the effort.", DateTime.Now));
        videos[3].AddComment(new Comment("Peggy", "This was very useful.", DateTime.Now));

        // this line of code displays the video information and the number of comments on each video

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.LengthInSeconds} seconds, Comments: {video.GetCommentCount()}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.Text} ({comment.DateTime})");
            }
            Console.WriteLine();
        }

    }
}