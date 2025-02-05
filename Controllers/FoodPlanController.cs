﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemekhaneCoreApi.Data;
using YemekhaneCoreApi.Entities;

namespace YemekhaneCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodPlanController : ControllerBase
    {
        private readonly DataContext _context;

        public FoodPlanController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodPlan>>> GetFoodPlans()
        {
            return await _context.FoodPlans.ToListAsync();
        }

        // /foodplan/2021-01-18T00:00:00
        [HttpGet("{dateTime}")]
        public async Task<ActionResult<FoodPlan>> GetFoodPlanPerDate(DateTime dateTime)
        {
            return await _context.FoodPlans.Where(u => u.Date == dateTime).FirstOrDefaultAsync();
        }

        [HttpPost("addupdatesingle")]
        public async void AddUpdateFoodPlan([FromBody] FoodPlan foodPlan)
        {
            if (await _context.FoodPlans.AnyAsync(u => u.Date == foodPlan.Date))
            {
                var existingFoodPlan = _context.FoodPlans.Where(u => u.Date == foodPlan.Date).FirstOrDefault();
                existingFoodPlan.Food1 = foodPlan.Food1;
                existingFoodPlan.Food2 = foodPlan.Food2;
                existingFoodPlan.Food3 = foodPlan.Food3;
                existingFoodPlan.Food4 = foodPlan.Food4;
                existingFoodPlan.Food5 = foodPlan.Food5;
                foodPlan = existingFoodPlan;
            }
            else
            {
                await _context.FoodPlans.AddAsync(foodPlan);
            }
            await _context.SaveChangesAsync();
        }

        [HttpPost("addupdatemultiple")]
        public async void AddUpdateFoodPlans([FromBody] FoodPlan[] foodPlanArray)
        {
            foreach (FoodPlan foodPlan in foodPlanArray)
            {
                if (await _context.FoodPlans.AnyAsync(u => u.Date == foodPlan.Date))
                {
                    var existingFoodPlan = _context.FoodPlans.Where(u => u.Date == foodPlan.Date).FirstOrDefault();
                    existingFoodPlan.Food1 = foodPlan.Food1;
                    existingFoodPlan.Food2 = foodPlan.Food2;
                    existingFoodPlan.Food3 = foodPlan.Food3;
                    existingFoodPlan.Food4 = foodPlan.Food4;
                    existingFoodPlan.Food5 = foodPlan.Food5;                    
                }
                else
                {
                    await _context.FoodPlans.AddAsync(foodPlan);
                }                
            }

            await _context.SaveChangesAsync();
        }
    }
}
