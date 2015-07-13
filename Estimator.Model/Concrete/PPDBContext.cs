using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estimator.Model.Entities;
using System.Data.Entity;

namespace Estimator.Model.Concrete
{
    public class PPDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
