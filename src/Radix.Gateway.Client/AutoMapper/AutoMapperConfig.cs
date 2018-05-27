using AutoMapper;

namespace Radix.Gateway.Client.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToModelMappingProfile());
                cfg.AddProfile(new ModelToDomainMappingProfile());
            });
        }
    }
}
