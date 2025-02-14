using MiniEcommerce.Domain.Common;
using System.Linq.Expressions;

namespace MiniEcommerce.Application.Common.Interfaces.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseAuditableEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, bool tracking = true, CancellationToken cancellationToken = default);
        Task<T> GetByIdAsync(string id, bool tracking = true, CancellationToken cancellationToken = default);
    }
}
