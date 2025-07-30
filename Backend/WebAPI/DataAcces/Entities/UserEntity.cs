using DomainClass.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string HashPassword { get; set; } = string.Empty;
        public Role RoleOfuser { get; set; }
    }
}
