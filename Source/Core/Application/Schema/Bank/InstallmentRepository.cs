using System.Xml;
using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;

/// <summary>
/// موجودیت قسط
/// </summary>
public class InstallmentRepository : BaseRepository<Installment>, IInstallmentRepository
{
    public InstallmentRepository(ISession session) : base(session)
    {
    }
    

}
