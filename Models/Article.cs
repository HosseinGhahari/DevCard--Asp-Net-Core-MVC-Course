namespace DevCard___MVC.Models
{
	// these properties specify data of article
	// part of the website form index page
	public class Article
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }


		// for easier implementation we used a constructor
		// also implementation happen via a ViewComponents
		public Article(int id, string title, string text, string image)
        {
            Id = id;
            Title = title;
            Text = text;
            Image = image;
        }

    }
}
