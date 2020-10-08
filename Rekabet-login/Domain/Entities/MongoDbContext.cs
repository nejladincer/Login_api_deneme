using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using Rekabet_login.Domain.Models;

namespace Rekabet_login.Domain.Entities
{
    public class MongoDbContext
    {
        public MongoDbContext()
        {
                
        }
        private readonly IMongoDatabase _database = null;

        public MongoDbContext(IOptions<SettingsForConnection> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<BsonDocument> Users
        {
            get
            {
                return _database.GetCollection<BsonDocument>("user");
            }
        }
    }
}
