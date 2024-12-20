using demo.Models;
using Microsoft.EntityFrameworkCore;

namespace demo.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Pet> Pet { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>()
                .HasOne(p => p.Customer)
                .WithMany(c => c.Pets);                                                                                             
        }

        // Tôi sẽ trở thành một developer giỏi
    }
}
