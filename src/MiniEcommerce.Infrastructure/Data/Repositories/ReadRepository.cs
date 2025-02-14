using MiniEcommerce.Application.Common.Interfaces.Repositories;
using MiniEcommerce.Domain.Common;
using MiniEcommerce.Infrastructure.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Infrastructure.Data.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseAuditableEntity
    {
        private readonly MiniEcommerceDbContext _context;

        public ReadRepository(MiniEcommerceDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            return tracking ? Table : Table.AsNoTracking();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate, bool tracking = true)
        {
            var query = Table.Where(predicate);
            return tracking ? query : query.AsNoTracking();
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, bool tracking = true, CancellationToken cancellationToken = default)
        {
            var query = tracking ? Table : Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(predicate, cancellationToken);
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true, CancellationToken cancellationToken = default)
        {
            if (!Guid.TryParse(id, out var guid))
                throw new ArgumentException("Geçersiz ID formatı.", nameof(id));

            var query = tracking ? Table : Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(entity => entity.Id == guid, cancellationToken);
        }
    }
}
