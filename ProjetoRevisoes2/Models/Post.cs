namespace ProjetoRevisoes2.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Text { get; set; }
        public int Likes { get; set; }
        public DateTime Date { get; set; }
    }
}
