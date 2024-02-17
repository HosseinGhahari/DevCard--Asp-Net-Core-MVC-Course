using DevCard___MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace DevCard___MVC.Controllers
{
	public class HomeController : Controller
	{
		// this list is responsible for data of
		// ServiceItems property that is a list
		// in contact model

		private readonly List<SerivceName> _serviceName = new List<SerivceName>() 
		{
			new SerivceName(1,"برنز"),
			new SerivceName(2,"نقره ای"),
			new SerivceName(3,"طلایی"),
			new SerivceName(4,"اینتراستالر")	
		};


		// this action is for showing index page
		public IActionResult Index()
		{
			return View();
		}


		// this action is for showing contact page
		// also here we fill out the ServiceItems from
		// the list we provided and dropdown list will
		// have that list's data
		[HttpGet]
		public IActionResult Contact()
		{
			var items = new Contact
			{	
				ServiceItems = new SelectList(_serviceName,"Id","Name")
			};

			return View(items);
		}


		// for sending message we need httpPost
		// so we take the Contact model and give
		// to the action throw a parameter	then
		// before post we check that form for validation
		// is correctly filled then we do post action
		// also we use viewbag for sending data to view 
		// also we need to fill out the ServiceItem again
		// whenever it's valid or not or when message is sent
		// dropdown list should be filled again 

		[HttpPost]
		public IActionResult Contact(Contact form)
		{
			form.ServiceItems = new SelectList(_serviceName, "Id", "Name");

			if(ModelState.IsValid)
			{
				ViewBag.error = "عملیات با خطا مواجه شد";
				return View(form);
			}

			var model = new Contact
			{
				ServiceItems = new SelectList(_serviceName, "Id", "Name")
			};

			ModelState.Clear();
			ViewBag.success = "پیام با موفقیت ارسال شد";
			return View(model);
		}

	}
}