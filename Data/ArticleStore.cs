using DevCard___MVC.Models;

namespace DevCard___MVC.Data
{
	// here we have 2 methods one to get all projects
	// other one to take the id from the project items
	// these methods are used for for sending data
	// and also id of project to Detail page

	public class ArticleStore
	{
		public static List<Article> GetArticles()
		{
			return new List<Article>
			{
				new Article(1, "آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی",
				"blog-post-thumb-card-1.jpg"),
				new Article(2, "آموزش Git & Github", "کاملترین پکیج آموزش Git & Github به زبان فارسی",
				"blog-post-thumb-card-2.jpg"),
				new Article(3, "آموزش Onion Architecture", "کاملترین پکیج آموزش Onion Architecture به زبان فارسی",
				"blog-post-thumb-card-3.jpg"),
			};
		}

		public static Article GetArticleBy(long id)
		{
			return GetArticles().FirstOrDefault(x =>x.Id == id);
		}
	}
}
