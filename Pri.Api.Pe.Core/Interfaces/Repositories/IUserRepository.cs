using Microsoft.AspNetCore.Identity;

namespace Pri.Api.Pe.Core.Interfaces.Repositories
{
    public interface IUserRepository<ApplicationUser>
    {
        Task<IEnumerable<ApplicationUser>> GetAllAsync();
        Task<ApplicationUser> GetByIdAsync(Guid id);
        Task<ApplicationUser> GetByUserNameAsync(string userName);
        IQueryable<ApplicationUser> GetAll();
        Task<bool> UpdateAsync(ApplicationUser toUpdate);
        Task<bool> CheckIfExistsAsync(Guid id);
    }
}
