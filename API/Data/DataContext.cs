using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {       

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<FoodPlan> FoodPlans { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           base.OnModelCreating(builder);         
        }

    }
}