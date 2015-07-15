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
        public ViewResult Edit(int UserId)
        {
            User user = userCollection.Users.FirstOrDefault(p => p.Id == UserId);
            return View(user);
        }
	}
}