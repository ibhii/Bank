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
    public virtual int? CoferID { get; set; }
    public virtual int? UserID { get; set; }
    public virtual int? RoleID { get; set; }
    public virtual int? Status { get; set; }
    public virtual DateTimeOffset? Date { get; set; }
}
