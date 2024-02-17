namespace DevCard___MVC.Models
{
	// these properties specify data of Project
	// part of the website form index page
	public class Project
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Client { get; set; }
        public string Image { get; set; }


		// for easier implementation we used a constructor
		// also implementation happen via a ViewComponents
		public Project(int id , string title , string text , string image, string client)
        {
            Id = id;
            Title = title;
            Text = text;
            Image = image;
			Client = client;
		}
    }
}
