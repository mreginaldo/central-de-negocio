using CentralDeNegocio.Data.Context;
using CentralDeNegocio.Domain.Entities;
using CentralDeNegocio.Domain.Interfaces;
using System.Collections.Generic;

namespace CentralDeNegocio.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(CentralDeNegocioContext context) : base(context)
        {
        }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
    }
}
