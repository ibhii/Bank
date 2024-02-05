using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت رمز کاربران سیستم
/// </summary>
public class UserPassword : BaseEntity
{
    public UserPassword()
    {
        UserID = null;
        AccountNum = null;
        Status = null;
        Description = string.Empty;
    }

    public virtual int ID { get; set; }
    public virtual User? UserID { get; set; }
    public virtual int? AccountNum { get; set; }
    public virtual Status? Status { get; set; }
    public virtual string Description { get; set; }
} 
