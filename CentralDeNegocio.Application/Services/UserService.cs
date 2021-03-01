using AutoMapper;
using CentralDeNegocio.Application.Interfaces;
using CentralDeNegocio.Application.ViewModels;
using CentralDeNegocio.Domain.Entities;
using CentralDeNegocio.Domain.Interfaces;
using System.Collections.Generic;

namespace CentralDeNegocio.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public List<UserViewModel> Get()
        {
            List<UserViewModel> _userViewModel = new List<UserViewModel>();

            IEnumerable<User> _users = this.userRepository.GetAll();

            _userViewModel = mapper.Map<List<UserViewModel>>(_users);

            return _userViewModel;
        }

        public bool Post(UserViewModel userViewModel)
        {
            User _user = mapper.Map<User>(userViewModel);

            this.userRepository.Create(_user);

            return true;
        }
    }
}
