using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MinimalBlog.Domain.Entities;

namespace MinimalBlog.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "14a5c7e5-587a-4c4f-88b8-066f51a22124",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "04e09b45-41d1-4f7b-a6f5-2f72bca417af",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "a@email.com",
                NormalizedEmail = "A@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "spassword"),
                SecurityStamp = string.Empty
            });
            
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "14a5c7e5-587a-4c4f-88b8-066f51a22124",
                UserId = "04e09b45-41d1-4f7b-a6f5-2f72bca417af"
            });
            
            builder.Entity<TextField>().HasData(new TextField { 
                Id = new Guid("8ef3fe46-4e6a-4bca-8e7f-734d995118d1"), 
                CodeWord = "PageIndex", 
                Title = "Main"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("843403f5-1b66-4f32-bd23-c8823da3ce44"), 
                CodeWord = "PageServices", 
                Title = "Services"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("46b479cc-61a0-4712-aee9-e514373fbcf2"), 
                CodeWord = "PageAbout", 
                Title = "About"
            });
        }
    }
}
