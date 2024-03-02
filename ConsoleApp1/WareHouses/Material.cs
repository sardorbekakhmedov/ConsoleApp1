namespace ConsoleApp1.WareHouses;

public class Material // : AuditableEntity, IHasDescription
{ 
    public Guid ImageId { get; set; }
    public Guid MaterialCategoryId { get; set; }
    public EMeasureType MeasureType { get; set; }
    public decimal UnitPrice { get; set; }
    public string? NameUz { get; set; }
    public string? NameRu { get; set; }
    public string? NameEn { get; set; }
    public ulong Tm { get; set; }  // To store the creation time of the Material object in seconds, going back to 1970.
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }

   // public virtual Docs? Image { get; set; }
    public virtual MaterialCategory? MaterialCategory { get; set; }
}