using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
   // [ApiController]
    //[Route("api/[controller]")]
    public class FoodTypeController : ControllerBase
    {
        private readonly DataContext _context;
         private readonly IMapper _mapper;
        public FoodTypeController(DataContext context,  IMapper mapper)
        {
            _context = context;
             _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodType>>> GetFoodTypes()
        {
          /* var foodTypes =  await _context.FoodTypes.ToListAsync();
            var foodTypesToReturn = _mapper.Map<IEnumerable<FoodTypeDto>>(foodTypes);
            return foodTypesToReturn;*/
            return await _context.FoodTypes.ToListAsync();
        }


        [HttpPost("addupdate")]
        public async void AddUpdateFoodType([FromBody] FoodType foodType)
        {
            var res = foodType;

            if (await _context.FoodTypes.AnyAsync(u => u.Id == foodType.Id))
            {
                var existingFoodType = _context.FoodTypes.Find(foodType.Id);
                existingFoodType.Name = res.Name;
                res = existingFoodType;
            }
            else
            {
                _context.FoodTypes.Add(foodType);
            }

            await _context.SaveChangesAsync();        
        }

    }
}