using AutoMapper;
using Radix.Gateway.Client.ViewModel;
using Radix.Gateway.Domain;

namespace Radix.Gateway.Client.AutoMapper
{
    public class ModelToDomainMappingProfile : Profile
    {
        public ModelToDomainMappingProfile()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}