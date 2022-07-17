

using BurgerTimeApp.DataAccsess.Database;
using BurgerTimeApp.Domain.Entities;
using BurgerTimeApp.Domain.Repositories;

namespace BurgerTimeApp.DataAccsess.Repository
{
    public class BurgerRepository : IBurgerRepository
    {
        public IReadOnlyList<Burger> GetAllBurgers()
        {
            return BurgerDatabase.BURGERS;
        }
        public Burger GetBurger(int id)
        {
            return BurgerDatabase.BURGERS.SingleOrDefault(x => x.Id == id);
        }
        public IReadOnlyList<Burger> GetBurgers(Burger burger)
        {
            return BurgerDatabase.BURGERS.Where(x => x.Id == burger.Id).ToArray();
        }
    }
}
