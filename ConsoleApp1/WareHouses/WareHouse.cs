namespace ConsoleApp1.WareHouses;

public class WareHouse  // : AuditableEntity 
{
    public Guid BranchId { get; set; }
    public string? NameUz { get; set; }
    public string? NameRu { get; set; }
    public string? NameEn { get; set; }
    public ulong Tm { get; set; }  // To store the creation time of the Warehouse object in seconds, going back to 1970.
}