using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Estimator.Model.Entities;

namespace Estimator.WebUI.Infrastructure.Abstract
{
	public interface IAuthProvider
	{
		bool Authenticate(string username, string password);
	}
}