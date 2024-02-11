using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;

/// <summary>
/// موجودیت دیرکرد وام
/// </summary>
public class LateLoanRepository : BaseRepository<LateLoan>, ILateLoanRepository
{
    public LateLoanRepository(ISession session) : base(session)
    {
    }
    

}
