﻿using Microsoft.AspNetCore.Identity;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Interfaces.Services
{
    public interface IAccountService
    {
        Task<ResultModel<IEnumerable<ApplicationUser>>> GetAllAsync();
        Task<ResultModel<ApplicationUser>> GetByUserNameAsync(string userName);
        Task<ResultModel<ApplicationUser>> Register(ApplicationUser user, IEnumerable<string> skills);
        Task<ResultModel<ApplicationUser>> GetByIdAsync(Guid userId);
    }
}
