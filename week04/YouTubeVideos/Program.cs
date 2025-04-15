using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Tech Guru", 600);
        video1.AddComment(new Comment("Alice", "This video really helped me!"));
        video1.AddComment(new Comment("Bob", "Great content, thanks!"));
        video1.AddComment(new Comment("Charlie", "Very clear explanations."));
        videos.Add(video1);

        Video video2 = new Video("Object-Oriented Programming", "Code Master", 720);
        video2.AddComment(new Comment("Diana", "Nice breakdown of OOP."));
        video2.AddComment(new Comment("Ethan", "Loved the examples."));
        video2.AddComment(new Comment("Fiona", "Thanks for the video!"));
        videos.Add(video2);

        Video video3 = new Video("Understanding Abstraction", "Dev Ninja", 480);
        video3.AddComment(new Comment("George", "This clarified so much!"));
        video3.AddComment(new Comment("Hannah", "Now I get it."));
        video3.AddComment(new Comment("Ian", "Appreciate the effort."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}

