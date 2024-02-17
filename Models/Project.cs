namespace DevCard___MVC.Models
{
	public class Project
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Client { get; set; }
        public string Image { get; set; }

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
