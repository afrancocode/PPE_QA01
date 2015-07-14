using System.Web.Mvc;
using Estimator.Model.Abstract;


namespace Estimator.WebUI.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository Userrepository;

        public UserController(IUserRepository userRepository) {
            this.Userrepository = userRepository;
        }

        public ViewResult UserList() {
            return View(Userrepository.Users);
        }
    }
}