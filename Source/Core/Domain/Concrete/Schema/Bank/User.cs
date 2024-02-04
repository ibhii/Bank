using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت کاربران 
/// </summary>
public class User : BaseEntity
{
    public User()
    {
        Presenter = null;
        Name = string.Empty;
        LastName = string.Empty;
        FatherName = string.Empty;
        NationalID = null;
        BirthDate = null;
        PhoneNumber = string.Empty;
        Address = string.Empty;
        Job = string.Empty;
        CreateDate = null;
        Accessibility = null;
    }

    public virtual int ID { get; set; }
    public virtual int? Presenter { get; set; }
    public virtual string Name { get; set; }
    public virtual string LastName { get; set; }
    public virtual string FatherName { get; set; }
    public virtual int? NationalID { get; set; }
    public virtual DateTimeOffset? BirthDate { get; set; }
    public virtual string PhoneNumber{ get; set; }
    public virtual string Address { get; set; }
    public virtual string Job { get; set; }
    public virtual DateTimeOffset? CreateDate{ get; set; }
    public virtual int? Accessibility { get; set; }
}
