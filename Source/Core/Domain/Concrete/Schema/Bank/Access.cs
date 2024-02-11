using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;

/// <summary>
/// موجودیت دسترسی 
/// </summary>
public class Access : BaseEntity
{
    public virtual int ID { get; set; }
    public virtual string Title { get; set; }
    public virtual ICollection<User> User { get; set; }
}
