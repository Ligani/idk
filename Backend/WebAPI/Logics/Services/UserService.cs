using DataAcces.Repositories;
using DomainClass.Enums;
using DomainClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userrepository;
        private readonly IHashPasswordService _passwordservice;

        public UserService(IUserRepository userrepository, IHashPasswordService passwordservice)
        {
            _userrepository = userrepository;
            _passwordservice = passwordservice;
        }

        public async Task<List<User_>> GetUsers()
        {
            return await _userrepository.Get();
        }
        public async Task<Guid> CreateUser(User_ user)
        {
            _passwordservice.HashPassword(user.HashPassword, user);
            return await _userrepository.Create(user);
        }
        public async Task<Guid> UpdateUser(Guid id, string name, Role role, string password)
        {
            return await _userrepository.Update(id, name, role, password);
        }
        public async Task<Guid> DeleteUser(Guid id)
        {
            return await _userrepository.Delete(id);
        }

    }
}
