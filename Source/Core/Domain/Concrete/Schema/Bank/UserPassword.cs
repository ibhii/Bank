using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت رمز کاربران سیستم
/// </summary>
public class UserPassword : BaseEntity
{
    public virtual int ID { get; set; }
    public virtual User User { get; set; }
    public virtual string PassWord { get; set; }
    public virtual DateTimeOffset Date { get; set; }
} 
