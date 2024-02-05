using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت وضعیت
/// </summary>
public class Status : BaseEntity
{
    public Status()
    {
        StatusType = null;
        Title = string.Empty;
    }

    public virtual int ID { get; set; }
    public virtual StatusType? StatusType { get; set; }
    public virtual string Title { get; set; }
    public virtual List<Installment> Installment{ get; set; }
    public virtual List<LateLoan> LateLoan{ get; set; }
    public virtual List<LoanInngs> LoanInng{ get; set; }
    public virtual List<Loan> Loan{ get; set; }
    public virtual List<MemberOf> MemberOf{ get; set; }
    public virtual List<Cofer> Cofer { get; set; }
    public virtual List<UserAccount> UserAccount { get; set; }
    public virtual List<UserPassword> UserPassword { get; set; }
}
