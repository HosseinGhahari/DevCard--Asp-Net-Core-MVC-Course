using DevCard___MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard___MVC.ViewComponents
{
	// Here we use a ViewComponent for having control
	// of every single part of our website and
	// Invoke Method do the Fill Opreation on model
	// and pass it to Our Article view with return

	public class ArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var artcle = new List<Article>
			{
				new Article(1, "آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی",
				"blog-post-thumb-card-1.jpg"),
				new Article(2, "آموزش Git & Github", "کاملترین پکیج آموزش Git & Github به زبان فارسی",
				"blog-post-thumb-card-2.jpg"),
				new Article(3, "آموزش Onion Architecture", "کاملترین پکیج آموزش Onion Architecture به زبان فارسی",
				"blog-post-thumb-card-3.jpg"),
			};

			return View("_Article",artcle);
		}

	}

}