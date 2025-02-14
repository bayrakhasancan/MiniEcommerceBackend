using MiniEcommerce.Domain.Common;

namespace MiniEcommerce.Application.Common.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseAuditableEntity
    {
        DbSet<T> Table { get; }
    }
}
