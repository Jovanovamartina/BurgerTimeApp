

namespace BurgerTimeApp.Domain.Entities
{
    public class Burger : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public string Img { get; set; }

        public Burger(int id, string name, decimal price, bool isVegetarian, bool isVegan, bool hasFries, List<Ingredient> ingredients, string img)
        {
            Id = id;
            Name = name;
            Price = price;
            IsVegetarian = isVegetarian;
            IsVegan = isVegan;
            HasFries = hasFries;
            Ingredients = ingredients;
            Img = img;
        }

        public Burger()
        {

        }
    }
}
