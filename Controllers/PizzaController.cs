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
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
           PizzaService.Add(pizza);
           return CreatedAtAction(nameof(Create), new {id = pizza.Id}, pizza);
        }
        // Creates a new pizza

        // PUT action
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
           if(id != pizza.Id)
               return BadRequest();
            
            var existingPizza = PizzaService.Get(id);
            if(existingPizza is null)
                return NotFound();
            
            PizzaService.Update(pizza);

            return NoContent();
           
        }
        // This code will update the pizza and return a result

        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
         var pizza = PizzaService.Get(id);

         if (pizza is null)
             return NotFound();
         
         PizzaService.Delete(id);

         return  Content("go fuck your self");
          
        }
        // This code will delete the pizza and return a result
    }
}