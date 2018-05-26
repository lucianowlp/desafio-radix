using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Radix.Gateway.Domain;

namespace Radix.Gateway.Infra.Data.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IConfiguration configuration)
            : base(configuration) { }

        public User FindByEmail(string email)
        {
            return mongoCollection.Find(Builders<User>.Filter.Eq("Email", email)).FirstOrDefault();
        }
    }
}
