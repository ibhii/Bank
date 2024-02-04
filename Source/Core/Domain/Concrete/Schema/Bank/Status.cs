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
    public virtual int? StatusType { get; set; }
    public virtual string Title { get; set; }
}
