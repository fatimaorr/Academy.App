

using Academy.Core.Modes.BaseModes;
using Academy.Core.Repositories;


namespace Academy.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BasModel
    {
        List<T> data = new List<T>();
        public async Task AddAsync(T entity)
        {
            data.Add(entity);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return data;
        }

        public async Task<List<T>> GetAllAsync(Func<T, bool> func)
        {
            return data.Where(func).ToList();
        }

        public async Task<T> GetAsync(Func<T, bool> func)
        {
            return data.FirstOrDefault(func);
        }

        public async Task RemoveAsync(T entity)
        {
            data.Remove(entity);
        }
    }
}
