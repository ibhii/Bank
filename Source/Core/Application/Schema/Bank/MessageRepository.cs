using Application.Base;
using Domain.Concrete.Schema.Bank;
using Domain.Contract.Schema.Bank;
using NHibernate;

namespace Application.Schema.Bank;
/// <summary>
/// موجودیت پیام
/// </summary>
public class MessageRepository: BaseRepository<Message>, IMessageRepository
{
    public MessageRepository(ISession session) : base(session)
    {
    }
    
}
