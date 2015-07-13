using System.Collections.Generic;
using Estimator.Model.Abstract;
using Estimator.Model.Concrete;
using Estimator.Model.Entities;


namespace Estimator.Repository.Concrete
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
