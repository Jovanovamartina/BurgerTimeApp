

using BurgerTimeApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BurgerTimeApp.DataAccsess.Database.Context
{
    public class BurgerDbContext : DbContext, IBurgerDbContext
    {
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public BurgerDbContext(DbContextOptions<BurgerDbContext> options) : base(options)
        {

        }
    }
}
