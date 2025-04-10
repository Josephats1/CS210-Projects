using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Code in C#", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "Nice video!"));

        Video video2 = new Video("Understanding OOP", "Jane Smith", 900);
        video2.AddComment(new Comment("David", "Clear and concise."));
        video2.AddComment(new Comment("Emma", "Best tutorial ever."));
        video2.AddComment(new Comment("Frank", "Loved the examples!"));

        Video video3 = new Video("Introduction to Data Structures", "Michael Johnson", 1200);
        video3.AddComment(new Comment("Grace", "Super informative!"));
        video3.AddComment(new Comment("Hannah", "Well explained."));
        video3.AddComment(new Comment("Ian", "Very useful."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
