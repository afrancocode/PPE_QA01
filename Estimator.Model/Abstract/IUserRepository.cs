using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estimator.Model.Entities;

namespace Estimator.Model.Abstract
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; }

        void SaveUser(User user);

        void DeleteUser(int id);
    }
}
