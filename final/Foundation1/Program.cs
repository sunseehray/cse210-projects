using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ABSTRACTION");
        Console.WriteLine();

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("What I Learned from Living in a Rural Cottage - how I live a quiet peaceful life", "TheCottageFairy", 7.37);
        
        Comment video1Comment1 = new Comment("Kimi","This is what the old saying means about \"the planet doesn't need more successful people, the planet desperately need more storytellers, peace makers, healers, restorers and lovers of all kinds\"");
        Comment video1Comment2 = new Comment("Rio Buenaventura", "My depression brought me here, and your content really made sense. Thanks for inspiring us!");
        Comment video1Comment3 = new Comment("Deligracy", "this is a fantastic video");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);
        
        // Video 2
        Video video2 = new Video("How I budget and live simply - finances, living within means, and rural life ", "TheCottageFairy", 19.29);
        
        Comment video2Comment1 = new Comment("Donna","thanks to both of you! You both make it happen for yourselves and live a creative and intentional life together.");
        Comment video2Comment2 = new Comment("Natasha Rose", " I had to laugh when you explained how your candle collection tripled in size in 24 hours. It’s funny how we experience abundance with the things we really love - I had a similar experience with my herbal tea collection.");
        Comment video2Comment3 = new Comment("Dawn Bodine", "I absolutely loved the frozen items you hung outside!! So adorable");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("this is where I live", "TheCottageFairy", 6.9);

        Comment video3Comment1 = new Comment("Margarita Aguilar", "Who would of thought a 24 year old, living the life she has chosen on her own, could motivate and inspire so deeply a 64 year old who wishes to be like her “when she grows up”... thank you.");
        Comment video3Comment2 = new Comment("Bang Chanstolemyheart", "The fact that the deers aren't afraid of her is so crazy... thats beautiful");
        Comment video3Comment3 = new Comment("Michael Richardson", "What I have learned from this channel: it's ok for life to be slow, it's ok for life to be boring, it's ok for life to be simple, it's ok for life to be fun, it's ok for life to be easy.  While it is important that we take care of our work responsibilities and finances, these things do not need to, nor do they, define who we are.  Thank you for this important lesson, Paola.");
        Comment video3Comment4 = new Comment("Moonlight Cottage ASMR", "The new quality of your videos is absolutely stunning. It beautifully highlights your talent and sensibility. Breathtaking ! Thank you so much for sharing.");
        
        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);
        video3.ListComment(video3Comment4);

        videosList.Add(video3);

        foreach(Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}