using DomainClass.Enums;

namespace WebAPI.Contracts
{
    public record UserRequest(string Name, Role role, string password);

}
