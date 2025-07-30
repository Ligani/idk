using DomainClasses.Enums;

namespace UserDomain.Models
{
    public class User
    {
        public Guid Id { get; }
        public string Username { get; } = string.Empty;
        public Role Role { get; }
    }
}
