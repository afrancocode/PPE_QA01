using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estimator.Model.Entities;

namespace Estimator.Repository.Concrete
{
	public class PPRoleDummyContext
	{
		public List<Role> Roles = new List<Role>(){
			Pricer,
			Estimator
		};

		internal static Role Pricer = new Role { Id = 1, Name = "Pricer" };
		internal static Role Estimator = new Role { Id = 2, Name = "Estimator" };
	}
}
