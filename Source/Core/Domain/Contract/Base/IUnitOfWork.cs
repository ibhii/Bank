using Domain.Contract.Schema.Bank;
using Domain.Contract.Schema.HR;
using IRoleRepository = Domain.Contract.Schema.HR.IRoleRepository;

namespace Domain.Contract.Base;

public interface IUnitOfWork : IDisposable
{
    void Commit();
    void RollBack();
    IRoleRepository RoleRepository { get; }
    IUserRepository UserRepository { get; }
    IUserRepository BankUserRepository { get; }
    IAccessRepository AccessRepository { get; }
    IInstallmentRepository InstallmentRepository { get; }
    ILateLoanRepository LateLoanRepository { get; }
    ILoanRepository LoanRepository{ get; }
    IMemberOfRepository MemberOfRepository { get; }
    IMessageRepository MessageRepository{ get; }
    INotsRepository NotsRepository { get; }
    IPaymentRepository PaymentRepository { get; }
    IPaymentTypeRepository PaymentTypeRepository { get; }
    IRoleRepository BankRoleRepository{ get; }
    IStatusRepository StatusRepository { get; }
    IStatusTypeRepository StatusTypeRepository { get; }
    IUserAccountRepository UserAccountRepository{ get; }
    IUserPasswordRepository UserPasswordRepository{ get; }
}
