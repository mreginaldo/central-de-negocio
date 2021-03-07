using CentralDeNegocio.Domain.Entities;
using System.Collections.Generic;

namespace CentralDeNegocio.Domain.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        IEnumerable<Client> GetAll();
    }
}
