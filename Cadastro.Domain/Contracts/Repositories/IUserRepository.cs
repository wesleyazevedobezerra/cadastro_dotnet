using Cadastro.Domain.Contracts.Interfaces;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Contracts.Repositories
{
    public interface IUserRepository : IRepository<UserEntity>
    {
    }
}
