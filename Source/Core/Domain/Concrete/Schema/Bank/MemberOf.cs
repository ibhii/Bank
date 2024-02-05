using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت اعضا
/// </summary>
public class MemberOf : BaseEntity
{
    public MemberOf()
    {
        CoferID = null;
        UserID = null;
        RoleID = null;
        Status = null;
        Date = null;
    }
    
    public virtual int ID { get; set; }
    public virtual Cofer? CoferID { get; set; }
    public virtual User? UserID { get; set; }
    public virtual Role? RoleID { get; set; }
    public virtual Status? Status { get; set; }
    public virtual DateTimeOffset? Date { get; set; }
}
