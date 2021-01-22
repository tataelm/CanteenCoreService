using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
   // [ApiController]
    //[Route("api/[controller]")]
    public class FoodPlanController_deprecated : ControllerBase
    {
        private readonly DataContext _context;
        public FoodPlanController_deprecated(DataContext context)
        {
            _context = context;
        }


      /*  [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodPlan>>> GetFoodPlans()
        {
            var foodPlansList = await _context.FoodPlans
                            .Include(u => u.Foods)
                            .ThenInclude(x => x.FoodType)                                      
                            .ToListAsync();        

          
            return foodPlansList;    
        }*/

        // api/foodplan/2021-01-18T00:00:00
      /*  [HttpGet("{dateTime}")]
        public async Task<ActionResult<FoodPlan>> GetFoodPlanPerDate(DateTime dateTime)
        {
            //DateTime dateTime = 
            return await _context.FoodPlans.Where(u => u.Date == dateTime)
                    .Include(u => u.Foods)
                    .ThenInclude(x => x.FoodType)
                    .FirstOrDefaultAsync();            
        }*/



      /*  [HttpPost("addupdate")]
        public async void AddUpdateFoodPlan([FromBody] FoodPlan foodPlan)
        {    
            if (await _context.FoodPlans.AnyAsync(u => u.Date == foodPlan.Date))
            {
                var existingFoodPlan = _context.FoodPlans.Where(u => u.Date == foodPlan.Date).FirstOrDefault();
                existingFoodPlan.Foods = foodPlan.Foods;
                foodPlan = existingFoodPlan;
            }
            else
            {
                await _context.FoodPlans.AddAsync(foodPlan);                
                _context.Foods.AttachRange(foodPlan.Foods);               
            }    

            await _context.SaveChangesAsync();                      
              
        }*/


    }
}
