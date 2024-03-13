using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Repositories;
using Pri.Api.Pe.Infrastructure.Data;

namespace Pri.Api.Pe.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository<ApplicationUser>
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<UserRepository> _logger;
        protected readonly DbSet<ApplicationUser> _table;

        public UserRepository(ApplicationDbContext applicationDbContext, ILogger<UserRepository> logger)
        {
            _applicationDbContext = applicationDbContext;
            _table = _applicationDbContext.Set<ApplicationUser>();
            _logger = logger;
        }

        public virtual IQueryable<ApplicationUser> GetAll()
        {
            return _table.AsQueryable();
        }

        public virtual async Task<IEnumerable<ApplicationUser>> GetAllAsync()
        {
            return await _table
                .ToListAsync();
        }

        public virtual Task<ApplicationUser> GetByIdAsync(Guid id)
        {
            return _table
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public virtual Task<ApplicationUser> GetByUserNameAsync(string userName)
        {
            return _table
                .FirstOrDefaultAsync(t => t.UserName == userName);
        }

        public async Task<bool> UpdateAsync(ApplicationUser toUpdate)
        {
            _table.Update(toUpdate);
            return await SaveChangesAsync();
        }
        private async Task<bool> SaveChangesAsync()
        {
            try
            {
                await _applicationDbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException dbUpdateException)
            {
                _logger.LogError(dbUpdateException.Message);
                return false;
            }
        }

        public async Task<bool> CheckIfExistsAsync(Guid id)
        {
            return await _table.AnyAsync(t => t.Id == id);
        }
    }
}
