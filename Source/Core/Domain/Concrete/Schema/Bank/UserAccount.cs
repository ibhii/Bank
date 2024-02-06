using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت حساب کابری کاربران سیستم
/// </summary>
public class UserAccount : BaseEntity
{
    public UserAccount()
    {
      
    }

    public virtual int ID { get; set; }
    public virtual User? User { get; set; }
    public virtual int? AccountNum { get; set; }
    public virtual Status? Status { get; set; }
    public virtual string Description { get; set; }
}
