using Microsoft.EntityFrameworkCore;
using SharpSample.Logic.Models;

namespace SharpSample.Logic.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}
