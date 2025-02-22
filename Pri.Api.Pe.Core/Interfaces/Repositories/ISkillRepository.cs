﻿using Pri.Api.Pe.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Interfaces.Repositories
{
    public interface ISkillRepository : IBaseRepository<Skill>
    {
        Task<Skill> GetByName(string name);
    }
}
