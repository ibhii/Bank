using Domain.Contract.Schema.Bank;

namespace Domain.Contract.Base;

public interface IUnitOfWork : IDisposable
{
    void Commit();
    void RollBack();
    // IRoleRepository RoleRepository { get; }
    IUserRepository UserRepository { get; }
    IAccessRepository AccessRepository { get; }
    IInstallmentRepository InstallmentRepository { get; }
    ILateLoanRepository LateLoanRepository { get; }
    ILoanRepository LoanRepository{ get; }
    IMemberOfRepository MemberOfRepository { get; }
    IMessageRepository MessageRepository{ get; }
    INotsRepository NotsRepository { get; }
    IPaymentRepository PaymentRepository { get; }
    IPaymentTypeRepository PaymentTypeRepository { get; }
    IBankRoleRepository BankRoleRepository{ get; }
    IStatusRepository StatusRepository { get; }
    IStatusTypeRepository StatusTypeRepository { get; }
    IUserAccountRepository UserAccountRepository{ get; }
    IUserPasswordRepository UserPasswordRepository{ get; }
}
