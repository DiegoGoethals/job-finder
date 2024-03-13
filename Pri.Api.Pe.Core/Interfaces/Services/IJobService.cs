using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Interfaces.Services
{
    public interface IJobService
    {
        Task<ResultModel<Job>> CreateAsync(string name, string description, double salary, Guid employerId, IEnumerable<string> skills);
    }
}
