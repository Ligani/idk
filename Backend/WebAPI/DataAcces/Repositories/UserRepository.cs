using DataAcces.Contexts;
using DataAcces.Entities;
using DomainClass.Enums;
using DomainClass.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAcces.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserStroreDbContext _context;

        public UserRepository(UserStroreDbContext context)
        {
            _context = context;
        }

        public async Task<List<User_>> Get()
        {
            var usersentity = await _context.Users.AsNoTracking()
                .ToListAsync();

            var users = usersentity.Select(u => User_.CreateUser(u.Id, u.Name, u.RoleOfuser, u.HashPassword).user)
                .ToList();

            return users;
        }

        public async Task<Guid> Create(User_ user)
        {
            var userEntity = new UserEntity()
            {
                Id = user.Id,
                Name = user.Name,
                RoleOfuser = user.RoleOfUser,
                HashPassword = user.HashPassword
            };

            await _context.Users.AddAsync(userEntity);
            await _context.SaveChangesAsync();

            return userEntity.Id;
        }

        public async Task<Guid> Update(Guid id, string name, Role role, string password)
        {
            await _context.Users.Where(u => u.Id == id)
                .ExecuteUpdateAsync(x => x.SetProperty(u => u.Name, u => name)
                .SetProperty(u => u.RoleOfuser, u => role)
                .SetProperty(u => u.HashPassword, u => password));

            return id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await _context.Users.Where(u => u.Id == id).ExecuteDeleteAsync();
            return id;
        }
    }
}
