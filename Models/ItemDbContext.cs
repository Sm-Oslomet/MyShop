using Microsoft.EntityFrameworkCore;
using MyShop.Models;

namespace Myshop.models;

public class ItemDbContext : DbContext // inherits from DbContext
{
    public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options) // constructor
    {
        Database.EnsureCreated(); // creates an empty database incase it does not exist
    }

    public DbSet<Item> Items { get; set; }
}