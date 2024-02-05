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
    public virtual User? Presenter { get; set; }
    public virtual string Name { get; set; }
    public virtual string LastName { get; set; }
    public virtual string FatherName { get; set; }
    public virtual int? NationalID { get; set; }
    public virtual DateTimeOffset? BirthDate { get; set; }
    public virtual Access Accessibility { get; set; }
    public virtual string PhoneNumber{ get; set; }
    public virtual string Address { get; set; }
    public virtual string Job { get; set; }
    public virtual DateTimeOffset? CreateDate{ get; set; }
    public virtual List<Installment> Installment { get; set; }
    public virtual List<Loan> Loan { get; set; }
    public virtual List<Cofer> Cofer { get; set; }
    public virtual List<MemberOf> MemberOf{ get; set; }
    public virtual List<Message> Message { get; set; }
    public virtual List<Nots> Nots { get; set; }
    public virtual List<UserAccount> UserAccount { get; set; }
    public virtual List<UserPassword> UserPassword { get; set; }

}
