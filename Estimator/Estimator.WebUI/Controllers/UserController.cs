using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estimator.Model.Abstract;
using Estimator.Model.Entities;
using Estimator.Model.Concrete;


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