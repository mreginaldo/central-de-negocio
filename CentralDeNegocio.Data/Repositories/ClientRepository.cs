using CentralDeNegocio.Data.Context;
using CentralDeNegocio.Domain.Entities;
using CentralDeNegocio.Domain.Interfaces;
using System.Collections.Generic;

namespace CentralDeNegocio.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(CentralDeNegocioContext context) : base(context)
        {
        }

        public IEnumerable<Client> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
    }
}
