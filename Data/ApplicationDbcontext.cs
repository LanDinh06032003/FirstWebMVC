using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models;
using FirstWebMVC.Controllers;

namespace FirstWebMVC.Data {
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employee { get; set; }


    }
}