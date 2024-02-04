using Domain.Concrete.Schema.Bank;
using Domain.Contract.Base;

namespace Domain.Contract.Schema.Bank;
/// <summary>
/// موجودیت پرداخت 
/// </summary>
public interface IPaymentRepository : IBaseRepository<Payment>
{
    
}
