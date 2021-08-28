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
    }
}