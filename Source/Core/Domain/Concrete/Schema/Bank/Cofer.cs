using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;

/// <summary>
/// موجودیت صندوقدار
/// </summary>
public class Cofer : BaseEntity
{
    public Cofer()
    {
        CoferName = string.Empty;
        Description = string.Empty;
        Status = null;
    }

    public virtual int ID { get; set; }
    public virtual string CoferName { get; set; }
    public virtual User Admin { get; set; }
    public virtual string Description { get; set; }
    public virtual Status? Status { get; set; }
    public virtual List<MemberOf> MemberOf { get; set; }
    public virtual List<Message> Message { get; set; }
    public virtual List<Installment> Installments { get; set; }
    public virtual List<Loan> Loans { get; set; }
    public virtual List<Payment> Payment { get; set; }



}
