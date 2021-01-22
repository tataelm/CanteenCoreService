
namespace API.Entities
{
    public class Food
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public FoodType FoodType { get; set; }
    }
}