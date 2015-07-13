using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estimator.Model.Entities;
using Estimator.Model.Abstract;

namespace Estimator.Model.Concrete
{
    public class UserRepository : IUserRepository
    {
        private PPDBContext userContext = new PPDBContext();

        
        public IEnumerable<User> Users
        {
            get { return userContext.Users; }
        }
    }
}
