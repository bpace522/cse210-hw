using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        var video1 = new Video("ASMR Video", "Funny ASMRtist", 8);
        video1.AddComment(new Comment("glorbunk223", "This is wonderful, thanks."));
        video1.AddComment(new Comment("luisgamercool2003", "pls subscribe to my channel too"));
        video1.AddComment(new Comment("Sbeven", "hey guys i love videos"));
        videos.Add(video1);

        var video2 = new Video("12 hour breakdwon of star wars: the phantom menace", "loafcarousel", 60 * 12);
        video2.AddComment(new Comment("glorbunk223", "This is wonderful, thanks."));
        video2.AddComment(new Comment("luisgamercool2003", "I sure do love star wars"));
        video2.AddComment(new Comment("bliggityblam", "Chelsea are the 2025 conference league winners"));
        videos.Add(video2);

        var video3 = new Video("You won't believe what happened to this guy?", "clickbait channel name idk", 9);
        video3.AddComment(new Comment("parmesean", "I love cheese"));
        video3.AddComment(new Comment("rigatoni", "I love noodles"));
        video3.AddComment(new Comment("marinara", "I love sauce"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.GetDisplayText();
        }

    }
}