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
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Review>> logger)
            : base(applicationDbContext, logger)
        {
        }
    }
}
