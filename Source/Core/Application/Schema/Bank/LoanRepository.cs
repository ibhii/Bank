using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
 /// موجودیت وام
/// </summary>
public class LoanRepository: BaseRepository<Loan>, ILoanRepository
{
 public LoanRepository(ISession session) : base(session)
 {
 }
}
