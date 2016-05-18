using System.Collections.Generic;
using Adm.Subscribe.Domain.Entities;

namespace Adm.Subscribe.Domain.Interfaces
{
    public interface IUserRepository : IRepositoryDefault<User>
    {
        List<User> GetFirstOneHundredUsers();
    }
}
