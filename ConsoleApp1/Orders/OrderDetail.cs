using ConsoleApp1.Products;

namespace ConsoleApp1.Orders;

public class OrderDetail // : AuditableEntity, IHasDescription
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; } 
    public uint Amount { get; set; }
    public decimal Price { get; set; }
   // public EOrderStatus Status { get; set; }
    public DateTime StartedAt { get; set; }
    public DateTime? EndAt { get; set; }
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }

    public virtual Product? Product { get; set; }
}