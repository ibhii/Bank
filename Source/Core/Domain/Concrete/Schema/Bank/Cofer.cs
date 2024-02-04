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
    public virtual int Admin { get; set; }
    public virtual string Description { get; set; }
    public virtual int? Status { get; set; }
}
