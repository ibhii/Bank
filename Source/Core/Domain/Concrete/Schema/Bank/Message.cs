using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت پیام
/// </summary>
public class Message : BaseEntity
{
    public Message()
    {
        CoferID = null;
        UserReq = null;
        UserRes = null;
        Title = string.Empty;
        Descript = string.Empty;
    }

    public virtual int ID { get; set; }
    public virtual Cofer? CoferID { get; set; }
    public virtual User? UserReq { get; set; }
    public virtual User? UserRes { get; set; }
    public virtual string Title { get; set; }
    public virtual string Descript { get; set; }
}
