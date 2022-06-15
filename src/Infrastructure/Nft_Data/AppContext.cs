using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities;

namespace Microsoft.eShopWeb.Infrastructure.Nft_Data;

public class AppContext : DbContext
{
    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {
    }

    public DbSet<Watch> Watch { get; set; }
    public DbSet<Company> Company { get; set; }
    public DbSet<Document> Document { get; set; }
    public DbSet<Document_type> Document_type { get; set; }
    public DbSet<Language> Language { get; set; }
    public DbSet<NFT> NFT { get; set; }
    public DbSet<Picture> Picture { get; set; }
    public DbSet<Status> Status { get; set; }
    public DbSet<Template> Template { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

    }
}
