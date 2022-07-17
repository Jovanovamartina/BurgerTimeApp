


namespace BurgerTimeApp.Domain.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public Ingredient(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Ingredient()
        {

        }
    }
}
