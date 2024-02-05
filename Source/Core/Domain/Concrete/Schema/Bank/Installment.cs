using System.Reflection.PortableExecutable;
using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;

/// <summary>
/// موجودیت قسط
/// </summary>
public class Installment : BaseEntity
{
    public Installment()
    {
        CoferID = null;
        UerId = null;
        NumberIns = string.Empty;
        Price = string.Empty;
        Date = null;
        ExpertDate = null;
        Status = null;
        Description = string.Empty;
    }

    public virtual int Id { get; set; }
    public virtual Cofer? CoferID { get; set; }
    public virtual User? UerId { get; set; }
    public virtual string NumberIns { get; set; }
    public virtual string Price { get; set; }
    public virtual DateTimeOffset? Date { get; set; }
    public virtual DateTimeOffset? ExpertDate { get; set; }
    public virtual Status? Status { get; set; }
    public virtual string Description { get; set; }
    public virtual List<LateLoan> LateLoans { get; set; }
    public virtual List<LoanInngs> Loaninngs { get; set; }


}
 
