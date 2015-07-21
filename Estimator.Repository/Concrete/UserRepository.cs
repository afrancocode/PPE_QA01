using System.Collections.Generic;
using Estimator.Model.Abstract;
using Estimator.Model.Entities;

namespace Estimator.Repository.Concrete
{
    public class UserRepository : IUserRepository
    {
        private List<User> userContext;

        public UserRepository(PPDBDummyContext user)
        {
            userContext = user.users;
        }

        public IEnumerable<User> Users
        {
            get { return userContext; }
        }

        public void SaveUser(User user)
        {
            if (user.Id == 0)
            {
                userContext.Add(user);
            }
            else
            {
                User dbEntry = userContext.Find(m => m.Id == user.Id);
                if (dbEntry != null)
                {
                    dbEntry.Login = user.Login;
                    dbEntry.Name = user.Name;
                    dbEntry.Password = user.Password;
                    dbEntry.Role = user.Role;
                }
            }
        }

        public void DeleteUser(int id)
        {
            User dbEntry = userContext.Find(x => x.Id == id);
            userContext.Remove(dbEntry);
        }
    }
    }


    //Implementación para el Repository de la DB

    //public class UserRepository : IUserRepository
    //{
    //    private PPDBContext userContext = new PPDBContext();

    //    public IEnumerable<User> Users
    //    {
    //        get { return userContext.Users; }
    //    }
    //    public void SaveUser(User user)
    //    {
    //        if (user.Id == 0)
    //        {
    //            userContext.Users.Add(user);
    //        }
    //        else
    //        {
    //            User dbEntry = userContext.Users.Find(user.Id);
    //            if (dbEntry != null)
    //            {
    //                dbEntry.Login = user.Login;
    //                dbEntry.Name = user.Name;
    //                dbEntry.Password = user.Password;
    //                dbEntry.Role = user.Role;
    //            }
    //        }
    //        userContext.SaveChanges();
    //    }
    //}
