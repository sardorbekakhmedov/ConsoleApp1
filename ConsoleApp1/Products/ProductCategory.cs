namespace ConsoleApp1.Products;

public class ProductCategory // : AuditableEntity, IHasDescription, IHasTmFiled
{
    public Guid ImageId { get; set; }
    public string? NameUz { get; set; }
    public string? NameRu { get; set; }
    public string? NameEn { get; set; }
    public ulong Tm { get; set; }
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }


   // public virtual Docs? Image { get; set; }
    public virtual ICollection<Product>? Products { get; set; }
}