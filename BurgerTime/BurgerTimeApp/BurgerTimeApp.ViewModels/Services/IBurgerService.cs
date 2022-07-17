
using BurgerTimeApp.ViewModels.ViewModel.BurgerViewModel;

namespace BurgerTimeApp.ViewModels.Services
{
    public interface IBurgerService
    {
        IReadOnlyList<BurgerViewModel> GetAllBurgers();
    }
}
