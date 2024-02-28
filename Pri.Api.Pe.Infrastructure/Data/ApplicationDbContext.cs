using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pri.Api.Pe.Core.Entities;

namespace Pri.Api.Pe.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .Property(p => p.UserName)
            .HasMaxLength(20);

            modelBuilder.Entity<ApplicationUser>()
                .Property(p => p.Firstname)
            .HasMaxLength(30);

            modelBuilder.Entity<ApplicationUser>()
                .Property(p => p.Lastname)
                .HasMaxLength(30);

            modelBuilder.Entity<Job>()
                .Property(p => p.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<Application>()
                .HasOne(a => a.Candidate)
                .WithMany(u => u.Applications)
                .HasForeignKey(a => a.CandidateId);

            modelBuilder.Entity<Application>()
                .HasOne(a => a.Job)
                .WithMany(j => j.Applications)
                .HasForeignKey(a => a.JobId);

            modelBuilder.Entity<Application>()
                .HasOne(a => a.Status)
                .WithMany(s => s.Applications)
                .HasForeignKey(a => a.StatusId);

            modelBuilder.Entity<Job>()
                .HasOne(j => j.Employer)
                .WithMany(u => u.Jobs)
                .HasForeignKey(j => j.EmployerId);

            modelBuilder.Entity<Job>()
                .HasMany(j => j.Skills)
                .WithMany(s => s.Jobs);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Skills)
                .WithMany(s => s.Users);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.SendMessages)
                .HasForeignKey(m => m.SenderId);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany(u => u.ReceivedMessages)
                .HasForeignKey(m => m.ReceiverId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Reviewer)
                .WithMany(u => u.MadeReviews)
                .HasForeignKey(r => r.ReviewerId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Reviewee)
                .WithMany(u => u.ReceivedReviews)
                .HasForeignKey(r => r.RevieweeId);
        }
    }
}
