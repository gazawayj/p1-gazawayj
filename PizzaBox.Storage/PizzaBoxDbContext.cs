using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<Pizza> Pizza { get; set; }
    public DbSet<Crust> Crust { get; set; }
    public DbSet<Size> Size { get; set; }
    public DbSet<Topping> Topping { get; set; }

    
    public PizzaBoxDbContext(DbContextOptions options) : base()
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Pizza>().HasData( new Pizza[]
      {
        //TODO: add toppings, crust, size, etc
        new Pizza()
      });
    }
  }
}