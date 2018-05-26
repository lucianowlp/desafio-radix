using Microsoft.Extensions.Configuration;
using Radix.Gateway.Domain;

namespace Radix.Gateway.Infra.Data.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IConfiguration configuration)
            : base(configuration) { }
    }
}
