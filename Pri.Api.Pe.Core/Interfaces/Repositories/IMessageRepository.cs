using Pri.Api.Pe.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Interfaces.Repositories
{
    public interface IMessageRepository : IBaseRepository<Message>
    {
        Task<IEnumerable<Message>> GetConversationAsync(Guid id1, Guid id2);
    }
}
