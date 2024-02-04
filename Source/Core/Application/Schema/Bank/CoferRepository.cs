using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;

/// <summary>
/// موجودیت صندوقدار
/// </summary>
public class CoferRepository: BaseRepository<Cofer>, ICoferRepository
{
    public CoferRepository(ISession session) : base(session)
    {
    }
}
