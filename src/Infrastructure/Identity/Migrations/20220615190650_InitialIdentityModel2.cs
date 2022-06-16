using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microsoft.eShopWeb.Infrastructure.Identity.Migrations
{
    public partial class InitialIdentityModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Document_type_Document_typeId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_Watch_WatchId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_NFT_Status_StatusId",
                table: "NFT");

            migrationBuilder.DropForeignKey(
                name: "FK_NFT_Users_ApplicationUserId",
                table: "NFT");

            migrationBuilder.DropForeignKey(
                name: "FK_NFT_Watch_WatchId",
                table: "NFT");

            migrationBuilder.DropForeignKey(
                name: "FK_Picture_Watch_WatchId",
                table: "Picture");

            migrationBuilder.DropForeignKey(
                name: "FK_Template_Watch_WatchId",
                table: "Template");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Company_CompanyId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Language_LanguageId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Watch_Users_ApplicationUserId",
                table: "Watch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Watch",
                table: "Watch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Template",
                table: "Template");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Picture",
                table: "Picture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NFT",
                table: "NFT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Language",
                table: "Language");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Document_type",
                table: "Document_type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Document",
                table: "Document");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "Watch",
                newName: "Watches");

            migrationBuilder.RenameTable(
                name: "Template",
                newName: "Templates");

            migrationBuilder.RenameTable(
                name: "Picture",
                newName: "Pictures");

            migrationBuilder.RenameTable(
                name: "NFT",
                newName: "NFTs");

            migrationBuilder.RenameTable(
                name: "Language",
                newName: "Languages");

            migrationBuilder.RenameTable(
                name: "Document_type",
                newName: "Document_types");

            migrationBuilder.RenameTable(
                name: "Document",
                newName: "Documents");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameIndex(
                name: "IX_Watch_ApplicationUserId",
                table: "Watches",
                newName: "IX_Watches_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Template_WatchId",
                table: "Templates",
                newName: "IX_Templates_WatchId");

            migrationBuilder.RenameIndex(
                name: "IX_Picture_WatchId",
                table: "Pictures",
                newName: "IX_Pictures_WatchId");

            migrationBuilder.RenameIndex(
                name: "IX_NFT_WatchId",
                table: "NFTs",
                newName: "IX_NFTs_WatchId");

            migrationBuilder.RenameIndex(
                name: "IX_NFT_StatusId",
                table: "NFTs",
                newName: "IX_NFTs_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_NFT_ApplicationUserId",
                table: "NFTs",
                newName: "IX_NFTs_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Document_WatchId",
                table: "Documents",
                newName: "IX_Documents_WatchId");

            migrationBuilder.RenameIndex(
                name: "IX_Document_Document_typeId",
                table: "Documents",
                newName: "IX_Documents_Document_typeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Watches",
                table: "Watches",
                column: "WatchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Templates",
                table: "Templates",
                column: "TemplateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures",
                column: "PictureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NFTs",
                table: "NFTs",
                column: "NFTId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "LanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Document_types",
                table: "Document_types",
                column: "Document_typeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "DocumentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Document_types_Document_typeId",
                table: "Documents",
                column: "Document_typeId",
                principalTable: "Document_types",
                principalColumn: "Document_typeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Watches_WatchId",
                table: "Documents",
                column: "WatchId",
                principalTable: "Watches",
                principalColumn: "WatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_NFTs_Status_StatusId",
                table: "NFTs",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NFTs_Users_ApplicationUserId",
                table: "NFTs",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NFTs_Watches_WatchId",
                table: "NFTs",
                column: "WatchId",
                principalTable: "Watches",
                principalColumn: "WatchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Watches_WatchId",
                table: "Pictures",
                column: "WatchId",
                principalTable: "Watches",
                principalColumn: "WatchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_Watches_WatchId",
                table: "Templates",
                column: "WatchId",
                principalTable: "Watches",
                principalColumn: "WatchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Companies_CompanyId",
                table: "Users",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Languages_LanguageId",
                table: "Users",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Watches_Users_ApplicationUserId",
                table: "Watches",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Document_types_Document_typeId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Watches_WatchId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_NFTs_Status_StatusId",
                table: "NFTs");

            migrationBuilder.DropForeignKey(
                name: "FK_NFTs_Users_ApplicationUserId",
                table: "NFTs");

            migrationBuilder.DropForeignKey(
                name: "FK_NFTs_Watches_WatchId",
                table: "NFTs");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Watches_WatchId",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Templates_Watches_WatchId",
                table: "Templates");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Companies_CompanyId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Languages_LanguageId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Watches_Users_ApplicationUserId",
                table: "Watches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Watches",
                table: "Watches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Templates",
                table: "Templates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NFTs",
                table: "NFTs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Document_types",
                table: "Document_types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Watches",
                newName: "Watch");

            migrationBuilder.RenameTable(
                name: "Templates",
                newName: "Template");

            migrationBuilder.RenameTable(
                name: "Pictures",
                newName: "Picture");

            migrationBuilder.RenameTable(
                name: "NFTs",
                newName: "NFT");

            migrationBuilder.RenameTable(
                name: "Languages",
                newName: "Language");

            migrationBuilder.RenameTable(
                name: "Documents",
                newName: "Document");

            migrationBuilder.RenameTable(
                name: "Document_types",
                newName: "Document_type");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameIndex(
                name: "IX_Watches_ApplicationUserId",
                table: "Watch",
                newName: "IX_Watch_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Templates_WatchId",
                table: "Template",
                newName: "IX_Template_WatchId");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_WatchId",
                table: "Picture",
                newName: "IX_Picture_WatchId");

            migrationBuilder.RenameIndex(
                name: "IX_NFTs_WatchId",
                table: "NFT",
                newName: "IX_NFT_WatchId");

            migrationBuilder.RenameIndex(
                name: "IX_NFTs_StatusId",
                table: "NFT",
                newName: "IX_NFT_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_NFTs_ApplicationUserId",
                table: "NFT",
                newName: "IX_NFT_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_WatchId",
                table: "Document",
                newName: "IX_Document_WatchId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_Document_typeId",
                table: "Document",
                newName: "IX_Document_Document_typeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Watch",
                table: "Watch",
                column: "WatchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Template",
                table: "Template",
                column: "TemplateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Picture",
                table: "Picture",
                column: "PictureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NFT",
                table: "NFT",
                column: "NFTId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Language",
                table: "Language",
                column: "LanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Document",
                table: "Document",
                column: "DocumentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Document_type",
                table: "Document_type",
                column: "Document_typeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Document_type_Document_typeId",
                table: "Document",
                column: "Document_typeId",
                principalTable: "Document_type",
                principalColumn: "Document_typeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Watch_WatchId",
                table: "Document",
                column: "WatchId",
                principalTable: "Watch",
                principalColumn: "WatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_NFT_Status_StatusId",
                table: "NFT",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NFT_Users_ApplicationUserId",
                table: "NFT",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NFT_Watch_WatchId",
                table: "NFT",
                column: "WatchId",
                principalTable: "Watch",
                principalColumn: "WatchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_Watch_WatchId",
                table: "Picture",
                column: "WatchId",
                principalTable: "Watch",
                principalColumn: "WatchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Template_Watch_WatchId",
                table: "Template",
                column: "WatchId",
                principalTable: "Watch",
                principalColumn: "WatchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Company_CompanyId",
                table: "Users",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Language_LanguageId",
                table: "Users",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Watch_Users_ApplicationUserId",
                table: "Watch",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
