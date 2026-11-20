using System;
using System.Reflection.PortableExecutable;

class Program
{
    public static void Main(string[] args)
    {
     Video video1 = new Video("Learn C# in 10 Minutes", "Ezekiel Okon", 120);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Gladys", "Very helpful, thanks!"));
        video1.AddComment(new Comment("James", "I learned a lot from this video."));

        Video video2 = new Video("The black Panther", "Ezekiel Okon", 500);
        video2.AddComment(new Comment("Gratness", "Great video!"));
        video2.AddComment(new Comment("Eliaman", "Nice movie!"));
        video2.AddComment(new Comment("Elliot", "How do i get through season 2?"));

        Video video3 = new Video("Niger Story", "Ezekiel Okon", 1200);
        video3.AddComment(new Comment("Grace", "Interesting story!"));
        video3.AddComment(new Comment("Blessing", "Felt every line!"));
        video3.AddComment(new Comment("Stone", "We need to learn alot."));

        Video video4 = new Video("Study your CSS", "Ezekiel Okon", 400);
        video4.AddComment(new Comment("David", "How do i get your contact information?"));
        video4.AddComment(new Comment("John", "More of this please!"));
        video4.AddComment(new Comment("Adams", "It's a mind blowing video!"));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }


}