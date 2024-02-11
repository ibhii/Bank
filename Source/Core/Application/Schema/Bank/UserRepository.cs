using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;
using NHibernate.Linq;

namespace Application.Schema.Bank;

/// <summary>
/// موجودیت کاربران 
/// </summary>
public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly ISession _session;

    public UserRepository(ISession session) : base(session)
    {
        _session = session;
    }

    /// <summary>
    /// برای هر کاربر صحت اطلاعات وارد شده را چک میکند
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public override async Task<bool> ValidationCheckById(int id)
    {
        return await 
            _session.Query<User>().Where(u => u.ID == id)
            .AnyAsync(u => u.Name.Length <= 50 || u.LastName.Length <= 50 || u.PhoneNumber.Length <= 50 ||
                      u.Address.Length <= 50 ||
                      u.Job.Length <= 50
                      || u.NationalID!.Value.ToString().Length <= 10
                      || u.PhoneNumber.Length <= 10
                      || DateTimeOffset.Now.Year - u.BirthDate!.Value.Year <= 18);
    }
    

}
