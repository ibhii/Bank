using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
/// موجودیت حساب کابری کاربران سیستم
/// </summary>
public class UserAccountRepository: BaseRepository<UserAccount>, IUserAccountRepository
{
    public UserAccountRepository(ISession session) : base(session)
    {
    }
}
