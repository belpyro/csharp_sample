using Microsoft.AspNetCore.Mvc;
using SharpSample.Logic.Services;

namespace SharpSample.Api.Controllers
{
    [Route("api/pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            var manager = new PizzaManager();
            return Ok(manager.GetAllPizzas());
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var manager = new PizzaManager();
            return Ok(manager.GetPizzaById(id));
        }

        [HttpGet("price/{id}")]
        public ActionResult GetPriceById(int id)
        {
            var manager = new PizzaManager();
            return Ok(manager.GetPriceById(id));
        }
    }
}
