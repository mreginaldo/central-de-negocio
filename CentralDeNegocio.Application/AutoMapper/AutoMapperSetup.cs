using AutoMapper;
using CentralDeNegocio.Application.ViewModels;
using CentralDeNegocio.Domain.Entities;

namespace CentralDeNegocio.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

            CreateMap<UserViewModel, User>();
            CreateMap<ClientViewModel, Client>();

            #endregion

            #region DomainToViewModel

            CreateMap<User, UserViewModel>();
            CreateMap<Client, ClientViewModel>();

            #endregion
        }
    }
}
