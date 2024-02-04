using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
/// موجودیت کاربران 
/// </summary>
public class UserRepository: BaseRepository<User>, IUserRepository
{
    public UserRepository(ISession session) : base(session)
    {
    }
}
