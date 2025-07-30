using DomainClass.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Models
{
    public class User_
    {
        public const int MAX_NAME_LENGTH = 12;
        private User_(Guid id, string name, Role roleOfUser, string hashPassword)
        {
            Id = id;
            Name = name;
            RoleOfUser = roleOfUser;
            HashPassword = hashPassword;
        }

        public Guid Id { get;}
        public string Name { get;}
        public Role RoleOfUser { get;}
        public string HashPassword { get; set; }

        public static (User_ user, string error) CreateUser(Guid id, string name, Role role, string passwordhash)
        {
            var error = string.Empty;

            if (name.Length>MAX_NAME_LENGTH || string.IsNullOrEmpty(name))
            {
                error = "Name can not be empty or longer than 12 symbols";
            }

            var user = new User_(id,name,role,passwordhash);

            return (user, error);
        }
    }
}
