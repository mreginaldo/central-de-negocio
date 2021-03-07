using AutoMapper;
using CentralDeNegocio.Application.Interfaces;
using CentralDeNegocio.Application.ViewModels;
using CentralDeNegocio.Auth.Services;
using CentralDeNegocio.Domain.Entities;
using CentralDeNegocio.Domain.Interfaces;
using System;
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
            //List<UserViewModel> _userViewModel = new List<UserViewModel>();

            //IEnumerable<User> _users = this.userRepository.GetAll();

            //_userViewModel = mapper.Map<List<UserViewModel>>(_users);

            //return _userViewModel;

            User _users = new User();
            return mapper.Map<List<UserViewModel>>(_users);
        }

        public bool Post(UserViewModel userViewModel)
        {
            userViewModel.Id = Guid.NewGuid();

            User _user = mapper.Map<User>(userViewModel);

            this.userRepository.Create(_user);

            return true;
        }

        public UserViewModel GetById(string id) 
        {
            //if (!Guid.TryParse(id, out Guid userId))
            //    throw new Exception("User Id is not valid");

            //User _user = this.userRepository.Find(x => x.Id == userId && !x.IsDeleted);
            //if (_user == null)
            //    throw new Exception("User not found");

            //return mapper.Map<UserViewModel>(_user);

            User _user = new User();
            return mapper.Map<UserViewModel>(_user);
        }

        public bool Put(UserViewModel userViewModel) 
        {
            //User _user = this.userRepository.Find(x => x.Id == userViewModel.Id && !x.IsDeleted);
            //if (_user == null)
            //    throw new Exception("User not found");

            //_user = mapper.Map<User>(userViewModel);

            //_user.DateUpdated = DateTime.Now;

            //this.userRepository.Update(_user);

            return true;
        }

        public bool Delete(string id)
        {
            //if (!Guid.TryParse(id, out Guid userId))
            //    throw new Exception("User Id is not valid");

            //User _user = this.userRepository.Find(x => x.Id == userId && !x.IsDeleted);
            //if (_user == null)
            //    throw new Exception("User not found");

            //return this.userRepository.Delete(_user);

            return true;
        }

        public UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user)
        {
            User _user = this.userRepository.Find(x => x.Email.ToLower() == user.Email.ToLower());
            if (_user == null)
                throw new Exception("Usuário não encontrado");

            return new UserAuthenticateResponseViewModel(mapper.Map<UserViewModel>(_user), TokenService.GenerateToken(_user));
        }
    }
}
