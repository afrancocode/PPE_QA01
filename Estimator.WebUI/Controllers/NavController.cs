using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Estimator.WebUI.Controllers
{
    public class NavController : Controller
    {
		[Authorize]
		public PartialViewResult Menu()
		{
			IEnumerable<string> menuitems = new string[] { "Project_List", "Create_Project", "Sync_Project" };
			return PartialView(menuitems);
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