using System;
using System.Collections.Generic;
using System.Text;
using AuthServer.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthServer.Data
{
    public class AppDbContext:IdentityDbContext<UserApp,IdentityRole,string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            builder.Entity<IdentityUserLogin<string>>().HasKey(x => x.UserId);
            builder.Entity<IdentityUserRole<string>>().HasKey(x => x.RoleId);
            builder.Entity<IdentityUserRole<string>>().HasAlternateKey(x => x.UserId);
            builder.Entity<IdentityUserToken<string>>().HasKey(x => x.UserId);
        }
    }
}
