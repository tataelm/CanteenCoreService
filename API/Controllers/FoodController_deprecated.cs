using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    //[ApiController]
    //[Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly DataContext _context;
        public FoodController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Food>>> GetFoods()
        {
            return await _context.Foods
                        .Include(u => u.FoodType)
                        .ToListAsync();

        }

        [HttpPost("addfood")]
        public async void AddFood([FromBody] Food food)
        {
            if (await _context.Foods.AnyAsync(u => u.Name == food.Name)) return;
            _context.Foods.Add(food);
            _context.FoodTypes.Attach(food.FoodType);
            await _context.SaveChangesAsync();
        }
    }
}