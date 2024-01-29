using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazingPizza.Data;

namespace BlazingPizza.Controllers;

[Route("pizzas")]
[ApiController]
public class PizzasController : Controller
{
    private readonly PizzaStoreContext _db;

    public PizzasController(PizzaStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Pizza>>> GetSpecials()
    {
        return (await _db.Pizzas.ToListAsync()).OrderByDescending(p => p.Price).ToList();
    }
}