using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estimator.Model.Entities;

namespace Estimator.Model.Abstract
{
	interface IRoleRepository
	{
		IEnumerable<Role> Role { get; }
	}
}
