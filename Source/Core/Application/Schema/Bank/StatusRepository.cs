using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
/// موجودیت وضعیت
/// </summary>
public class StatusRepository: BaseRepository<Status>, IStatusRepository
{
    public StatusRepository(ISession session) : base(session)
    {
    }
}
