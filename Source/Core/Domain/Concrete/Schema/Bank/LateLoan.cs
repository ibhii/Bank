using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت دیرکرد وام
/// </summary>
public class LateLoan : BaseEntity
{
    public LateLoan()
    {
        InstalmentID = null;
        Price = string.Empty;
        Status = null;
        Description = string.Empty;
    }

    public virtual int ID { get; set; }
    public virtual int? InstalmentID { get; set; }
    public virtual string Price { get; set; }
    public virtual int?  Status { get; set; }
    public virtual string Description { get; set; }
}
