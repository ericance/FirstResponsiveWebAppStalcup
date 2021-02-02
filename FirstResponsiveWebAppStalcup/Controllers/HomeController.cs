using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppStalcup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResponsiveWebAppStalcup.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.Age = 0;
			return View();
		}
		[HttpPost]
		public IActionResult Index(AgeModel model)
		{
			if(ModelState.IsValid)
			{
				ViewBag.Age = model.AgeThisYear();
			}
			else
			{
				ViewBag.Age = 0;
			}
			return View(model);
		}
	}
}
