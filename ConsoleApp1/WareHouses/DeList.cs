namespace ConsoleApp1.WareHouses;

/// <summary>
/// This class works as a model for writing off products from a list of Restaurants
/// </summary>
public class DeList //: AuditableEntity, IHasDescription
{
    public Guid MaterialId { get; set; }
    public Guid ImageId { get; set; } // Photo of the decommissioned product
    public uint Amount { get; set; } 
    public ulong Tm { get; set; }  // To store the creation time of the Supply object in seconds, going back to 1970.
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }

   // public virtual Docs? Image { get; set; }
}