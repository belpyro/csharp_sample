using Microsoft.EntityFrameworkCore;
using SharpSample.Logic.Data;
using SharpSample.Logic.Models;
using System.Collections.Generic;
using System.Linq;

namespace SharpSample.Logic.Services
{
    public class PizzaManager
    {
        private PizzaContext _context;

        public PizzaManager()
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("Pizza_Db");

            _context = new PizzaContext(builder.Options);
        }

        public List<Pizza> GetAllPizzas()
        {
            return _context.Pizzas.ToList();
        }

        public Pizza GetPizzaById(int id)
        {
            return _context.Pizzas.FirstOrDefault(p => p.Id == id);
        }


        public decimal GetPriceById(int id)
        {
            var pizza = GetPizzaById(id);
            return pizza.Price;
        }
    }
}
