using Microsoft.EntityFrameworkCore;
using MiniEcommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseAuditableEntity
    {
        DbSet<T> Table { get; }
    }
}
