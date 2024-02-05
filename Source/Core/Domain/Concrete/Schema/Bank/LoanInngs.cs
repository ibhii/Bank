using System.Security.AccessControl;
using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت وام ها 
/// </summary>

public class LoanInngs : BaseEntity
{
    public LoanInngs()
    {
        InstallmentID = null;
        Price = string.Empty;
        Description = string.Empty;
        Status = null;
    }

    public virtual int? ID { get; set; }
    public virtual Installment? InstallmentID { get; set; }
    public virtual string Price { get; set; }
    public virtual string Description { get; set; }
    public virtual Status? Status { get; set; }
        
}
