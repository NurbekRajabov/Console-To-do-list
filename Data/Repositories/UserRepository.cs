using Data.DbContexts;
using Data.Entities;
using Data.IRepositories;
using Microsoft.EntityFrameworkCore;


namespace Data.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly AppDbContext _dbContext = new AppDbContext();
        private readonly ToDoList _toDoList = new ToDoList();
        public async Task<User> CreateAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _dbContext.Users.Include(u => u.ToDoLists).FirstOrDefaultAsync(u => u.Id == id);
            _dbContext.Users.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public IQueryable<User> SelectAll()
            => _dbContext.Users;

        public async Task<User> SelectByIdAsync(long id)
            => await _dbContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);


        public async Task<User> UpdateAsync(User user)
        {
            _dbContext.ChangeTracker.Clear();
            var model = (_dbContext.Update(user)).Entity;
            await _dbContext.SaveChangesAsync();

            return model;
        }

    }
}
