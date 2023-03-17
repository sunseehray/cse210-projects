using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("What I Learned from Living in a Rural Cottage - how I live a quiet peaceful life", "TheCottageFairy", 7.37);
        
        Comment video1Comment1 = new Comment("Kimi","This is what the old saying means about \"the planet doesn't need more successful people, the planet desperately need more storytellers, peace makers, healers, restorers and lovers of all kinds\"");
        video1.ListComment(video1Comment1);

        Comment video1Comment2 = new Comment("Rio Buenaventura", "My depression brought me here, and your content really made sense. Thanks for inspiring us!");
        video1.ListComment(video1Comment2);

        Comment video1Comment3 = new Comment("Deligracy", "this is a fantastic video");
        video1.ListComment(video1Comment3);

        videosList.Add(video1);
        
        // Video 2
        Video video2 = new Video(" How I budget and live simply - finances, living within means, and rural life ", "TheCottageFairy", 19.29);
        
        Comment video2Comment1 = new Comment("Donna","thanks to both of you! You both make it happen for yourselves and live a creative and intentional life together.");
        video2.ListComment(video2Comment1);

        Comment video2Comment2 = new Comment("Natasha Rose", " I had to laugh when you explained how your candle collection tripled in size in 24 hours. It’s funny how we experience abundance with the things we really love - I had a similar experience with my herbal tea collection. 🥰");
        video2.ListComment(video2Comment2);

        Comment video2Comment3 = new Comment("Dawn Bodine", "I absolutely loved the frozen items you hung outside!! So adorable");
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        foreach(Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}