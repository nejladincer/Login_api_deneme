using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;
using Rekabet_login.Domain.Repositories;
using Newtonsoft.Json;
using Rekabet_login.Domain.Models;
using MongoDB.Bson;
using System.Text.RegularExpressions;
using MongoDB.Driver;

namespace Rekabet_login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        // GET: user/users
        [HttpGet]
      
        public async Task<string> GetUsers()
        {
            var client = new MongoClient(
        "mongodb+srv://admin:cIXFELqrHE5ZRLJa@cluster0.9yyph.mongodb.net/<Cluster0>?retryWrites=true&w=majority"
        );
            IMongoDatabase database = client.GetDatabase("competition");
            
            var users = database.GetCollection<BsonDocument>("user");
            var doc = users.Find(new BsonDocument()).ToList();


            //var users = Console.WriteLine("aaa");
            return doc.ToJson();
           // var client = new MongoClient(
           //"mongodb+srv://admin:cIXFELqrHE5ZRLJa@cluster0.9yyph.mongodb.net/<Cluster0>?retryWrites=true&w=majority"
           //);
           // IMongoDatabase database = client.GetDatabase("competition");
           // var user = database.GetCollection<BsonDocument>("user");
           // var users = database.GetCollection<BsonDocument>("users");
            
           // // var usersDoc= usersList.ToBsonDocument();
           // List<String> json = new List<string>();
           // foreach (var a in users)
           // {
           //     var b = a.ToString();
           //     foreach (string x in a.Okuma_yetki)
           //     {
           //         b = x.ToString();
           //     }

           //     foreach (string x in a.Yazma_yetki)
           //     {
           //         b = x.ToString();
           //     }

           //     json.Add(b);

           // }


           // return json;
        }
        ////// GET api/user/1
        //[HttpGet("{id}")]
        //public Task<Object> Get(int id)
        //{
            
        //    return GetUserByIdInternal(id);
        //}

        //private async Task<Object> GetUserByIdInternal(int id)
        //{
        //    var user = await userRepository.GetUser(id) ?? new User();
        //    BsonDocument doc = user.ToBsonDocument();


        //    return Newtonsoft.Json.JsonConvert.DeserializeObject(doc.ToString());

        //}
    }
}
