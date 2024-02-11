using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;

/// <summary>
/// موجودیت نوع پرداخت
/// </summary>
public class PaymentType : BaseEntity
{
    public virtual int ID { get; set; }
    public virtual int? Type { get; set; }
    public virtual ICollection<Payment> Payment { get; set; }
}
