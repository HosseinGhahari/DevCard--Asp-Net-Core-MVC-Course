using Microsoft.AspNetCore.Mvc;

namespace DevCard___MVC.ViewComponents
{
	public class ArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View("_Article");
		}

	}
}
