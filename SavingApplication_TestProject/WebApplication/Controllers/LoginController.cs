using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class LoginController: Controller
    {
		public static DBconncet db = new DBconncet();

        // GET: Login
		[HttpGet]
        public ActionResult Login()
        {
			if(db.Users.Any())
			{
				foreach (Users user in db.Users)
				{
					ViewBag.Message = $"DRASTYA: {user.ID} - {user.Name} - {user.Password} - \r\n";
				}
			}
            return View(new Users());
        }

		[HttpPost]
		public ActionResult Login(Users user)
		{
			db.Users.Add(user);
			return View();
		}
	}
}