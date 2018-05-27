using AutoMapper;
using Radix.Gateway.Client.ViewModel;
using Radix.Gateway.Domain;

namespace Radix.Gateway.Client.AutoMapper
{
    public class DomainToModelMappingProfile : Profile
    {
        public DomainToModelMappingProfile()
        {
            CreateMap<UserViewModel, User>();
        }
    }
}