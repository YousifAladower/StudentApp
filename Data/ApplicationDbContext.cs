using Microsoft.EntityFrameworkCore;
using StudentApp.Modules.Domain;

namespace StudentApp.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly); ;
        }
        public DbSet<Student> Students { get; set; }


    }
}
