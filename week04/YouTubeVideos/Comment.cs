public class Comment
{
    public string _name;
    public string _commentText;

    public string CollectComments()
    {
        return $"Username: {_name} Comment: {_commentText}";
    }
}