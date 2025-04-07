//Vinicius Ricardo Martins
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Product Review: Tech Gadget", "TechGuru", 300);
        video1.AddComment(new Comment("Alice", "Great review, very detailed!"));
        video1.AddComment(new Comment("Bob", "I’m buying this product now."));
        video1.AddComment(new Comment("Charlie", "Could you review more gadgets?"));
        videos.Add(video1);

       
        Video video2 = new Video("Cooking with Product X", "ChefMaster", 450);
        video2.AddComment(new Comment("Dana", "Loved the recipe!"));
        video2.AddComment(new Comment("Eve", "Product X looks amazing."));
        video2.AddComment(new Comment("Frank", "Can’t wait to try this."));
        videos.Add(video2);

       
        Video video3 = new Video("Fitness Gear Unboxing", "FitFan", 180);
        video3.AddComment(new Comment("Grace", "This gear is a game-changer."));
        video3.AddComment(new Comment("Hank", "Thanks for the unboxing!"));
        video3.AddComment(new Comment("Ivy", "Where can I get this?"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine(); 
        }
    }
}