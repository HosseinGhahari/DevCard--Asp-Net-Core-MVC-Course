using Microsoft.AspNetCore.Mvc;

namespace DevCard___MVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View("_Project");
		}
		
	
	}
}
