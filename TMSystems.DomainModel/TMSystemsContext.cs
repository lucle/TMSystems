using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TMSystems.DomainModel
{
    public class TMSystemsContext:DbContext
    {
        public TMSystemsContext(DbContextOptions<TMSystemsContext> options): base(options) { }

        private static DbContextOptions<TMSystemsContext> GetOptions(string connectionString)
        {
            var options = new DbContextOptionsBuilder<TMSystemsContext>()
                .UseSqlServer(connectionString, x => x.MigrationsAssembly("TMSystems.Web"))
                .Options;
            return options;
        }

        public DbSet<AppSetting> AppSettings { get; set; }
        public DbSet<Catalog> Cataloges { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<EntityType> EntityTypes { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<StateOrProvince> StateOrProvinces { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketStatus> TicketStatus { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(x => x.Roles).WithOne(x => x.User);
            base.OnModelCreating(modelBuilder);
        }
    }
}
