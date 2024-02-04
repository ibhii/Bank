﻿using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.Bank;
/// <summary>
/// موجودیت حساب کابری کاربران سیستم
/// </summary>
public class UserAccount : BaseEntity
{
    public UserAccount()
    {
        UserID = null;
        AccountNum = null;
        Status = null;
        Description = string.Empty;
    }

    public virtual int ID { get; set; }
    public virtual int? UserID { get; set; }
    public virtual int? AccountNum { get; set; }
    public virtual int? Status { get; set; }
    public virtual string Description { get; set; }
}