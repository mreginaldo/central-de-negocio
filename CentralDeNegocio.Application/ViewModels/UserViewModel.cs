﻿using System;

namespace CentralDeNegocio.Application.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
    }
}
