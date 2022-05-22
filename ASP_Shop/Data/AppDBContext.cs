using ASP_Shop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace ASP_Shop.Data
{
    public class AppDBContext : DbContext
    {   
        protected readonly IConfiguration Configuration;   
        //public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        //{
        //    Database.EnsureCreated();
        //}        

        public AppDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
