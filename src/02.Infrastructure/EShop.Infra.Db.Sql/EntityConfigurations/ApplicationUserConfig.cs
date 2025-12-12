using EShop.Domain.Core.CategoryAgg.Entity;
using EShop.Domain.Core.UserAgg.Entity;
using EShop.Domain.Core.UserAgg.Enum;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Db.Sql.EntityConfigurations
{
    public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
           
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser()
                {
                    Id = 1,FirstName= "behnaz",
                    LastName="bayatloo",Role=RoleEnum.Admin
                   ,UserName="behnaz",
                    Email="b@gmail.com",
                    EmailConfirmed=true,
                    PasswordHash= hasher.HashPassword(new ApplicationUser(), "12345"),
                    CreatedAt=new DateTime(2025, 12, 11, 14, 30, 0)

                },
                new ApplicationUser()
                {
                    Id = 2,
                    FirstName = "meysam",
                    LastName = "beigi",
                    Role = RoleEnum.Customer
                   ,
                    UserName = "meysam",
                    Email = "beigi@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(new ApplicationUser(), "12345"),
                    CreatedAt = new DateTime(2025, 12, 11, 14, 30, 0)
                }
                );

        }
    }
}
