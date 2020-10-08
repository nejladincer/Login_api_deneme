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
using System.Globalization;
using Microsoft.AspNetCore.Authorization;

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

        // GET: api/user
        //user collection'undaki bütün userları çekmeye yarayan fonksiyondur.
        [HttpGet]
      
        public async Task<string> GetUsers()
        {
            
            return await userRepository.GetAllUsers();
           
        }

        // GET api/user/1
        //user collection'undaki userları UserId'sine göre çekmeye yarayan fonksiyondur.
        [Authorize]
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {

            return await userRepository.GetUser(id);
        }

        [HttpPost]
        public async Task AddUser(User user)
        {
             await userRepository.AddUser(user);
        }
        
    }
}
