using CustomerModule.Entities;
using OrderModule.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public partial class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
    }
}