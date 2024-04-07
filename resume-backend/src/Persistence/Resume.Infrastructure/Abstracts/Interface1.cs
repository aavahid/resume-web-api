using System.Linq.Expressions;

namespace Resume.Infrastructure.Abstracts
{
    public interface IAsyncRepository<T>
       where T : class
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression = null);
        Task<T> GetAsync(Expression<Func<T, bool>> expression = null, CancellationToken cancellationToken = default);
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
        Task<T> EditAsync(T entity, CancellationToken cancellationToken = default);
        void Remove(T entity);

        Task<int> SaveAsync(CancellationToken cancellationToken = default);

    }
}
