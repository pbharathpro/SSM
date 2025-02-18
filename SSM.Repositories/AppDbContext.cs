using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSM.Repositories.Entity;

namespace SSM.Repositories
{

    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }

    }

}
