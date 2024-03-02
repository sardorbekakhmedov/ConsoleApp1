namespace ConsoleApp1.Products;

public class Product // : AuditableEntity, IHasDescription
{
    public Guid ProductCategoryId { get; set; }
    public Guid MainImageId { get; set; }
    public Guid RecipeId { get; set; }
    public uint? OrderInList { get; set; }
    public string? NameUz { get; set; }
    public string? NameRu { get; set; }
    public string? NameEn { get; set; }
    public decimal Price { get; set; }
    public decimal? DiscountPrice { get; set; }
    public bool IsAvailable { get; set; } = true;
    public bool IsPopular { get; set; }
    public bool IsNew { get; set; } = true;
    public ulong Tm { get; set; } // To store the creation time of the Product object in seconds, going back to 1970.
    public string? ClassCode { get; set; } // Field for tax
    public string? BarCode { get; set; } // Field for tax
    public string? IKPU { get; set; } // Field for tax
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }

    public virtual ProductCategory? ProductCategory { get; set; }
    public virtual Recipe? Recipe { get; set; }
    public virtual Discount? Discount { get; set; }
   // public virtual ICollection<Docs>? Images { get; set; }
}