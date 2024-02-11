using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت اعضا
/// </summary>
public class MemberOf : BaseEntity
{
    public virtual int ID { get; set; }
    public virtual Cofer? Cofer { get; set; }
    public virtual User? User { get; set; }
    public virtual Role? Role { get; set; }
    public virtual Status? Status { get; set; }
    public virtual DateTimeOffset? Date { get; set; }
}
