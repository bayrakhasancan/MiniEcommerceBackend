using MiniEcommerce.Domain.Common;
using MiniEcommerce.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Domain.Entities
{
    public class Product : BaseAuditableEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public Money Price { get; set; } = default!;
        public int Stock { get; set; }
    }
}
