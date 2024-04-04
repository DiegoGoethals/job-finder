using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Repositories;
using Pri.Api.Pe.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Infrastructure.Repositories
{
    public class MessageRepository : BaseRepository<Message>, IMessageRepository
    {
        public MessageRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Message>> logger)
            : base(applicationDbContext, logger)
        {
        }

        public async Task<IEnumerable<Message>> GetConversationAsync(Guid id1, Guid id2)
        {
            return await _table.Where(x => (x.SenderId == id1 && x.ReceiverId == id2) ||
            (x.SenderId == id2 && x.ReceiverId == id1)).OrderBy(x => x.Created).ToListAsync();
        }
    }
}
