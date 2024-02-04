﻿using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
 /// موجودیت وام
/// </summary>
public class Loan : BaseEntity
{
    public Loan()
    {
        CoferID = null;
        Name = string.Empty;
        Admin = null;
        TotalPrice = string.Empty;
        PricePerIns = string.Empty;
        InstallmentNum = null;
        MemberNum = null;
        StartDate = null;
        EndDate = null;
        Status = null;
        Description = string.Empty;
    }

    public virtual int ID { get; set; }
    public virtual int? CoferID  { get; set; }
    public virtual string Name { get; set; }
    public virtual int? Admin { get; set; }
    public virtual string TotalPrice { get; set; }
    public virtual string PricePerIns { get; set; }
    public virtual int? InstallmentNum { get; set; }
    public virtual int? MemberNum { get; set; }
    public virtual DateTimeOffset? StartDate { get; set; }
    public virtual DateTimeOffset? EndDate { get; set; }
    public virtual int? Status { get; set; }
    public virtual string Description { get; set; }
}