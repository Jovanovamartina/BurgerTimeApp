

using BurgerTimeApp.Domain.Entities;

namespace BurgerTimeApp.Domain.Repositories
{
    public interface IBurgerRepository
    {
        IReadOnlyList<Burger> GetAllBurgers();
        Burger GetBurger(int id);
        IReadOnlyList<Burger> GetBurgers(Burger burger);
    }
}