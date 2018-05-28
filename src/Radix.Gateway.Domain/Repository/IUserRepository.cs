namespace Radix.Gateway.Domain.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User FindByEmail(string email);
        User FindByMerchantKey(string merchantKey);
    }
}