using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating video instances
        Video video1 = new Video("Python for Beginners", "Tech Guru", 600);
        Video video2 = new Video("How to Cook Banku", "Foodie Delight", 480);
        Video video3 = new Video("Space Exploration 2025", "NASA Official", 900);
        Video video4 = new Video("Piano Chords Tutorial", "Music Academy", 720);

        // Adding comments to videos
        video1.AddComment(new Comment("Alice", "Great tutorial! Very helpful."));
        video1.AddComment(new Comment("Kwame", "Can you explain loops in more detail?"));
        video1.AddComment(new Comment("Kofi", "I finally understand Python, thanks!"));

        video2.AddComment(new Comment("Yaw", "This looks delicious!"));
        video2.AddComment(new Comment("Kwadjo", "Tried this recipe, it turned out amazing."));
        video2.AddComment(new Comment("Ama", "What type of ingredients did you use for the soup?"));

        video3.AddComment(new Comment("Grace", "Space exploration is so exciting!"));
        video3.AddComment(new Comment("Adwoa", "Can't wait to see humans on Mars."));
        video3.AddComment(new Comment("Ian", "Love the visuals in this video."));

        video4.AddComment(new Comment("Jack", "Very clear explanations, thanks!"));
        video4.AddComment(new Comment("Karen", "What brand of piano do you recommend?"));
        video4.AddComment(new Comment("Leo", "Struggling with the keys, any tips?"));

        // Storing videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Displaying all video information
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}