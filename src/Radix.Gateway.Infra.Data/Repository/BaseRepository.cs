using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Radix.Gateway.Domain;
using System.Collections.Generic;

namespace Radix.Gateway.Infra.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        protected readonly IMongoCollection<T> mongoCollection;

        public BaseRepository(IConfiguration configuration)
        {
            var client = new MongoClient(MongoUrl.Create(configuration.GetConnectionString("DefaultConnection")));
            mongoCollection = client.GetDatabase("gatewayRadix").GetCollection<T>(typeof(T).Name);
        }

        public long Delete(string id)
        {
            var deleteResult = mongoCollection.DeleteOne(Builders<T>.Filter.Eq("Id", id));
            return deleteResult.DeletedCount;
        }

        public IEnumerable<T> FindAll()
        {
            return mongoCollection.Find(_ => true).ToEnumerable<T>();
        }

        public T FindById(string id)
        {
            return mongoCollection.Find(Builders<T>.Filter.Eq("id", id)).FirstOrDefault();
        }

        public void Insert(T entity)
        {
            mongoCollection.InsertOne(entity);
        }

        public void Update(T entity, string id)
        {
            var filter = Builders<T>.Filter.Eq("id", id);
            mongoCollection.ReplaceOne(filter, entity, new UpdateOptions { IsUpsert = false });
        }
    }
}
