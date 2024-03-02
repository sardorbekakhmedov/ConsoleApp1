namespace ConsoleApp1.Products;

public class ProductTransaction
{
    // public required EOperationType OperationType { get; set; } // Income, Outcome
    public required Guid WarehouseId { get; set; }
    public required Guid ProductId { get; set; }
    public decimal Amount { get; set; }
    public decimal Sum { get; set; }
    public decimal UnitPrice { get; set; } // 1000
    public decimal TotalPrice { get; set; } // 2000000
    public Guid CreatedById { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public ulong Tm { get; set; } // To store the creation time of the BalanceAccounting object in seconds, going back to 1970.
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }

    public virtual Product? Product { get; set; }
}