using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت یادداشت ها
/// </summary>
public class Not : BaseEntity

{
    public Not()
    {
        
    }

    public virtual int ID { get; set; }
    public virtual string Title { get; set; }
    public virtual string Description { get; set; }
    public virtual User User { get; set; }
}
