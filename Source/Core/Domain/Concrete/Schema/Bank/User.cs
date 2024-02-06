using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت کاربران 
/// </summary>
public class User : BaseEntity
{
    public User()
    {
       
    }

    public virtual int ID { get; set; }
    public virtual User Presenter { get; set; }
    public virtual string Name { get; set; }
    public virtual string LastName { get; set; }
    public virtual string FatherName { get; set; }
    public virtual int? NationalID { get; set; }
    public virtual DateTimeOffset? BirthDate { get; set; }
    public virtual Access Access { get; set; }
    public virtual string PhoneNumber{ get; set; }
    public virtual string Address { get; set; }
    public virtual string Job { get; set; }
    public virtual Payment Payment { get; set; }
    public virtual DateTimeOffset? CreateDate{ get; set; }
    public virtual ICollection<Installment> Installment { get; set; }
    public virtual ICollection<Loan> Loan { get; set; }
    public virtual ICollection<Cofer> Cofer { get; set; }
    public virtual ICollection<MemberOf> MemberOf{ get; set; }
    public virtual ICollection<Message> Message_UserReq { get; set; }
    public virtual ICollection<Message> Message_UserRes { get; set; }
    public virtual ICollection<Not> Not { get; set; }
    public virtual ICollection<UserAccount> UserAccount { get; set; }
    public virtual ICollection<User> User_Presenter { get; set; }
    public virtual ICollection<UserPassword> UserPassword { get; set; }

}
