using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Radix.Gateway.Resource;
using System;
using System.ComponentModel.DataAnnotations;

namespace Radix.Gateway.Client.ViewModel
{
    public class UserViewModel
    {
        [Key]
        [BsonId(IdGenerator = typeof(CombGuidGenerator))]
        public Guid Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(UserResource), ErrorMessageResourceName = "NameRequired")]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(UserResource), ErrorMessageResourceName = "LastNameRequired")]
        public string LastName { get; set; }

        [Required(ErrorMessageResourceType = typeof(UserResource), ErrorMessageResourceName = "PasswordRequired")]
        public string Password { get; set; }

        [Required(ErrorMessageResourceType = typeof(UserResource), ErrorMessageResourceName = "EmailRequired")]
        [EmailAddress]
        public string Email { get; set; }

        public string MerchantKey { get; set; }

        public AcquirerViewModel Acquirer { get; set; }
    }
}
