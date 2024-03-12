using Microsoft.Extensions.Logging;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces;
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
    }
}
