using DomainClass.Enums;

namespace WebAPI.Contracts
{
    public record UserResponse(Guid Id, string Name, Role role, string password);
}
