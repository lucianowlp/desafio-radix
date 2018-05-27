using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Radix.Gateway.Client.ViewModel
{
    public class AcquirerViewModel
    {
        [Key]
        [BsonId]
        public string Id { get; set; }

        public string Name { get; set; }

        public string URLAPI { get; set; }
    }
}
