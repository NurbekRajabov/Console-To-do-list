using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> CreateAsync(T t);
        Task<T> SelectByIdAsync(long id);
        Task<bool> DeleteAsync(long id);
        Task<T> UpdateAsync(T t);
        IQueryable<T> SelectAll();
    }
}
