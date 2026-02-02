using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
          
          // I added a third class, to store Videos, loop and display the content 
          // of each video, i think it is simpler that way.


          // first Video Instance
        Video video1 = new Video();
        video1._author = "Charles Darwin";
        video1._title = "Theory Of Evolution";
        video1._videoLengthInSec = 3600;

        Comment comment1 = new Comment();
        comment1._name = "Cleopatra";
        comment1._commentText = "This is a comment!";
        video1.AddComment(comment1);
        Comment comment2 = new Comment();
        comment2._name = "Marcus Aurelius";
        comment2._commentText = "Marcus commented";
        video1.AddComment(comment2);
        Comment comment3 = new Comment();
        comment3._name = "Queen Elizabeth";
        comment3._commentText = "Evolution? ";
        video1.AddComment(comment3);
       
        

        // Second Video Instance
        Video video2 = new Video();
        video2._author = "Isaac Newton";
        video2._title = "Laws of Motion";
        video2._videoLengthInSec = 4800;
        Comment comment4 = new Comment();
        comment4._name = "Aristotle";
        comment4._commentText = "Universal Gravitation? ";
        video2.AddComment(comment4);
        Comment comment5 = new Comment();
        comment5._name = "Sphinx of Egypt";
        comment5._commentText = "Interesting";
        video2.AddComment(comment5);
        Comment comment6 = new Comment();
        comment6._name = "Julius Caesar";
        comment6._commentText = "What are those?";
        video2.AddComment(comment6);
        Comment comment7 = new Comment();
        comment7._name = "Diogenes";
        comment7._commentText = "Philosopy";
        video2.AddComment(comment7);
        
        
       // Third Video Instance
       Video video3 = new Video();
        video3._author = "Nikola Tesla";
        video3._title = "Alternating Current";
        video3._videoLengthInSec = 6400;
        Comment comment8 = new Comment();
        comment8._name = "Thomas Edison";
        comment8._commentText = "Electric power invention";
        video3.AddComment(comment8);
        Comment comment9 = new Comment();
        comment9._name = "Pyramid of Giza";
        comment9._commentText = "One of the wonders of the word";
        video3.AddComment(comment9);
        Comment comment10 = new Comment();
        comment10._name = "collossus of rhodes";
        comment10._commentText = "What are those?";
        video3.AddComment(comment10);
        Comment comment11 = new Comment();
        comment11._name = "Lighthouse of alexandria";
        comment11._commentText = "Jack sparrow";
        video3.AddComment(comment11);
       
            
        VideoCatalog Catalog = new VideoCatalog();
        Catalog.AddVideo(video1);
        Catalog.AddVideo(video2);
        Catalog.AddVideo(video3);
        Catalog.CatalogDisplay();
    }
}