using DomainClass.Models;

namespace Logics.Services
{
    public interface IHashPasswordService
    {
        User_ HashPassword(string password, User_ user);
    }
}