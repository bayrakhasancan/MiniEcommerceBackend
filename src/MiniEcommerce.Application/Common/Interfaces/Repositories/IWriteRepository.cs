using MiniEcommerce.Domain.Common;

namespace MiniEcommerce.Application.Common.Interfaces.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseAuditableEntity
    {
        Task<bool> AddAsync(T model, CancellationToken cancellationToken = default);
        Task<bool> AddRangeAsync(List<T> entities, CancellationToken cancellationToken = default);
        bool Remove(T model);
        bool RemoveRange(List<T> entities);
        Task<bool> RemoveAsync(string id, CancellationToken cancellationToken = default);
        bool Update(T model);
        Task<int> SaveAsync(CancellationToken cancellationToken = default);
    }
}
