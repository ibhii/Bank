using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
 /// موجودیت نوع وضعیت
/// </summary>
public class StatusTypeRepository: BaseRepository<StatusType>, IStatusTypeRepository
{
 public StatusTypeRepository(ISession session) : base(session)
 {
 }
}
