using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Aplicação ASP.NET MVC - Diego";

			ViewBag.DataEHora = DateTime.Now;

			return View();
		}
	}
}
