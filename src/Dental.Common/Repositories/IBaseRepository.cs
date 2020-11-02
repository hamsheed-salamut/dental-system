using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace Dental.Common.Repositories
{
    public interface IBaseRepository<TPrimaryKey, TEntity>
    {
        Task<TPrimaryKey> InsertAsync(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(TPrimaryKey id);
        Task<TEntity> GetAsync(TPrimaryKey id);
        Task<List<TEntity>> GetAllAsync();
        Task<int> GetAllCountAsync();
    }
}
