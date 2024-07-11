using System;
using Microsoft.EntityFrameworkCore;
using MySmartAgenda.Models;

namespace MySmartAgenda.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   //relationship between User  and UserEvent Entity
            modelBuilder.Entity<UserEvent>()
                .HasKey(ue => new { ue.UserId, ue.EventID });
            modelBuilder.Entity<UserEvent>()
                .HasOne(u => u.User)
                .WithMany(ue => ue.UserEvents)
                .HasForeignKey(us => us.UserId);

            {   //relationship between User  and UserEvent Entity

                modelBuilder.Entity<UserEvent>()
                .HasKey(ue => new { ue.UserId, ue.EventID });
                modelBuilder.Entity<UserEvent>()
                    .HasOne(e => e.Events)
                    .WithMany(ue => ue.UserEvents)
                    .HasForeignKey(e => e.EventID);
                base.OnModelCreating(modelBuilder);
            }
        }
    }
}

