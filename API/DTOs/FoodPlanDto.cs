using System;
using System.Collections.Generic;
using API.Entities;

namespace API.DTOs
{
    public class FoodPlanDto
    {
        public DateTime Date { get; set; }
        public ICollection<Food> Foods { get; set; }

    }
}