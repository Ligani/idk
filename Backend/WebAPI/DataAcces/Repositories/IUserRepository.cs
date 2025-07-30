using DomainClass.Enums;
using DomainClass.Models;

namespace DataAcces.Repositories
{
    public interface IUserRepository
    {
        Task<Guid> Create(User_ user);
        Task<Guid> Delete(Guid id);
        Task<List<User_>> Get();
        Task<Guid> Update(Guid id, string name, Role role, string password);
    }
}