
using System.Data.Entity;
using ThreeLayerSample.Domain.Contracts;

namespace ThreeLayerSample.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public DbSet<T> Entities { get; }
        public DbContext DbContext { get; }

        public GenericRepository(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public Task AddItem(T item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task AddItemAsync(T item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public T GetItem()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetItemAsync()
        {
            throw new NotImplementedException();
        }
    }
}
