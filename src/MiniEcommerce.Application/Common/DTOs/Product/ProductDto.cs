using MiniEcommerce.Domain.ValueObjects;

namespace MiniEcommerce.Application.Common.DTOs.Product
{
    public class  ProductDto
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public Money Price { get; set; } = default!;
        public int Stock { get; set; }
    }
}