using DomainClass.Enums;
using DomainClass.Models;

namespace Logics.Services
{
    public interface IUserService
    {
        Task<Guid> CreateUser(User_ user);
        Task<Guid> DeleteUser(Guid id);
        Task<List<User_>> GetUsers();
        Task<Guid> UpdateUser(Guid id, string name, Role role, string password);
    }
}