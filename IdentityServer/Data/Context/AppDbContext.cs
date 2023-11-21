using System.Security.Claims;
using IdentityModel;
using IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Data.Context;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        SeedRolesIdentity(modelBuilder);
        SeedUsersIdentity(modelBuilder);
        SeedUsersRolesIdentity(modelBuilder);
        SeedUserClaimsIdentity(modelBuilder);
    }

    private void SeedRolesIdentity(ModelBuilder modelBuilder)
    {
        var roles = CreateRolesIdentity();

        modelBuilder.Entity<IdentityRole>().HasData(roles);
    }
    
    private void SeedUsersIdentity(ModelBuilder modelBuilder)
    {
        var users = CreateUsersIdentity();

        modelBuilder.Entity<AppUser>().HasData(users);
    }
    
    private void SeedUserClaimsIdentity(ModelBuilder modelBuilder)
    {
        var userClaims = CreateUserClaims();

        modelBuilder.Entity<IdentityUserClaim<string>>().HasData(userClaims);
    }

    private void SeedUsersRolesIdentity(ModelBuilder modelBuilder)
    {
        var usersRoles = CreateUsersRolesIdentity();

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(usersRoles);
    }

    private static IEnumerable<AppUser> CreateUsersIdentity()
    {
        var admUser = new AppUser()
        {
            Id = "59b645ad-1955-4e3f-8abe-8e07d0a56639",
            FirstName = "Guilherme",
            LastName = "Govaski",
            UserName = "guigovaski",
            NormalizedUserName = "GUIGOVASKI",
            Email = "generic@email.com",
            PhoneNumber = "+5541999999999",
            EmailConfirmed = true,
            AccessFailedCount = 2
        };
        
        var commonUser = new AppUser()
        {
            Id = "dc47b963-63dc-4fea-8e31-47f005d3c7bf",
            FirstName = "Stephany",
            LastName = "Melo",
            UserName = "stemelo",
            NormalizedUserName = "STEMELO",
            Email = "generic2@email.com",
            PhoneNumber = "+5541888888888",
            EmailConfirmed = true,
            AccessFailedCount = 2
        };
        
        var passwordHash = new PasswordHasher<AppUser>();
        admUser.PasswordHash = passwordHash.HashPassword(admUser, "@Admin123");
        commonUser.PasswordHash = passwordHash.HashPassword(commonUser, "@Common123");
        
        return new List<AppUser>()
        {
            admUser,
            commonUser
        };
    }

    private List<IdentityRole> CreateRolesIdentity()
    {
        var admRole = new IdentityRole()
        {
            Id = "2bc904e0-3e4e-4582-99b1-9a4b6b84c426",
            Name = "Admin",
            NormalizedName = "ADMIN"
        };
        
        var commonRole = new IdentityRole()
        {
            Id = "1eb0dd9a-adc6-46ff-9ea1-882b46d2ea59",
            Name = "Common",
            NormalizedName = "COMMON"
        };
        
        return new List<IdentityRole>()
        {
            admRole,
            commonRole
        };
    }

    private List<IdentityUserRole<string>> CreateUsersRolesIdentity()
    {
        var admUserRole = new IdentityUserRole<string>()
        {
            RoleId = "2bc904e0-3e4e-4582-99b1-9a4b6b84c426",
            UserId = "59b645ad-1955-4e3f-8abe-8e07d0a56639"
        };

        var commonUserRole = new IdentityUserRole<string>()
        {
            RoleId = "1eb0dd9a-adc6-46ff-9ea1-882b46d2ea59",
            UserId = "dc47b963-63dc-4fea-8e31-47f005d3c7bf"
        };

        return new List<IdentityUserRole<string>>
        {
            admUserRole,
            commonUserRole
        };
    }

    private List<IdentityUserClaim<string>> CreateUserClaims()
    {
        var admUserClaims = new Claim[]
        {
            new Claim(JwtClaimTypes.Email, "generic@email.com"),
            new Claim(JwtClaimTypes.Role, "Admin"),
            new Claim(JwtClaimTypes.Name, "Guilherme Govaski")
        };
        
        var commonUserClaims = new Claim[]
        {
            new Claim(JwtClaimTypes.Email, "generic2@email.com"),
            new Claim(JwtClaimTypes.Role, "Common"),
            new Claim(JwtClaimTypes.Name, "Stephany Melo")
        };
        
        //ADM USER CLAIMS
        var admClaimEmail = new IdentityUserClaim<string>
        {
            Id = -1,
            ClaimType = JwtClaimTypes.Email,
            ClaimValue = "generic@email.com",
            UserId = "59b645ad-1955-4e3f-8abe-8e07d0a56639"
        };
        
        var admClaimRole = new IdentityUserClaim<string>
        {
            Id = -2,
            ClaimType = JwtClaimTypes.Role,
            ClaimValue = "Admin",
            UserId = "59b645ad-1955-4e3f-8abe-8e07d0a56639"
        };
        
        var admClaimName = new IdentityUserClaim<string>
        {
            Id = -3,
            ClaimType = JwtClaimTypes.Name,
            ClaimValue = "Guilherme Govaski",
            UserId = "59b645ad-1955-4e3f-8abe-8e07d0a56639"
        };
        
        //COMMON USER CLAIMS
        var commonClaimEmail = new IdentityUserClaim<string>
        {
            Id = -4,
            ClaimType = JwtClaimTypes.Email,
            ClaimValue = "generic2@email.com",
            UserId = "dc47b963-63dc-4fea-8e31-47f005d3c7bf"
        };
        
        var commonClaimRole = new IdentityUserClaim<string>
        {
            Id = -5,
            ClaimType = JwtClaimTypes.Role,
            ClaimValue = "Common",
            UserId = "dc47b963-63dc-4fea-8e31-47f005d3c7bf"
        };
        
        var commonClaimName = new IdentityUserClaim<string>
        {
            Id = -6,
            ClaimType = JwtClaimTypes.Name,
            ClaimValue = "Stephany Melo",
            UserId = "dc47b963-63dc-4fea-8e31-47f005d3c7bf"
        };
        
        return new List<IdentityUserClaim<string>>
        {
            admClaimEmail,
            admClaimRole,
            admClaimName,
            commonClaimEmail,
            commonClaimRole,
            commonClaimName,
        };
    }
}