using System;
using System.Collections.Generic;
using Dapper;
using System.Linq;
using System.Text;
using Dental.Common.Repositories;
using Dental.Common.Entities;
using Infrastructure.Persistence.Relational.Connection;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Relational.Repositories
{
    public abstract class BaseRepository<TPrimaryKey, TEntity> : IBaseRepository<TPrimaryKey, TEntity> where TEntity : IBaseEntity
    {
        private readonly string _typeName = typeof(TEntity).Name;
        protected ConnectionSettings ConnectionSettings { get; }
        protected IConnectionFactory ConnectionFactory { get; }

        protected BaseRepository(
            ConnectionSettings connectionSettings,
            IConnectionFactory connectionFactory)
        {
            ConnectionSettings = connectionSettings;
            ConnectionFactory = connectionFactory;
        }

        public async Task<TPrimaryKey> InsertAsync(TEntity entity)
        {
            try
            {
                using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
                {
                    entity.ModifiedDate = DateTime.Now;
                    entity.CreatedDate = DateTime.Now;
                    return await connection.InsertAsync<TPrimaryKey, TEntity>(entity);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
            {
                entity.ModifiedDate = DateTime.Now;
                var entityUpdated = await connection.UpdateAsync(entity);
                return entityUpdated == 1;
            }
        }

        public async Task<bool> DeleteAsync(TPrimaryKey id)
        {
            using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
            {
                var entityDeleted = await connection.DeleteAsync<TEntity>(id);
                return entityDeleted == 1;
            }
        }

        public async Task<TEntity> GetAsync(TPrimaryKey id)
        {
            using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
            {
                return await connection.GetAsync<TEntity>(id);
            }
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
            {
                return (await connection.GetListAsync<TEntity>()).ToList();
            }
        }

        public async Task<int> GetAllCountAsync()
        {
            using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
            {
                return (await connection.RecordCountAsync<TEntity>());
            }
        }
    }
}
