using System.Security.AccessControl;
using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت وام ها 
/// </summary>

public class LoanInnig : BaseEntity
{
    public LoanInnig()
    {
        
    }

    public virtual int? ID { get; set; }
    public virtual Installment? Installment { get; set; }
    public virtual string Price { get; set; }
    public virtual string Description { get; set; }
    public virtual Status? Status { get; set; }
        
}
