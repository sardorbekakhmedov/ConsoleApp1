namespace ConsoleApp1.WareHouses;

public class SupplyDetail // : AuditableEntity, IHasDescription
{
    public Guid SupplyId { get; set; }
    public Guid MaterialId { get; set; }
    public uint Amount { get; set; }
    public decimal UnitPrice { get; set; }
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }
}