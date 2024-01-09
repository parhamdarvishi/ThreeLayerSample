
using System.Data.Entity;

namespace ThreeLayerSample.Domain.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        DbSet<T> Entities { get; }
        DbContext DbContext { get; }

        Task<IList<T>> GetAllAsync();

        Task<T> GetItemAsync(int id);

        T GetItem(int id);

        Task AddItemAsync(T item,bool saveChanges = true);

        Task AddItem(T item,bool saveChanges = true);

        Task DeleteItem(int id);
    }
}
