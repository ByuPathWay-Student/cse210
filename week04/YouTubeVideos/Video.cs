public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    int GetCommentsNumber()
    {
        return _comments.Count();
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title} Author: {_author} Length(seconds): {_length} Number of comments: {GetCommentsNumber()}");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine(comment.CollectComments());
        }
    }
    
}