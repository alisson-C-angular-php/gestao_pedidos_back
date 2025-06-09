using gestaopedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace gestaopedidos.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<OrdersModel> Orders { get; set; }
    }
}
