using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    public class FoodPlan
    {       
        public int Id { get; set; }
        public DateTime Date { get; set; }
        //public ICollection<Food> Foods { get; set; }
        public string Food1 { get; set; }
        public string Food2 { get; set; }
        public string Food3 { get; set; }
        public string Food4 { get; set; }
        public string Food5 { get; set; }
    }
}