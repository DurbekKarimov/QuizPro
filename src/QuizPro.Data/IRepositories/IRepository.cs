using QuizPro.Domain.Commons;

namespace QuizPro.Data.IRepositories;

public interface IRepository<TEntity> where TEntity : Auditable
{
    IQueryable<TEntity> SelectAll();
    Task<bool> DeleteAsync(long id);
    Task<TEntity> SelectByIdAsync(long id);
    Task<TEntity> InsertAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
}
