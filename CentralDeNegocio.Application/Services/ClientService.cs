using AutoMapper;
using CentralDeNegocio.Application.Interfaces;
using CentralDeNegocio.Application.ViewModels;
using CentralDeNegocio.Domain.Entities;
using CentralDeNegocio.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace CentralDeNegocio.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository clientRepository;
        private readonly IMapper mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            this.clientRepository = clientRepository;
            this.mapper = mapper;
        }

        public List<ClientViewModel> Get()
        {
            List<ClientViewModel> _clientViewModel = new List<ClientViewModel>();

            IEnumerable<Client> _client = this.clientRepository.GetAll();

            _clientViewModel = mapper.Map<List<ClientViewModel>>(_client);

            return _clientViewModel;
        }

        public bool Post(ClientViewModel clientViewModel)
        {
            Client _client = mapper.Map<Client>(clientViewModel);

            this.clientRepository.Create(_client);

            return true;
        }

        public ClientViewModel GetById(string id)
        {
            if (!Guid.TryParse(id, out Guid clientId))
                throw new Exception("Cliente Id não é válido");

            Client _client = this.clientRepository.Find(x => x.Id == clientId && !x.IsDeleted);
            if (_client == null)
                throw new Exception("Cliente não encontrado");

            return mapper.Map<ClientViewModel>(_client);
        }

        public bool Put(ClientViewModel clientViewModel)
        {
            Client _client = this.clientRepository.Find(x => x.Id == clientViewModel.Id && !x.IsDeleted);
            if (_client == null)
                throw new Exception("Cliente não encontrado");

            _client = mapper.Map<Client>(clientViewModel);

            this.clientRepository.Update(_client);

            return true;
        }

        public bool Delete(string id)
        {
            if (!Guid.TryParse(id, out Guid clientId))
                throw new Exception("Cliente Id não é válido");

            Client _client = this.clientRepository.Find(x => x.Id == clientId && !x.IsDeleted);
            if (_client == null)
                throw new Exception("Cliente não encontrado");

            return this.clientRepository.Delete(_client);
        }
    }
}
