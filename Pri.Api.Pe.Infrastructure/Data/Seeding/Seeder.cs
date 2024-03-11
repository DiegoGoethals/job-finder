using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pri.Api.Pe.Core.Entities;

namespace Pri.Api.Pe.Infrastructure.Data.Seeding
{
    public static class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var users = GenerateUsers();

            users.ForEach(user =>
            {
                var passwordHasher = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHasher.HashPassword(user, "seed1234");
                user.NormalizedUserName = user.UserName.ToUpper();
                user.NormalizedEmail = user.Email.ToUpper();
                user.SecurityStamp = Guid.NewGuid().ToString();
                user.ConcurrencyStamp = Guid.NewGuid().ToString();
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.TwoFactorEnabled = false;
            });

            modelBuilder.Entity<ApplicationUser>().HasData(users);

            var employerRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Employer", NormalizedName = "EMPLOYER" };
            var employeeRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Employee", NormalizedName = "EMPLOYEE" };
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(employerRole, employeeRole);
        }

        private static List<ApplicationUser> GenerateUsers()
        {
            var users = new List<ApplicationUser>();
            for (int i = 0; i < 10; i++)
            {
                users.Add(new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    UserName = $"user{i}",
                    Firstname = $"User",
                    Lastname = $"{i}",
                    Email = $"user{i}@test.com"
                });
            }
            return users;
        }
    }
}
