using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
/// موجودیت نقش های سیستم
/// </summary>
public class RoleRepository: BaseRepository<Role>, IRoleRepository
{
    public RoleRepository(ISession session) : base(session)
    {
    }
}
