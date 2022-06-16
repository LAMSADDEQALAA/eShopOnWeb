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
    public DbSet<DocumentType> DocumentType { get; set; }
    public DbSet<Language> Language { get; set; }
    public DbSet<NFT> NFT { get; set; }
    public DbSet<Picture> Picture { get; set; }
    public DbSet<Status> Status { get; set; }
    public DbSet<Template> Template { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

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
