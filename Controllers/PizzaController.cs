using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using contoso_pizza.Models;
using contoso_pizza.Services;

namespace contoso_pizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {

        }

        // GET all action
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() =>
            PizzaService.GetAll();
        // queries all pizzas and returns in Json format.


        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);

            if(pizza == null)
                return NotFound();
            
            return pizza;
        }
        // returns single pizza by id.

        // POST action

        // PUT action

        // DELETE acti
    }
}