using System.Linq;
using System.Web.Mvc;
using Estimator.Model.Entities;
using Estimator.Model.Abstract;
using Estimator.WebUI.Infrastructure.Abstract;
using Estimator.WebUI.Infrastructure.Concrete;
using System.Web.Security;
using Estimator.WebUI.Models;

namespace Estimator.WebUI.Controllers
{
	public class AccountController : Controller
	{
		private IUserRepository userCollection;
		private IAuthProvider authorize;

		public AccountController(IUserRepository userRepository, IAuthProvider authorize)
		{
			this.userCollection = userRepository;
			this.authorize = authorize;
		}

		// GET: Login
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(LoginViewModel u)
		{
			if (ModelState.IsValid)
			{
				bool v_user = authorize.Authenticate(u.Login, u.Password);
				if (v_user)
				{
					Session["UserName"] = u.Login;
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
			System.Web.Security.FormsAuthentication.SignOut();
			Session.Abandon();
			return RedirectToAction("Index", "Home");
		}
	}
}