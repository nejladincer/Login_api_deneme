using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using Rekabet_login.Domain.Entities;
using Rekabet_login.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rekabet_login.Domain.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MongoDbContext context = null;
        public UserRepository(IOptions<SettingsForConnection> settings)
        {
            context = new MongoDbContext(settings);
        }

        public async Task <string>GetAllUsers()
        {
            try
            {
                var client = new MongoClient(
        "mongodb+srv://admin:cIXFELqrHE5ZRLJa@cluster0.9yyph.mongodb.net/<Cluster0>?retryWrites=true&w=majority"
        );
                IMongoDatabase database = client.GetDatabase("competition");

                var users = await context.Users.Find(new BsonDocument()).ToListAsync();
                var doc = users.Find(new BsonDocument()).ToList();


                //var users = Console.WriteLine("aaa");
                return doc.ToJson();

                var usersList= await context.Users.Find(new BsonDocument()).ToListAsync();
               // var usersDoc= usersList.ToBsonDocument();
                List<String> json = new List<string>();
               


                return json;
                
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<User> GetUser(int id)
        {
            var filter = Builders<User>.Filter.Eq("Id", id);

            try
            {
                return await context.Users.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task AddUser(User user)
        {
            try
            {
                await context.Users.InsertOneAsync(user);
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<bool> RemoveUser(int id)
        {
            try
            {
                DeleteResult actionResult = await context.Users.DeleteOneAsync(Builders<User>.Filter.Eq("Id", id));

                return actionResult.IsAcknowledged
                    && actionResult.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        //public async Task<bool> UpdateUserName(int id, string name)
        //{
        //    //Kisi_adi update

        //    var filter = Builders<User>.Filter.Eq(s => s.Id, id);
        //    var update = Builders<User>.Update.Set(s => s.Kisi_adi, name);
            
        //    try
        //    {
        //        UpdateResult actionResult
        //             = await context.Users.UpdateOneAsync(filter, update);

        //        return actionResult.IsAcknowledged
        //            && actionResult.ModifiedCount > 0;
        //    }
        //    catch (Exception ex)
        //    {
                
        //        throw ex;
        //    }
        //}

        public async Task<bool> UpdateUser(int id, User user)
        {
            try
            {
                ReplaceOneResult actionResult = await context.Users.ReplaceOneAsync(n => n.Id.Equals(id), user, new UpdateOptions { IsUpsert = true });
                return actionResult.IsAcknowledged
                    && actionResult.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<bool> RemoveAllUsers()
        {
            try
            {
                DeleteResult actionResult
                    = await context.Users.DeleteManyAsync(new BsonDocument());

                return actionResult.IsAcknowledged
                    && actionResult.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        
    }
}
