namespace ConsoleApp1.WareHouses;

public class Supplier // : AuditableEntity, IHasDescription
{
    public Guid AddressId { get; set; }
    public required string CompanyName { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Email { get; set; }
    public ulong Tm { get; set; }  // To store the creation time of the Supplier object in seconds, going back to 1970.
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }
}