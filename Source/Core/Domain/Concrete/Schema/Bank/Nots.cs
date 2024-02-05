using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت یادداشت ها
/// </summary>
public class Nots : BaseEntity

{
    public Nots()
    {
        UserID = null;
        Title = string.Empty;
        Description = string.Empty;
    }

    public virtual int ID { get; set; }
    public virtual string Title { get; set; }
    public virtual string Description { get; set; }
    public virtual User UserID { get; set; }
}
