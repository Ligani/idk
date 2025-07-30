using DataAcces.Entities;
using DomainClass.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics.Services
{
    public class HashPasswordService : IHashPasswordService
    {
        public User_ HashPassword(string password, User_ user)
        {
            var hasher = new PasswordHasher<User_>();
            user.HashPassword = hasher.HashPassword(user, password);
            return user;
        }
    }
}
