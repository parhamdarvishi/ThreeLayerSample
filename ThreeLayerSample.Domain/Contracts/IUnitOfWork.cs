using System.Data.Entity;

namespace ThreeLayerSample.Domain.Contracts
{
    public interface IUnitOfWork
    {
        DbContext DbContext { get; }

        /// <summary>
        /// Get repository instance of an entity inside unit of work scope
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IGenericRepository<T> Repository<T>() where T : class;


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);


        Task BeginTransaction();
        Task CommitTrasnaction();
        Task RollbackTrasnaction();
    }
}
