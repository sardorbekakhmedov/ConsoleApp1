namespace ConsoleApp1.WareHouses;

public class Supply  // : AuditableEntity, IHasDescription
{
    public Guid BranchId { get; set; }
    public Guid WareHouseId { get; set; }
    public Guid SupplierId { get; set; }
    public decimal TotalPrice { get; set; }
    public uint TotalQuantity { get; set; }
    public ulong Tm { get; set; }  // To store the creation time of the Supply object in seconds, going back to 1970.
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }

    public ICollection<SupplyDetail> SupplyDetails { get; set; }

    public Supply()
    {
        SupplyDetails = new List<SupplyDetail>();
    }
}