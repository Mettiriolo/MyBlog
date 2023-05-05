namespace MyBlog.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; } = "Mettiriolo";
        public string Content { get; set; }
        public string Excerpt { get; set; }

    }
}
