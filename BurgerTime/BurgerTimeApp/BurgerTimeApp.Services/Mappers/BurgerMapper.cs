

using BurgerTimeApp.Domain.Entities;
using BurgerTimeApp.ViewModels.ViewModel.BurgerViewModel;

namespace BurgerTimeApp.Services.Mappers
{
    public static class BurgerMapper
    {
        public static BurgerViewModel ToBurgerViewModel(this Burger burger)
        {
            return new BurgerViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
                IsVegetarian = burger.IsVegetarian,
                IsVegan = burger.IsVegan,
                HasFries = burger.HasFries,
                Ingredients = burger.Ingredients,
                Img = burger.Img
            };
        }
        public static BurgerListViewModel ToBurgerListViewModel(this List<Burger> burgers)
        {
            return new BurgerListViewModel
            {
                Burgers = burgers.Select(x => x.ToBurgerViewModel()).ToList()
            };
        }
    }
}
