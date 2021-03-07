using CentralDeNegocio.Domain.Models;

namespace CentralDeNegocio.Domain.Entities
{
    public class Client : Entity
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string MobileNumber { get; set; }

        public string PhoneNumber { get; set; }
    }
}
