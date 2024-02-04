using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
/// موجودیت نوع پرداخت
/// </summary>
public class PaymentTypeRepository: BaseRepository<PaymentType>, IPaymentTypeRepository
{
    public PaymentTypeRepository(ISession session) : base(session)
    {
    }
}
