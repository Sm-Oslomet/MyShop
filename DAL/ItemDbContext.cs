using Microsoft.EntityFrameworkCore;
using MyShop.Models;

namespace MyShop.DAL;

public class ItemDbContext : DbContext // inherits from DbContext
{
    public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options) // constructor
    {
        // Database.EnsureCreated(); // creates an empty database incase it does not exist
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }
}