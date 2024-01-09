using ThreeLayerSample.Domain.Entities;

namespace ThreeLayerSample.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<IList<Product>> GetAll();
        Task<Product> GetItem(int id);
        Task AddItem(Product product);
        Task UpdateItem(Product product);
        Task DeleteItem(int id);
    }
}
