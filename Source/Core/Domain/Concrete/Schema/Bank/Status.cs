using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت وضعیت
/// </summary>
public class Status : BaseEntity
{
    public Status()
    {
        
    }

    public virtual int ID { get; set; }
    public virtual StatusType StatusType { get; set; }
    public virtual string Title { get; set; }
    public virtual ICollection<LoanInnig> LoanInnig { get; set; }
    public virtual ICollection<Installment> Installment{ get; set; }
    public virtual ICollection<LateLoan> LateLoan{ get; set; }
    public virtual ICollection<Loan> Loan{ get; set; }
    public virtual ICollection<MemberOf> MemberOf{ get; set; }
    public virtual ICollection<Cofer> Cofer { get; set; }
    public virtual ICollection<UserAccount> UserAccount { get; set; }
    public virtual ICollection<UserPassword> UserPassword { get; set; }
}
