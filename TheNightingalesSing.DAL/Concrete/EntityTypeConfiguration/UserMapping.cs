using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.DAL.Helper;
using TheNightingalesSing.Model.Entities;
using TheNightingalesSing.Model.Enums;

namespace TheNightingalesSing.DAL.Concrete.EntityTypeConfiguration
{
    class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(u => u.ID);
            builder.Property(u => u.ID).UseIdentityAlwaysColumn();
            builder.Property(u => u.UserName).HasMaxLength(25).IsRequired();
            builder.Property(a => a.Email).HasMaxLength(100).IsRequired();
            builder.Property(a => a.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.PhoneNumber).HasMaxLength(18);
            builder.Property(a => a.Address).HasMaxLength(200).IsRequired();
            builder.HasIndex(a => a.Email).IsUnique();

            #region AdminEkleme
            byte[] _hash;
            byte[] _salt;
            PasswordHelper.CreatePasswordHash("123", out _hash, out _salt);
            builder.HasData(new User
            {
                ID = 1,
                UserName = "Admin",
                FirstName = "Ahmet Fehmi",
                LastName = "Yavuz",
                Address = "Rize",
                Email = "af.yavuz@gg.com",
                Role = UserRole.Admin,
                IsActive = true,
                PasswordHash = _hash,
                PasswordSalt = _salt
            }); 
            #endregion
        }
    }
}
