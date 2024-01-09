using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using ThreeLayerSample.Domain.Contracts;

namespace ThreeLayerSample.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext DbContext { get; private set; }
        private Dictionary<string, object> Repositories { get; }

        UnitOfWork(DbFactory dbFactory)
        {
            DbContext = dbFactory.DbContext;
            Repositories = new Dictionary<string, dynamic>();
        }


        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            var type = typeof(TEntity);
            var typeName = type.Name;
            lock (Repositories)
            {
                if (Repositories.ContainsKey(typeName))
                {
                    return (IGenericRepository<TEntity>)Repositories[typeName];
                }
                var repository = new GenericRepository<TEntity>(DbContext);
                Repositories.Add(typeName, repository);
                return repository;
            }
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
           return await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
