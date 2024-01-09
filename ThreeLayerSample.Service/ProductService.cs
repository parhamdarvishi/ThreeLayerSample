using ThreeLayerSample.Domain.Contracts;
using ThreeLayerSample.Domain.Entities;
using ThreeLayerSample.Domain.Interfaces.Services;

namespace ThreeLayerSample.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddItem(Product product)
        {
            await _unitOfWork.Repository<Product>().AddItem(product);
        }

        public async Task DeleteItem(int id)
        {
            await _unitOfWork.Repository<Product>().DeleteItem(id);
        }

        public async Task<IList<Product>> GetAll()
        {
            return await _unitOfWork.Repository<Product>().GetAllAsync();
        }

        public async Task<Product> GetItem(int id)
        {
            return await _unitOfWork.Repository<Product>().GetItemAsync(id);
        }

        public Task UpdateItem(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
