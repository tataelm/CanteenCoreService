using API.Entities;

namespace API.DTOs
{
    public class FoodDto
    {
        public int Id { get; set; }
        public FoodType FoodType { get; set; }
        public string Name { get; set; }
    }
}