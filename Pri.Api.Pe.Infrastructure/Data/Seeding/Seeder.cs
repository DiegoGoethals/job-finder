using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pri.Api.Pe.Core.Entities;

namespace Pri.Api.Pe.Infrastructure.Data.Seeding
{
    public static class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var employerRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Employer", NormalizedName = "EMPLOYER" };
            var employeeRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Employee", NormalizedName = "EMPLOYEE" };
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(employerRole, employeeRole);

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

            var statuses = new List<ApplicationStatus>
            {
                new() { Id = Guid.NewGuid(), Name = "Pending" },
                new() { Id = Guid.NewGuid(), Name = "Accepted" },
                new() { Id = Guid.NewGuid(), Name = "Rejected" }
            };
            modelBuilder.Entity<ApplicationStatus>()
                .HasData(statuses);
        }
    }
}
