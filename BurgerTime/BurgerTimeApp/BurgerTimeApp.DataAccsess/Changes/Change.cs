using BurgerTimeApp.DataAccsess.Database.Context;


namespace BurgerTimeApp.DataAccsess.Changes
{
    public class Change : IChange
    {
        private readonly IBurgerDbContext _dbContext;
        public Change(IBurgerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
