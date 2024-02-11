using System.Reflection.Metadata;
using NH = NHibernate;
using Domain.Concrete.Base;
using Domain.Contract.Base;

namespace Application.Base;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly NH.ISession _session;
    private IBaseRepository<T> _baseRepositoryImplementation;

    public BaseRepository(NH.ISession session)
    {
        _session = session;
    }

    public void Delete(T entity)
    {
        _session.Delete(entity);
    }

    public T GetById(int id)
    {
        return _session.Get<T>(id);
    }


    public IQueryable<T> GetAll()
    {
        return _session.Query<T>();
    }

    public void Insert(T entity)
    {
        _session.Save(entity);
    }

    public void Update(T entity)
    {
        _session.Update(entity);
    }

    public T GetByCode(byte code)
    {
        return _session.Get<T>(code);
    }


    public async Task<int> GetNextValue(string entity)
    {
        var sql = $"SELECT MAX(ID) FROM [{entity}]";
        var lastId =  await _session.CreateSQLQuery(sql).UniqueResultAsync();
        return int.Parse(lastId.ToString()!) + 1;
    }
    
    public async Task<int> GetNextValueByCode(string entity)
    {
        var sql = $"SELECT MAX(Code) FROM [{entity}]";
        var lastId =  await _session.CreateSQLQuery(sql).UniqueResultAsync();
        return int.Parse(lastId.ToString()!) + 1;
    }
    

    public virtual async Task<bool> ValidationCheckById(int id)
    {
        return false;
    }

    public async Task<bool> ValidationCheckByCode(byte code)
    {
        return false;
    }
}
