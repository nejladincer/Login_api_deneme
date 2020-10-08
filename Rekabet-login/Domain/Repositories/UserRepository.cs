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
                var users = await context.Users.Find(new BsonDocument()).ToListAsync();
            
                return users.ToJson();

            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<string> GetUser(int id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Id", id);

            try
            {
                var user= await context.Users.Find(filter).FirstOrDefaultAsync();
                return user.ToJson();
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
                BsonDocument userDoc = user.ToBsonDocument();
                 await context.Users.InsertOneAsync(userDoc);
                
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        //public async Task<bool> RemoveUser(int id)
        //{
        //    try
        //    {
        //        DeleteResult actionResult = await context.Users.DeleteOneAsync(Builders<User>.Filter.Eq("Id", id));

        //        return actionResult.IsAcknowledged
        //            && actionResult.DeletedCount > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        // log or manage the exception
        //        throw ex;
        //    }
        //}

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

        //public async Task<bool> UpdateUser(int id, User user)
        //{
        //    try
        //    {
        //        ReplaceOneResult actionResult = await context.Users.ReplaceOneAsync(n => n.Id.Equals(id), user, new UpdateOptions { IsUpsert = true });
        //        return actionResult.IsAcknowledged
        //            && actionResult.ModifiedCount > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        // log or manage the exception
        //        throw ex;
        //    }
        //}

        //public async Task<bool> RemoveAllUsers()
        //{
        //    try
        //    {
        //        DeleteResult actionResult
        //            = await context.Users.DeleteManyAsync(new BsonDocument());

        //        return actionResult.IsAcknowledged
        //            && actionResult.DeletedCount > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        // log or manage the exception
        //        throw ex;
        //    }
        //}


    }
}
