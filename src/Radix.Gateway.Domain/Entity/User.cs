using System;

namespace Radix.Gateway.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool AntiFraudSystem { get; set; } = false;
        public string MerchantKey { get; set; }
        public Acquirer Acquirer { get; set; }
    }
}