using BurgerTimeApp.Domain.Entities;


namespace BurgerTimeApp.ViewModels.ViewModel.BurgerViewModel
{
    public class BurgerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public string Img { get; set; }
    }
}
