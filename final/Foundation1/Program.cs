using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("the car", "by Carlos Chavez", 120);
        video1.addcomment("Melissa", "I love the video");
        video1.addcomment("Diego","love it ");
        video1.addcomment("Oscar","great");
        videos.Add(video1);



        Video video2 = new Video("the moon", "by Marcelo Carazo", 230);
        video2.addcomment("Melissa", "I love the video");
        video2.addcomment("Mauro","woowwww");
        video2.addcomment("vegeta","that was awesome");
        video2.addcomment("Edgar","love it");
        videos.Add(video2);

        Video video3 = new Video("the travel to the stars", "Guillermo Ochoa", 34 );
        video3.addcomment("Elanie","need more...");
        video3.addcomment("Ethan","fantastic");
        video3.addcomment("Camry","it was not good");
        video3.addcomment("Jen","really appreciate the video");
        videos.Add(video3);

        foreach(var videoList in videos )
        {
            Console.WriteLine($"title:{videoList._title}");
            Console.WriteLine($"author: {videoList._author}");
            Console.WriteLine($"length: {videoList._lenght}");
            Console.WriteLine($"Number of comments: {videoList.countComment()}");
            
            var comments = videoList.getcomment();
            foreach(var comment in comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }
            Console.WriteLine();
        }





        
    }

}