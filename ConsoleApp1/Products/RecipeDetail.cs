using ConsoleApp1.WareHouses;

namespace ConsoleApp1.Products;

public class RecipeDetail // : AuditableEntity, IHasDescription
{
    public Guid RecipeId { get; set; }
    public Guid MaterialId { get; set; }
    public decimal Amount { get; set; }
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }

    public virtual Recipe? Recipe { get; set; }
    public virtual Material? Material { get; set; }
}