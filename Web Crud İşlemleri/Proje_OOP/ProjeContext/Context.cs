using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;

namespace Proje_OOP.ProjeContext
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DVC\\SQLEXPRESS ;database=DbNewOOPCore2;integrated security=true;trust server certificate=true");

        }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Customer> Customers { get; set; }  
        //public DbSet<Category> Categories { get; set; } 
    }
}
