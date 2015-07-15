﻿using System.Linq;
using System.Web.Mvc;
using Estimator.Model.Entities;
using Estimator.Model.Abstract;
using Estimator.Repository.Concrete;

namespace Estimator.WebUI.Controllers
{
	public class AccountController : Controller
	{
		private IUserRepository userCollection;
		public AccountController(IUserRepository userRepository)
		{
			this.userCollection = userRepository;
		}

		// GET: Login
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(User u)
		{
			if (ModelState.IsValid)
			{
				var v_user = userCollection.Users.Where(c => c.Login.Equals(u.Login) && c.Password.Equals(u.Password)).FirstOrDefault();
				if (v_user != null)
				{
					Session["UserID"] = v_user.Id;
					Session["UserName"] = v_user.Name;
					return RedirectToAction("Index", "Home");
				}
				else
				{
					ModelState.AddModelError("", "Login or Password Data is incorrect!");
				}
			}
			return View();
		}

		public ActionResult Logout()
		{
			return RedirectToAction("Index", "Home");
		}
	}
}