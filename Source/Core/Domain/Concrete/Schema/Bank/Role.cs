using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت نقش های سیستم
/// </summary>
public class Role : BaseEntity
{
    public virtual int ID { get; set; }
    public virtual string TItile { get; set; }
    public virtual ICollection<MemberOf> MemberOf{ get; set; }

}
