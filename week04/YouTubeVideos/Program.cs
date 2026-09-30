// This is where to create the three videos, add four comments to each, put the video in a list, and display the results.
//Gladys Catayoc

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create the first video
        Video video1 = new Video("Learning C#", "Code Academy", 300);

        //Add comments to the first video
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot from this video."));
        video1.AddComment(new Comment("Diana", "Could you make more videos like this?"));

        //Create the second video
        Video video2 = new Video("Healthy Cooking Tips", "Chef John", 600);

        //Add comments to the second video
        video2.AddComment(new Comment("Eve", "These tips are really useful!"));
        video2.AddComment(new Comment("Frank", "I love Chef John's cooking style."));
        video2.AddComment(new Comment("Grace", "Thanks for sharing these recipes."));
        video2.AddComment(new Comment("Henry", "Can you make a video on dessert recipes?"));

        //Create the third video
        Video video3 = new Video("Beautiful Places to Visit", "Travel Enthusiast", 450);

        //Add comments to the third video
        video3.AddComment(new Comment("Ivy", "I want to visit all these places!"));
        video3.AddComment(new Comment("Jack", "This video inspired me to travel more."));
        video3.AddComment(new Comment("Karen", "Great recommendations for vacation spots."));
        video3.AddComment(new Comment("Leo", "I love the cinematography in this video."));

        //Put all videos in a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //Display each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine("------------------------------");
        }
    }
}