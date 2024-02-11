using Domain.Concrete.Base;

namespace Domain.Contract.Base;


/// <summary>
/// متد های جنرال
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IBaseRepository<T> where T : BaseEntity
{
    /// <summary>
    /// افزودن موجودیت
    /// </summary>
    void Insert(T entity);


    /// <summary>
    /// آپدیت موجودیت
    /// </summary>
    void Update(T entity);

    /// <summary>
    /// حذف موجودیت
    /// </summary>
    void Delete(T entity);

    /// <summary>
    ///   واکشی همه اطلاعات
    /// </summary>
    /// <returns></returns>
    IQueryable<T> GetAll();
    

    /// <summary>
    /// واکشی رکورد مورد نظر دارای ID
    /// </summary>
    /// <param name="id">شناسه جدول</param>
    /// <returns></returns>
    T GetById(int id);

    /// <summary>
    /// واکشی داده هایی که دارای Code
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    T GetByCode(byte code);
    
    
    /// <summary>
    /// چک کردن صحت داده ها با استفاده از آِی دی 
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task <bool> ValidationCheckById(int id);

    /// <summary>
    /// چک کردن صحت داده ها با استفاده از کد 
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task <bool> ValidationCheckByCode(byte code);
    

    /// <summary>
    /// چک میکند بزرگترین آی دی چند هست و یکی بیشترش رو بر می گردوند به منظور ساخت PK 
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<int> GetNextValue(string entity);
    
    /// <summary>
    /// چک میکند بزرگترین کد چند هست و یکی بیشترش رو بر می گردوند به منظور ساخت PK
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<int> GetNextValueByCode(string entity);

    
}
