using EntitiesT.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessT.Concrete
{
    public class BaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = localhost; Database=TravelDb; Trusted_Connection=SSPI;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPost> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
