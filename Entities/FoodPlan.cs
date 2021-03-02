using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekhaneCoreApi.Entities
{
    public class FoodPlan
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Food1 { get; set; }
        public string Food2 { get; set; }
        public string Food3 { get; set; }
        public string Food4 { get; set; }
        public string Food5 { get; set; }
    }
}
