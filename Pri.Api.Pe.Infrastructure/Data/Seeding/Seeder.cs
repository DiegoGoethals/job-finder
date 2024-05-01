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

            var seedUser = new ApplicationUser
            {
                Id = Guid.NewGuid(),
                UserName = "PriUser",
                Firstname = "Seed",
                Lastname = "User",
                Email = "user@pri.be"
            };

            var seedAdmin = new ApplicationUser
            {
                Id = Guid.NewGuid(),
                UserName = "PriAdmin",
                Firstname = "Seed",
                Lastname = "Admin",
                Email = "admin@pri.be"
            };

            var passwordHasherSeed = new PasswordHasher<ApplicationUser>();
            seedUser.PasswordHash = passwordHasherSeed.HashPassword(seedUser, "Test123?");
            seedAdmin.PasswordHash = passwordHasherSeed.HashPassword(seedAdmin, "Test123?");
            users.Add(seedUser);
            users.Add(seedAdmin);

            modelBuilder.Entity<ApplicationUser>().HasData(users);

            var employerRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Employer", NormalizedName = "EMPLOYER" };
            var employeeRole = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Employee", NormalizedName = "EMPLOYEE" };
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(employerRole, employeeRole);

            var employer = users.FirstOrDefault();
            var employerUserRole = employer != null
                ? new IdentityUserRole<Guid> { UserId = employer.Id, RoleId = employerRole.Id }
                : null;

            var adminUserRole = new IdentityUserRole<Guid> { UserId = seedAdmin.Id, RoleId = employerRole.Id };

            var employeeUserRoles = users.Skip(1)
                .Select(u =>
                {
                    if (!(u.UserName == "PriAdmin"))
                    {
                        return new IdentityUserRole<Guid> { UserId = u.Id, RoleId = employeeRole.Id };
                    }
                    return adminUserRole;
                })
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

            var jobs = GenerateJobs(employer);
            modelBuilder.Entity<Job>().HasData(jobs);

            var statuses = new List<ApplicationStatus>
            {
                new() { Id = Guid.NewGuid(), Name = "Pending" },
                new() { Id = Guid.NewGuid(), Name = "Accepted" },
                new() { Id = Guid.NewGuid(), Name = "Rejected" }
            };
            modelBuilder.Entity<ApplicationStatus>()
                .HasData(statuses);

            var applications = GenerateApplications(users.Skip(1).ToList(), jobs, statuses);
            modelBuilder.Entity<Application>().HasData(applications);

            var messages = GenerateMessages(users);
            modelBuilder.Entity<Message>().HasData(messages);

            var reviews = GenerateReviews(users);
            modelBuilder.Entity<Review>().HasData(reviews);
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

        private static List<Job> GenerateJobs(ApplicationUser employer)
        {
            var jobs = new List<Job>();
            for (int i = 0; i < 10; i++)
            {
                jobs.Add(new Job
                {
                    Id = Guid.NewGuid(),
                    Name = $"Job{i + 1}",
                    Description = $"Job{i + 1} description",
                    EmployerId = employer.Id,
                    Salary = 10 * (i + 1)
                });
            }
            return jobs;
        }

        private static List<Application> GenerateApplications(List<ApplicationUser> employees, List<Job> jobs, List<ApplicationStatus> statuses)
        {
            var applications = new List<Application>();
            for (int i = 0; i < 10; i++)
            {
                applications.Add(new Application
                {
                    Id = Guid.NewGuid(),
                    CandidateId = employees[i % employees.Count].Id,
                    JobId = jobs[i].Id,
                    StatusId = statuses[i % statuses.Count].Id
                });
            }
            return applications;
        }

        private static List<Message> GenerateMessages(List<ApplicationUser> users)
        {
            var messages = new List<Message>();
            for (int i = 0; i < 10; i++)
            {
                messages.Add(new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = users[i].Id,
                    ReceiverId = users[(i + 1) % users.Count].Id,
                    Content = $"Seeded message"
                });
            }
            return messages;
        }

        private static List<Review> GenerateReviews(List<ApplicationUser> users)
        {
            var reviews = new List<Review>();
            for (int i = 0; i < 10; i++)
            {
                reviews.Add(new Review
                {
                    Id = Guid.NewGuid(),
                    Rating = (i + 1) % 5,
                    ReviewerId = users[i].Id,
                    RevieweeId = users[(i + 1) % users.Count].Id,
                    Comment = $"Seeded review"
                });
            }
            return reviews;
        }
    }
}
