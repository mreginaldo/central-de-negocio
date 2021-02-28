using CentralDeNegocio.Application.ViewModels;
using System.Collections.Generic;

namespace CentralDeNegocio.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();

        bool Post(UserViewModel userViewModel);
    }
}
