

namespace BurgerTimeApp.DataAccsess.Changes
{
    public interface IChange
    {
        Task<int> SaveChangesAsync();
    }
}
