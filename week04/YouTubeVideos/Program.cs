using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();
        Video video1 = new Video();
        Comment comment1 = new Comment();
        
        video1._author = "Patches PaintingPro";
        video1._length = 1500;
        video1._title = "How to paint a wall.";
        
        comment1._name = "Jerry";
        comment1._commentText = "This was helpful.";
        video1._comments.Add(comment1);
        
        comment1 = new Comment();
        comment1._name = "Timmy B.";
        comment1._commentText = "I didn't find this video helpful.";
        video1._comments.Add(comment1);
        
        comment1 = new Comment();
        comment1._name = "Sasha";
        comment1._commentText = "Thank you for the video.";
        video1._comments.Add(comment1);
        
        videos.Add(video1);

        Video video2 = new Video();
        Comment comment2 = new Comment();

        video2._author = "Mr. Greg";
        video2._length = 300;
        video2._title = "Math made easy with Mr. Greg.";
        
        comment2._name = "Monique";
        comment2._commentText = "This video helped me understand math better.";
        video2._comments.Add(comment2);
        
        comment2 = new Comment();
        comment2._name = "Vinnie";
        comment2._commentText = "I don't get it.";
        video2._comments.Add(comment2);

        comment2 = new Comment();
        comment2._name = "Roberto Q.";
        comment2._commentText = "This helped me get a good grade.";
        video2._comments.Add(comment2);
        
        videos.Add(video2);

        Video video3 = new Video();
        Comment comment3 = new Comment();

        video3._author = "Mike";
        video3._length = 150;
        video3._title = "Best Cat Videos of 2010";
        
        comment3._name = "Shane";
        comment3._commentText = "This video made me laugh.";
        video3._comments.Add(comment3);
        
        comment3 = new Comment();
        comment3._name = "Pierre";
        comment3._commentText = "I like this.";
        video3._comments.Add(comment3);

        comment3 = new Comment();
        comment3._name = "Lewis";
        comment3._commentText = "I love cats!";
        video3._comments.Add(comment3);
        
        comment3 = new Comment();
        comment3._name = "Pam";
        comment3._commentText = "This made my day.";
        video3._comments.Add(comment3);
        
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }


    }
}