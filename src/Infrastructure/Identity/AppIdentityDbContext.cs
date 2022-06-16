using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;

namespace Microsoft.eShopWeb.Infrastructure.Identity;

public class AppIdentityDbContext : IdentityDbContext<ApplicationUser>
{
    public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            
            builder.Entity<Watch>().ToTable("Watches");
            builder.Entity<Company>().ToTable("Companies");
            builder.Entity<Document>().ToTable("Documents");
            builder.Entity<DocumentType>().ToTable("DocumentTypes");
            builder.Entity<Language>().ToTable("Languages");
            builder.Entity<NFT>().ToTable("NFTs");
            builder.Entity<Picture>().ToTable("Pictures");
            builder.Entity<Status>().ToTable("Status");
            builder.Entity<Template>().ToTable("Templates");

    }
}
