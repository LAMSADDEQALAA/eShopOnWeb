﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.eShopWeb.Infrastructure.Identity;

#nullable disable

namespace Microsoft.eShopWeb.Infrastructure.Identity.Migrations
{
    [DbContext(typeof(AppIdentityDbContext))]
    [Migration("20220616120850_InitialIdentityModel3")]
    partial class InitialIdentityModel3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adresse")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Responsible")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Vat")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies", (string)null);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Picture")
                        .HasColumnType("longtext");

                    b.Property<int?>("WatchId")
                        .HasColumnType("int");

                    b.HasKey("DocumentId");

                    b.HasIndex("DocumentTypeId")
                        .IsUnique();

                    b.HasIndex("WatchId");

                    b.ToTable("Documents", (string)null);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.DocumentType", b =>
                {
                    b.Property<int>("DocumentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("DocumentTypeId");

                    b.ToTable("DocumentTypes", (string)null);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("lang")
                        .HasColumnType("longtext");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages", (string)null);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.NFT", b =>
                {
                    b.Property<int>("NFTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("WatchId")
                        .HasColumnType("int");

                    b.Property<bool>("is_minted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("kalartID")
                        .HasColumnType("longtext");

                    b.HasKey("NFTId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("StatusId")
                        .IsUnique();

                    b.HasIndex("WatchId")
                        .IsUnique();

                    b.ToTable("NFTs", (string)null);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("longtext");

                    b.Property<int>("WatchId")
                        .HasColumnType("int");

                    b.HasKey("PictureId");

                    b.HasIndex("WatchId");

                    b.ToTable("Pictures", (string)null);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.HasKey("StatusId");

                    b.ToTable("Status", (string)null);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Template", b =>
                {
                    b.Property<int>("TemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .HasColumnType("longtext");

                    b.Property<string>("FileUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("KalartTemplateId")
                        .HasColumnType("longtext");

                    b.Property<int>("WatchId")
                        .HasColumnType("int");

                    b.HasKey("TemplateId");

                    b.HasIndex("WatchId")
                        .IsUnique();

                    b.ToTable("Templates", (string)null);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Watch", b =>
                {
                    b.Property<int>("WatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Buckle")
                        .HasColumnType("longtext");

                    b.Property<string>("Buckle_Material")
                        .HasColumnType("longtext");

                    b.Property<string>("Calibre")
                        .HasColumnType("longtext");

                    b.Property<string>("Case")
                        .HasColumnType("longtext");

                    b.Property<string>("Color")
                        .HasColumnType("longtext");

                    b.Property<string>("Dial")
                        .HasColumnType("longtext");

                    b.Property<string>("Diametre")
                        .HasColumnType("longtext");

                    b.Property<string>("Fabrication_Date")
                        .HasColumnType("longtext");

                    b.Property<string>("Functions")
                        .HasColumnType("longtext");

                    b.Property<string>("Gendre")
                        .HasColumnType("longtext");

                    b.Property<string>("Glass")
                        .HasColumnType("longtext");

                    b.Property<bool>("Has_Service")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Marque")
                        .HasColumnType("longtext");

                    b.Property<string>("Modèle")
                        .HasColumnType("longtext");

                    b.Property<string>("Movement")
                        .HasColumnType("longtext");

                    b.Property<string>("Refernce_number")
                        .HasColumnType("longtext");

                    b.Property<string>("Reserve")
                        .HasColumnType("longtext");

                    b.Property<string>("Serial_Number")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.Property<string>("Strap_material")
                        .HasColumnType("longtext");

                    b.Property<string>("WaterPoof")
                        .HasColumnType("longtext");

                    b.Property<bool>("With_Box")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("With_Paper")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("bezel")
                        .HasColumnType("longtext");

                    b.HasKey("WatchId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Watches", (string)null);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.Infrastructure.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("WalletId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.eShopWeb.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Document", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.DocumentType", "DocumentType")
                        .WithOne("Document")
                        .HasForeignKey("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Document", "DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Watch", "Watch")
                        .WithMany("Documents")
                        .HasForeignKey("WatchId");

                    b.Navigation("DocumentType");

                    b.Navigation("Watch");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.NFT", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany("NFT")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Status", "Status")
                        .WithOne("NFT")
                        .HasForeignKey("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.NFT", "StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Watch", "Watch")
                        .WithOne("NFT")
                        .HasForeignKey("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.NFT", "WatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");

                    b.Navigation("Watch");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Picture", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Watch", "Watch")
                        .WithMany("Pictures")
                        .HasForeignKey("WatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Watch");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Template", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Watch", "Watch")
                        .WithOne("Template")
                        .HasForeignKey("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Template", "WatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Watch");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Watch", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany("Watch")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.Infrastructure.Identity.ApplicationUser", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.Navigation("Company");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.DocumentType", b =>
                {
                    b.Navigation("Document");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Status", b =>
                {
                    b.Navigation("NFT");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.NftWatch_Entities.Watch", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("NFT");

                    b.Navigation("Pictures");

                    b.Navigation("Template");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.Infrastructure.Identity.ApplicationUser", b =>
                {
                    b.Navigation("NFT");

                    b.Navigation("Watch");
                });
#pragma warning restore 612, 618
        }
    }
}
