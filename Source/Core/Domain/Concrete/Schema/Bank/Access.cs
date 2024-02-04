using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;

/// <summary>
/// موجودیت دسترسی 
/// </summary>
public class Access : BaseEntity
{
    public Access()
    {
        Title = string.Empty;
    }

    public virtual int ID { get; set; }
    public virtual string Title { get; set; }

}
