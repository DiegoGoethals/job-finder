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

            var firstUser = users.FirstOrDefault();
            var employerUserRole = firstUser != null
                ? new IdentityUserRole<Guid> { UserId = firstUser.Id, RoleId = employerRole.Id }
                : null;

            var employeeUserRoles = users.Skip(1)
                .Select(u => new IdentityUserRole<Guid> { UserId = u.Id, RoleId = employeeRole.Id })
                .ToList();

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(employeeUserRoles.Concat(new[] { employerUserRole })
            );

            var skills = new List<Skill>()
            {
                new Skill { Id = Guid.NewGuid(), Name = "Programming" },
                new Skill { Id = Guid.NewGuid(), Name = "Gardening" },
                new Skill { Id = Guid.NewGuid(), Name = "Cooking" },
                new Skill { Id = Guid.NewGuid(), Name = "Cleaning" },
                new Skill { Id = Guid.NewGuid(), Name = "Driving" },
                new Skill { Id = Guid.NewGuid(), Name = "Teaching" },
                new Skill { Id = Guid.NewGuid(), Name = "Writing" },
                new Skill { Id = Guid.NewGuid(), Name = "Maths" },
                new Skill { Id = Guid.NewGuid(), Name = "Language" },
                new Skill { Id = Guid.NewGuid(), Name = "Painting" },
                new Skill { Id = Guid.NewGuid(), Name = "Photography" },
                new Skill { Id = Guid.NewGuid(), Name = "Sewing" }
            };

            modelBuilder.Entity<Skill>().HasData(skills);
        }

        private static List<ApplicationUser> GenerateUsers()
        {
            var users = new List<ApplicationUser>();
            for (int i = 0; i < 10; i++)
            {
                users.Add(new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    UserName = $"user{i + 1}",
                    Firstname = $"User",
                    Lastname = $"{i + 1}",
                    Email = $"user{i + 1}@test.com"
                });
            }
            return users;
        }
    }
}
