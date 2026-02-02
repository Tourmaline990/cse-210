public class VideoCatalog
{
    public List<Video> _videos = new List<Video> ();

    public void AddVideo(Video newVideo )
    {
        _videos.Add(newVideo);
    }

    public void CatalogDisplay()
    {
        foreach (Video item in _videos)
        {
            item.VideoDisplay();
            Console.WriteLine($"Total Comments {item.CommentCount()}");
             Console.WriteLine("");
        }
    }

}