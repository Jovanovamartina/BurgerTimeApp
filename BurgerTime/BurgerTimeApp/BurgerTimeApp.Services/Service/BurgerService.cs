

using BurgerTimeApp.Domain.Entities;
using BurgerTimeApp.Domain.Repositories;
using BurgerTimeApp.Services.Mappers;
using BurgerTimeApp.ViewModels.Services;
using BurgerTimeApp.ViewModels.ViewModel.BurgerViewModel;

namespace BurgerTimeApp.Services.Service
{
    public class BurgerService : IBurgerService
    {
        private readonly IBurgerRepository _burgerRepository;
        public BurgerService(IBurgerRepository burgerRepository)
        {
            _burgerRepository = burgerRepository;
        }
        public IReadOnlyList<BurgerViewModel> GetAllBurgers()
        {
            IReadOnlyList<Burger> burgers = _burgerRepository.GetAllBurgers();
            return burgers.Select(x => x.ToBurgerViewModel()).ToArray();
        }
    }
}
