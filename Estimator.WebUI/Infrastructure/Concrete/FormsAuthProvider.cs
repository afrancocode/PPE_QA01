using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Estimator.WebUI.Infrastructure.Abstract;
using Estimator.Model.Entities;
using Estimator.Model.Abstract;


namespace Estimator.WebUI.Infrastructure.Concrete
{
	public class FormsAuthProvider : IAuthProvider
	{
		private IUserRepository Repo;

		public FormsAuthProvider(IUserRepository repo)
		{
			this.Repo = repo;
		}

		public bool Authenticate(string username, string password)
		{
			var user = this.Repo.Users.Where(c => c.Login.Equals(username) && c.Password.Equals(password)).FirstOrDefault();
			if (user != null)
			{
				FormsAuthentication.SetAuthCookie(username, false);
				return true;
			}
			else
			{
				return false;
			}
			
		}
	}
}