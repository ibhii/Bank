using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;

/// <summary>
/// موجودیت دیرکرد وام
/// </summary>
public class LateLoan : BaseEntity
{
    public virtual int ID { get; set; }
    public virtual Installment? Installment { get; set; }
    public virtual string Price { get; set; }
    public virtual Status? Status { get; set; }
    public virtual string Description { get; set; }
}
