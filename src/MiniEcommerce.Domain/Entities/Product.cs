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
