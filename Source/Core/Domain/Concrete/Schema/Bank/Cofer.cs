using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;

/// <summary>
/// موجودیت صندوقدار
/// </summary>
public class Cofer : BaseEntity
{
    public virtual int ID { get; set; }
    public virtual string CoferName { get; set; }
    public virtual User User { get; set; }
    public virtual string Description { get; set; }
    public virtual Status? Status { get; set; }
    public virtual ICollection<MemberOf> MemberOf { get; set; }
    public virtual ICollection<Message> Message { get; set; }
    public virtual ICollection<Installment> Installments { get; set; }
    public virtual ICollection<Loan> Loan { get; set; }
    public virtual ICollection<Payment> Payment { get; set; }
}
