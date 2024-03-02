namespace ConsoleApp1.WareHouses;

public class MaterialCategory // : AuditableEntity, IHasDescription
{
    public Guid ImageId { get; set; }
    public string? NameUz { get; set; }
    public string? NameRu { get; set; }
    public string? NameEn { get; set; }
    public ulong Tm { get; set; } // To store the creation time of the MaterialCategory object in seconds, going back to 1970.
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }

   // public virtual Docs? Docs { get; set; }
    public virtual ICollection<Material>? Materials { get; set; }
}