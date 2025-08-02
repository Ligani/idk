using DataAcces.Entities;
using DomainClass.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(User_.MAX_NAME_LENGTH);

            builder
                .Property(u => u.RoleOfuser)
                .IsRequired();

            builder
                .Property(u => u.HashPassword)
                .IsRequired()
                .HasMaxLength(User_.MAX_PASSWORD_LENGTH);
        }
    }
}
