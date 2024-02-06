using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت پیام
/// </summary>
public class Message : BaseEntity
{
    public Message()
    {
       
    }

    public virtual int ID { get; set; }
    public virtual Cofer? Cofer { get; set; }
    public virtual User? User_UserReq { get; set; }
    public virtual User? User_UserRes { get; set; }
    public virtual string Title { get; set; }
    public virtual string Descript { get; set; }
}
