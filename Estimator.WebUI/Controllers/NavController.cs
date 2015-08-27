using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estimator.Model.Entities;
using Estimator.Model.Abstract;
using Estimator.WebUI.Models;
using System.Web.Security;


namespace Estimator.WebUI.Controllers
{
    public class NavController : Controller
    {
		private IUserRepository userCollection;

		public NavController(IUserRepository userRepository)
		{
			this.userCollection = userRepository;
		}


		[Authorize]
		public PartialViewResult Menu()
		{
			var userLogged = System.Web.HttpContext.Current.User.Identity.Name;
			User userRole = userCollection.Users.FirstOrDefault(p => p.Login == userLogged);
			if (userRole.Role.Name == "Estimator")
			{
				IEnumerable<string> menuitems = new string[] { "Project_List", "Create_Project", "Sync_Project", "Edit" };
				return PartialView(menuitems);
			}
			else
			{
				IEnumerable<string> menuitems = new string[] { "Project_List", "Create_Project", "Sync_Project"};
				return PartialView(menuitems);
			}
	
		}

		public ActionResult Project_List()
		{
			return View();
		}

		public ActionResult Create_Project()
		{
			return View();
		}

		public ActionResult Sync_Project()
		{
			return View();
		}
    }
}