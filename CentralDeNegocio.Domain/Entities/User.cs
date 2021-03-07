using Microsoft.AspNetCore.Identity;

namespace CentralDeNegocio.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
    }
}
