namespace MiniEcommerce.Domain.Common
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public string? CreatedBy { get; init; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
    }
}