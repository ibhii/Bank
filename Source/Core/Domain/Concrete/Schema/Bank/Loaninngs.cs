using System.Security.AccessControl;
using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت وام ها 
/// </summary>

public class Loaninngs : BaseEntity
{
    public Loaninngs()
    {
        InstallmentID = null;
        Price = string.Empty;
        Description = string.Empty;
        Status = null;
    }

    public virtual int? ID { get; set; }
    public virtual int? InstallmentID { get; set; }
    public virtual string Price { get; set; }
    public virtual string Description { get; set; }
    public virtual int? Status { get; set; }
        
}
