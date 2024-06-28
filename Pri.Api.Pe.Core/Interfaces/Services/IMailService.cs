using Microsoft.AspNetCore.Identity;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Interfaces.Services
{
    public interface IMailService
    {
        Task<ResultModel<bool>> SendValidationEmail(UserManager<ApplicationUser> userManager, ApplicationUser user, string sender, string apikey);
    }
}
