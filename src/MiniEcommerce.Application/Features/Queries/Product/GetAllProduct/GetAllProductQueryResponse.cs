namespace MiniEcommerce.Application.Features.Queries.Product.GetAllProduct
{
    public class GetAllProductQueryResponse
    {
        public int TotalProductCount { get; set; } = 0;
        public object? Products { get; set; }
    }
}