using Rekabet_login.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rekabet_login.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<string>> GetAllUsers();
        Task<User> GetUser(int id);
        Task AddUser(User user);
        Task<bool> RemoveUser(int id);
        Task<bool> UpdateUser(int id, User user);
        //Task<bool> UpdateUserDocument(string id, string name);
        Task<bool> RemoveAllUsers();
    }
}
