using Application.Schema.Bank;
using NHibernate;
using Domain.Contract.Base;
using Domain.Contract.Schema.Bank;

namespace Application.Base;

public class UnitOfWork : IUnitOfWork
{

    private readonly ISessionFactory _sessionFactory;

    private readonly ITransaction _transaction;

    private readonly ISession _session;

    public UnitOfWork(ISessionFactory sessionFactory)
    {
        _sessionFactory = sessionFactory;

        _session = _sessionFactory.OpenSession();

        _transaction = _session.BeginTransaction();
    }

    // private IRoleRepository _roleRepository = null!;
    // private IPersonRepository _personRepository = null!;
    
    private ICoferRepository _coferRepository = null!;
    private IUserRepository _userRepository = null!;
    private IAccessRepository _accessRepository = null!;
    private IInstallmentRepository _installmentRepository = null!;
    private ILateLoanRepository _lateLoanRepository = null!;
    private ILoanRepository _loanRepository = null!;
    private IMemberOfRepository _memberOfRepository = null!;
    private IMessageRepository _messageRepository = null!;
    private INotsRepository _notsRepository = null!;
    private IPaymentRepository _paymentRepository = null!;
    private IPaymentTypeRepository _paymentTypeRepository = null!;
    private IBankRoleRepository _bankRoleRepository = null!;
    private IStatusRepository _statusRepository = null!;
    private IStatusTypeRepository _statusTypeRepository = null!;
    private IUserAccountRepository _userAccountRepository = null!;
    private IUserPasswordRepository _userPasswordRepository = null!;

    // public IPersonRepository PersonRepository
    // {
    //     get
    //     {
    //         _personRepository ??= new PersonRepository(_session);
    //         return _personRepository;
    //     }
    // }
    //
    // public IRoleRepository RoleRepository
    // {
    //     get
    //     {
    //         _roleRepository ??= new RoleRepository(_session);
    //         return _roleRepository;
    //     }
    // }

    public IAccessRepository AccessRepository
    {
        get
        {
            _accessRepository ??= new AccessRepository(_session);
            return _accessRepository;
        }
    }
    
    public ICoferRepository CoferRepository 
    {
        get
        {
            _coferRepository ??= new CoferRepository(_session);
            return _coferRepository;
        }
    }
    
    public IInstallmentRepository InstallmentRepository
    {
        get
        {
            _installmentRepository ??= new InstallmentRepository(_session);
            return _installmentRepository;
        }
    }
    
    public ILateLoanRepository LateLoanRepository
    
    {
        get
        {
            _lateLoanRepository ??= new LateLoanRepository(_session);
            return _lateLoanRepository;
        }
    }
    
    public ILoanRepository LoanRepository
    {
        get
        {
            _loanRepository ??= new LoanRepository(_session);
            return _loanRepository;
        }
    }
    
    public IMemberOfRepository MemberOfRepository
    {
        get
        {
            _memberOfRepository ??= new MemberOfRepository(_session);
            return _memberOfRepository;
        }
    }
    
    public IMessageRepository MessageRepository
    {
        get
        {
            _messageRepository ??= new MessageRepository(_session);
            return _messageRepository;
        }
    }
    
    public INotsRepository NotsRepository
    {
        get
        {
            _notsRepository ??= new NotsRepository(_session);
            return _notsRepository;
        }
    }
    
    
    public IPaymentRepository PaymentRepository
    {
        get
        {
            _paymentRepository ??= new PaymentRepository(_session);
            return _paymentRepository;
        }
    }
    
    public IPaymentTypeRepository PaymentTypeRepository
    {
        get
        {
            _paymentTypeRepository ??= new PaymentTypeRepository(_session);
            return _paymentTypeRepository;
        }
    }
    
    public IBankRoleRepository BankRoleRepository
    {
        get
        {
        // _bankRoleRepository ?? = new BankRoleRepository(_session);
        return _bankRoleRepository;
        }
    }
    
    public IStatusRepository StatusRepository
    {
        get
        {
            _statusRepository ??= new StatusRepository(_session);
            return _statusRepository;
        }
    }
    
    public IStatusTypeRepository StatusTypeRepository
    {
        get
        {
            _statusTypeRepository ??= new StatusTypeRepository(_session);
            return _statusTypeRepository;
        }
    }
    
    public IUserAccountRepository UserAccountRepository
    {
        get
        {
            _userAccountRepository ??= new UserAccountRepository(_session);
            return _userAccountRepository;
        }
    }
    
    public IUserPasswordRepository UserPasswordRepository
    {
        get
        {
            _userPasswordRepository ??= new UserPasswordRepository(_session);
            return _userPasswordRepository;
        }
    }
    
    public IUserRepository UserRepository
    {
        get
        {
            _userRepository ??= new UserRepository(_session);
            return _userRepository;
        }
    }

    public void Commit()
    {
        if (!_transaction.IsActive)
        {
            throw new InvalidOperationException("No active transation");
        }

        _transaction.Commit();
    }

    public void Dispose()
    {
        if (_session.IsOpen)
        {
            _session.Close();
        }
    }

    public void RollBack()
    {
        if (_transaction.IsActive)
        {
            _transaction.Rollback();
        }
    }

    
}
