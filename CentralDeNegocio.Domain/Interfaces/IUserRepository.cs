using CentralDeNegocio.Domain.Entities;
using System.Collections.Generic;

namespace CentralDeNegocio.Domain.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
        IEnumerable<User> GetAll();
    }
}
