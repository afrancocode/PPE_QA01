﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estimator.Model.Entities;

namespace Estimator.Repository.Concrete
{
	public class PPDBDummyContext
	{
		public List<User> Users = new List<User>()
		{
			new User { Id = 1, Name="Doreen Mendez", Login="Doreen", Password="Dmendez", Role = PPRoleDummyContext.Pricer },
			new User { Id = 2, Name="Diana Escalante", Login="Diana", Password = "Descalante", Role = PPRoleDummyContext.Estimator },
			new User { Id = 3, Name= "Lina Borrego", Login ="Lina", Password ="Lborrego", Role = PPRoleDummyContext.Estimator }
		};
	}
}