using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Interfaces.Services
{
    public interface IMessageService
    {
        Task<ResultModel<Message>> CreateAsync(string content, Guid senderId, Guid receiverId);
        Task<ResultModel<Message>> UpdateAsync(Guid id, string content);
        Task<ResultModel<Message>> DeleteAsync(Guid id);
        Task<ResultModel<Message>> GetByIdAsync(Guid id);
        Task<ResultModel<IEnumerable<Message>>> GetConversationAsync(Guid id1, Guid id2);
        Task<ResultModel<IEnumerable<ApplicationUser>>> GetAllConversationPartnersAsync(Guid userId);
    }
}
