using MiniEcommerce.Application.Common.Interfaces.Repositories;
using MiniEcommerce.Domain.Common;
using MiniEcommerce.Infrastructure.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Infrastructure.Data.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseAuditableEntity
    {
        private readonly MiniEcommerceDbContext _context;

        public WriteRepository(MiniEcommerceDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model, CancellationToken cancellationToken = default)
        {
            var entityEntry = await Table.AddAsync(model, cancellationToken);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> entities, CancellationToken cancellationToken = default)
        {
            await Table.AddRangeAsync(entities, cancellationToken);
            return true;
        }

        public bool Remove(T model)
        {
            var entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool RemoveRange(List<T> entities)
        {
            Table.RemoveRange(entities);
            return true;
        }

        public async Task<bool> RemoveAsync(string id, CancellationToken cancellationToken = default)
        {
            if (!Guid.TryParse(id, out var guid))
                throw new ArgumentException("Geçersiz ID formatı.", nameof(id));

            T model = await Table.FirstOrDefaultAsync(data => data.Id == guid, cancellationToken);
            if (model == null)
                return false;

            return Remove(model);
        }

        public bool Update(T model)
        {
            var entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
