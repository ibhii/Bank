﻿using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;

/// <summary>
/// موجودیت پرداخت 
/// </summary>
public class Payment : BaseEntity
{
    public virtual int ID { get; set; }
    public virtual User UserID { get; set; }
    public virtual Cofer Cofer { get; set; }
    public virtual PaymentType? PaymentType { get; set; }
    public virtual User AccountNum { get; set; }
    public virtual DateTimeOffset Date { get; set; }
    public virtual string Description { get; set; }
    public virtual string Picture { get; set; }
    public virtual User User { get; set; }
}
