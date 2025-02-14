
using MiniEcommerce.Application.Common.Interfaces.Repositories;

namespace MiniEcommerce.Application.Features.Queries.Product.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
    {
        IProductReadRepository _productReadRepository;

        public GetAllProductQueryHandler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _productReadRepository.GetAll(false).ToListAsync(cancellationToken);

            return new()
            {
                Products = products,
                TotalProductCount = products.Count
            };
        }
    }
}
