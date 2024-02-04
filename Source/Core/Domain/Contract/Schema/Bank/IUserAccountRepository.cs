using Domain.Concrete.Schema.Bank;
using Domain.Contract.Base;

namespace Domain.Contract.Schema.Bank;
/// <summary>
/// موجودیت حساب کابری کاربران سیستم
/// </summary>
public interface IUserAccountRepository : IBaseRepository<UserAccount>
{
    
}
