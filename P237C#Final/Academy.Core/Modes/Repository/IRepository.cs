

using Academy.Core.Modes.BaseModes;

namespace Academy.Core.Modes.Repository
{
    public interface IRepository<T> where T:BasModel
    {
        public Task AddAsync(T entity);
        public Task RemoveAsync(T entity);
        public Task<List<T>> GetAllAsync();
        public Task<List<T>> GetAllAsync(Func<T, bool> func);
        public Task<List<T>> GetAsync(Func<T, bool> func);





    }
}