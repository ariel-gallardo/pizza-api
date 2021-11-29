using alkemy_challenge.Models;
using alkemy_challenge.Services;
using Microsoft.AspNetCore.Mvc;

namespace alkemy_challenge.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
        
    }

    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();
    
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id){
        var pizza = PizzaService.Get(id);
        return pizza != null ? pizza : NotFound();
    }

    [HttpPost]
    public IActionResult Create(Pizza pizza){
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Get),new {Id = pizza.Id,},pizza);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza){
        if(id != pizza.Id) return BadRequest();
            var existingPizza = PizzaService.Get(id);
        if(existingPizza == null) return NotFound();
            PizzaService.Update(pizza);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = PizzaService.Get(id);
        if(pizza == null) return NotFound();
        PizzaService.Delete(id);
        return NoContent();
    }
}