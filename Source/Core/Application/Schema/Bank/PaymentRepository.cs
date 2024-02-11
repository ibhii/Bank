using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
/// موجودیت پرداخت 
/// </summary>
public class PaymentRepository: BaseRepository<Payment>, IPaymentRepository
{
    public PaymentRepository(ISession session) : base(session)
    {
    }
    
   
}
