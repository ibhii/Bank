using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
/// موجودیت یادداشت ها
/// </summary>
public class NotsRepository: BaseRepository<Not>, INotsRepository
{
    public NotsRepository(ISession session) : base(session)
    {
    }
    
}
