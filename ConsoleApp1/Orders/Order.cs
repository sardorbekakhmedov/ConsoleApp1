using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Orders;

public class Order // : AuditableEntity, IHasDescription, IHasVisualIdField
{
    public Guid BranchId { get; set; }
    public Guid PaymentMethodId { get; set; }
    public ulong AppId { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint VisualId { get; set; }
    public decimal TotalPrice { get; set; }
   // public EOrderStatus Status { get; set; }
    public DateTime? ClosedAt { get; set; }
    public ulong Tm { get; set; } // To store the creation time of the Order object in seconds, going back to 1970.
    public string? DescriptionUz { get; set; }
    public string? DescriptionRu { get; set; }
    public string? DescriptionEn { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }

   // public virtual Branch? Branch { get; set; }
   // public virtual Discount? Discount { get; set; }
   // public virtual PaymentMethod? PaymentMethod { get; set; }
   // public ICollection<BalanceAccounting> BalanceAccounting { get; set; }

    public Order()
    {
     //   OrderDetails = new List<OrderDetail>();
     //   BalanceAccounting = new List<BalanceAccounting>();
    }
}