namespace ConsoleApp1.Products;

public class Recipe // : AuditableEntity, IHasDescription
{
    public Guid ProductId { get; set; }
    public ulong Tm { get; set; } // To store the creation time of the Recipe object in seconds, going back to 1970.
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }

    public virtual Product? Product { get; set; }
    public ICollection<RecipeDetail> RecipeDetails { get; set; }

    public Recipe()
    {
        RecipeDetails = new List<RecipeDetail>();
    }
}