using CentralDeNegocio.Application.ViewModels;
using System.Collections.Generic;

namespace CentralDeNegocio.Application.Interfaces
{
    public interface IClientService
    {
        List<ClientViewModel> Get();

        bool Post(ClientViewModel clientViewModel);

        ClientViewModel GetById(string id);

        bool Put(ClientViewModel clientViewModel);

        bool Delete(string id);
    }
}
