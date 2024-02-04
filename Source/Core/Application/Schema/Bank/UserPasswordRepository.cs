using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
/// موجودیت رمز کاربران سیستم
/// </summary>
public class UserPasswordRepository: BaseRepository<UserPassword>, IUserPasswordRepository
{
    public UserPasswordRepository(ISession session) : base(session)
    {
    }
}
