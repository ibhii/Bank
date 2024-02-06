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
       
    }

    public virtual int ID { get; set; }
    public virtual Cofer? CoferID { get; set; }
    public virtual User? User { get; set; }
    public virtual string NumberIns { get; set; }
    public virtual string Price { get; set; }
    public virtual DateTimeOffset? Date { get; set; }
    public virtual DateTimeOffset? ExpertDate { get; set; }
    public virtual Status? Status { get; set; }
    public virtual string Description { get; set; }
    public virtual ICollection<LateLoan> LateLoan { get; set; }
    public virtual ICollection<LoanInnig> LoanInnig { get; set; }


}
 
