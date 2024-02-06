using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
 /// موجودیت وام
/// </summary>
public class Loan : BaseEntity
{
    public Loan()
    {
        
    }

    public virtual int ID { get; set; }
    public virtual Cofer? Cofer  { get; set; }
    public virtual string Name { get; set; }
    public virtual User? User { get; set; }
    public virtual string TotalPrice { get; set; }
    public virtual string PricePerIns { get; set; }
    public virtual int? InstallmentNum { get; set; }
    public virtual int? MemberNum { get; set; }
    public virtual DateTimeOffset? StartDate { get; set; }
    public virtual DateTimeOffset? EndDate { get; set; }
    public virtual Status? Status { get; set; }
    public virtual string Description { get; set; }
}
