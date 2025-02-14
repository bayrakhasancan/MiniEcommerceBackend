using MiniEcommerce.Application.Common.Interfaces.Repositories;
using MiniEcommerce.Domain.Entities;
using MiniEcommerce.Infrastructure.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Infrastructure.Data.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(MiniEcommerceDbContext context) : base(context)
        {

        }
    }
}
