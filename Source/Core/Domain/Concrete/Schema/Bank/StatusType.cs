using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
 /// موجودیت نوع وضعیت
/// </summary>
public class StatusType : BaseEntity
{
    StatusType()
    {
        Type = string.Empty;
    }

    public virtual int ID { get; set; }
    public virtual string Type { get; set; }
    public virtual List<Status> Status { get; set; }
}
