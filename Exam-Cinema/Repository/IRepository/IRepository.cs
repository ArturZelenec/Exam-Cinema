using System.Linq.Expressions;

namespace Exam_Cinema.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null);

        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter, ICollection<string> includeTables);


        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, bool tracked = true);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, ICollection<string> includeTables, bool tracked = true);


        Task CreateAsync(TEntity entity);

        Task RemoveAsync(TEntity entity);

        Task SaveAsync();
    }
}
