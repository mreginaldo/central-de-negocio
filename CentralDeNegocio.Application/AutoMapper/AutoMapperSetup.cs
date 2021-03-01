using AutoMapper;
using CentralDeNegocio.Application.ViewModels;
using CentralDeNegocio.Domain.Entities;

namespace CentralDeNegocio.Application.AutoMapper
{
    class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

            CreateMap<UserViewModel, User>();

            #endregion

            #region DomainToViewModel

            CreateMap<User, UserViewModel>();

            #endregion
        }
    }
}
