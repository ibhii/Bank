using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;
using NHibernate.Linq;

namespace Application.Schema.Bank;

/// <summary>
/// موجودیت نقش های سیستم
/// </summary>
public class RoleRepository : BaseRepository<Role>, IRoleRepository
{
    private readonly ISession _session;

    public RoleRepository(ISession session) : base(session)
    {
        _session = session;
    }

    public override async Task<bool> ValidationCheckById(int id)
    {
        return await _session.Query<Role>().Where(r => r.ID == id)
            .AnyAsync(r => r.TItile != null);
    }
}
