using MiniEcommerce.Domain.ValueObjects;

namespace MiniEcommerce.Application.Features.Commands.Product.CreateProduct
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public Money Price { get; set; } = default!;
        public int Stock { get; set; }
    }
}
