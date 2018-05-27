namespace Radix.Gateway.Domain
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User FindByEmail(string email);
        User FindByMerchantKey(string merchantKey);
    }
}