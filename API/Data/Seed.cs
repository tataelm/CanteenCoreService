using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedFoodPlans(DataContext context)
        {
            if (await context.FoodPlans.AnyAsync()) return;

            var foodData = await System.IO.File.ReadAllTextAsync("Data/FoodTypeSeedData.json");
            var foodPlans = JsonSerializer.Deserialize<List<FoodPlan>>(foodData);
            
            await context.FoodPlans.AddRangeAsync(foodPlans);
            await context.SaveChangesAsync();
        }
    }
}