namespace ConsoleApp1.Products;

public class Discount // : AuditableEntity, IHasDescription
{
    public Guid ProductId { get; set; }
    public float Percent { get; set; }
    public DateTime StartedDate { get; set; }
    public DateTime EndDate { get; set; }
    public ulong Tm { get; set; } //  To store the creation time of the Discount object in seconds, going back to 1970.
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }

    public virtual Product? Product { get; set; }
}