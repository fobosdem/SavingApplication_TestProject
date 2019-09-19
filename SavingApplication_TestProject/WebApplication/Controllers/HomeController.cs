using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
	public class HomeController : Controller
	{

		DBconncet db = new DBconncet();

		// GET: Login
		[HttpGet]
		public ActionResult About()
		{
			//if (db.Users.Any())
			//{
			//	foreach (Users user in db.Users)
			//	{
			//		ViewBag.Message = $"DRASTYA: {user.ID} - {user.Name} - {user.Password} - \r\n";
			//	}
			//}
			return View(new Users());
		}

		[HttpPost]
		public ActionResult About(Users user)
		{

			
			return View("About");
		}

		public ActionResult Index()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}
		[HttpGet]
		public ActionResult Create()
		{
			if (db.Users.Any())
			{
				foreach (Users user in db.Users)
				{
					ViewBag.Message = $"DRASTYA: {user.ID} - {user.Name} - {user.Password} - \r\n";
				}
			}
			return View(new Users());
		}
		[HttpPost]
		public ActionResult Create(Users user)
		{

			db.Users.Add(user);
			db.SaveChanges();
				foreach (Users user1 in db.Users)
				{
					ViewBag.Message += $"DRASTYA: {user1.ID} - {user1.Name} - {user1.Password} - \r\n";
				}

			return RedirectToAction("Create");
		}
		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}