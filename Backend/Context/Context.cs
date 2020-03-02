using Backend.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Backend.Context
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var serverName = Environment.UserName == "Karens" ? "KARENS-PC" : ".\\SQLEXPRESS";

                var connectionString = $"Data Source={serverName};Initial Catalog=ShadowEntityCore;Integrated Security=True";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Contact>().Property<DateTime?>("LastUpdated");
            modelBuilder.Entity<Contact>().Property<string>("LastUser");

            OnModelCreatingPartial(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    entry.Property("LastUpdated").CurrentValue = DateTime.Now;
                    entry.Property("LastUser").CurrentValue = Environment.UserName;
                }
            }
            return base.SaveChanges();
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}