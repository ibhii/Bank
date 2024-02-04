using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;

/// <summary>
/// موجودیت دسترسی 
/// </summary>
public class AccessRepository: BaseRepository<Access>, IAccessRepository
{
    public AccessRepository(ISession session) : base(session)
    {
        
    }
}
