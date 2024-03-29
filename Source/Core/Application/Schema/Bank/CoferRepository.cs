﻿using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;
using NHibernate.Linq;

namespace Application.Schema.Bank;

/// <summary>
/// موجودیت صندوقدار
/// </summary>
public class CoferRepository : BaseRepository<Cofer>, ICoferRepository
{
    private readonly ISession _session;

    public CoferRepository(ISession session) : base(session)
    {
        _session = session;
    }

    public override async Task<bool> ValidationCheckById(int id)
    {
        return await _session.Query<Cofer>().Where(c => c.ID == id)
            .AnyAsync(c => c.CoferName != null && c.Status != null);
    }
    
}
