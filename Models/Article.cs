namespace DevCard___MVC.Models
{
	public class Article
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }

        public Article(int id, string title, string text, string image)
        {
            Id = id;
            Title = title;
            Text = text;
            Image = image;
        }

    }
}
