using CentralDeNegocio.Domain.Interfaces;
using System;

namespace CentralDeNegocio.Application.ViewModels
{
    public class ClientViewModel
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }
    }
}
