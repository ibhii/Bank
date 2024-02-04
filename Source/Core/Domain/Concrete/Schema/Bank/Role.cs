using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت نقش های سیستم
/// </summary>
public class Role : BaseEntity
{
    public Role()
    {
        TItile = string.Empty;
    }

    public virtual int ID { get; set; }
    public virtual string TItile { get; set; }
}
