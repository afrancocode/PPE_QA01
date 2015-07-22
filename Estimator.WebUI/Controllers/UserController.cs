using System.Linq;
using System.Web.Mvc;
using Estimator.Model.Abstract;
using Estimator.Model.Entities;

namespace Estimator.WebUI.Controllers
{
	public class UserController : Controller
	{
		private IUserRepository userCollection;

		public UserController(IUserRepository userRepository)
		{
			this.userCollection = userRepository;
		}

		public ViewResult UserList()
		{
			return View(userCollection.Users);
		}

        public ViewResult Edit(int id)
        {
            User user = userCollection.Users.FirstOrDefault(p => p.Id == id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                userCollection.SaveUser(user);
                TempData["message"] = string.Format("User {0} has been saved", user.Name);
                return RedirectToAction("UserList");
            }
            else
            {
                return View(user);
            }
        }

        public ActionResult Delete(int id)
        {
            userCollection.DeleteUser(id);
            TempData["message"] = string.Format("User successfully deleted");
            return RedirectToAction("UserList");
        }

        public ViewResult AddUser()
        {
            return View("AddUser", new User());
        }
    }
}