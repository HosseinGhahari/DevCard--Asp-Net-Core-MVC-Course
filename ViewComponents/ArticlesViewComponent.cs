using DevCard___MVC.Data;
using DevCard___MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard___MVC.ViewComponents
{
	// Here we use a ViewComponent for having control
	// of every single part of our website(Index page)and
	// Invoke Method do the Fill Opreation on model
	// also Data Come from Method of ArticleStore Class 
	// and pass it to Our Article view with return

	public class ArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var artcle = ArticleStore.GetArticles();
			return View("_Article",artcle);
		}

	}

}