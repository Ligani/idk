using DataAcces.Entities;
using DomainClass.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Contexts
{
    public class UserStroreDbContext : DbContext
    {
        public UserStroreDbContext(DbContextOptions<UserStroreDbContext> options) : base(options)
        {}

        public DbSet<UserEntity> Users { get; set; }
    }
}
