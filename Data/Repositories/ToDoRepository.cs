using Data.DbContexts;
using Data.Entities;
using Data.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class ToDoRepository : IRepository<ToDoList>
    {
        private readonly AppDbContext _dbContext = new AppDbContext();
        public async Task<ToDoList> CreateAsync(ToDoList todo)
        {
            await _dbContext.ToDoLists.AddAsync(todo);
            return todo;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _dbContext.ToDoLists.FirstOrDefaultAsync(t => t.Id == id);
            _dbContext.ToDoLists.Remove(entity);
            return true;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public IQueryable<ToDoList> SelectAll()
        {
            return _dbContext.ToDoLists;
        }

        public Task<ToDoList> SelectByIdAsync(long id)
        {
            return _dbContext.ToDoLists.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<ToDoList> UpdateAsync(ToDoList t)
        {
            var model = _dbContext.Update(t);
            return model.Entity;
        }
    }
}
