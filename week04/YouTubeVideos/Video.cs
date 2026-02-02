using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Video
{
   public string _title;
   public string _author;
   public int _videoLengthInSec;
   public List<Comment> _comments= new List<Comment> ();

   public int CommentCount()
    {
       int number = 0;
        foreach (Comment item in _comments)
        {
            number += 1;
        }
        return number;
    }
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public void Display()
    {
        foreach (Comment item in _comments)
        {
            item.Display();
        }
    }
    public void VideoDisplay()
    {
        Console.WriteLine($"Title -> {_title}");
        Console.WriteLine($"Author -> {_author}");
        Console.WriteLine($"Length in Seconds -> {_videoLengthInSec}");
        Console.WriteLine("Comments.....");
        Display();
        Console.WriteLine("");

    }

}