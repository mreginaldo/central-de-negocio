using CentralDeNegocio.Domain.Models;
using System;

namespace CentralDeNegocio.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
