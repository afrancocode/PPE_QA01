using System.Data.Entity;
using Estimator.Model.Entities;

namespace Estimator.Repository.Concrete
{
    public class PPDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
