using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using myTestASPNETCoreSite.Domain.Entities;

namespace myTestASPNETCoreSite.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "AAE020F9-1D67-4D96-869F-1825E11CC19E",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "C1C28728-5D27-4AF6-91DF-1DB0ABADBDE8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "AAE020F9-1D67-4D96-869F-1825E11CC19E",
                UserId = "C1C28728-5D27-4AF6-91DF-1DB0ABADBDE8"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("DFE75521-E148-44D1-8EDA-85520368DA21"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("F5F04263-18B6-4E64-BA80-F488E2EE4C5B"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("A1FCC374-6061-4E96-8DB4-91FCEA697272"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });

        }
    }
}
