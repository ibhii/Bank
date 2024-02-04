using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using Domain.Contract.Schema.HR;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
/// موجودیت اعضا
/// </summary>
public class MemberOfRepository: BaseRepository<MemberOf>, IMemberOfRepository
{
    public MemberOfRepository(ISession session) : base(session)
    {
    }
}
