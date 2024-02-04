using System.Reflection.PortableExecutable;
using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;

/// <summary>
/// موجودیت قسط
/// </summary>
public class Installment : BaseEntity
{
    public Installment()
    {
        CoferID = null;
        UerId = null;
        NumberIns = string.Empty;
        Price = string.Empty;
        Date = null;
        ExpertDate = null;
        Status = null;
        Description = string.Empty;
    }

    public virtual int Id { get; set; }
    public virtual int? CoferID { get; set; }
    public virtual int? UerId { get; set; }
    public virtual string NumberIns { get; set; }
    public virtual string Price { get; set; }
    public virtual DateTimeOffset? Date { get; set; }
    public virtual DateTimeOffset? ExpertDate { get; set; }
    public virtual int? Status { get; set; }
    public virtual string Description { get; set; }
}
 
