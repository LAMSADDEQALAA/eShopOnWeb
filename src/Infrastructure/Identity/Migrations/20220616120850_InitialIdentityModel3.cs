using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microsoft.eShopWeb.Infrastructure.Identity.Migrations
{
    public partial class InitialIdentityModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Document_types_Document_typeId",
                table: "Documents");

            migrationBuilder.DropTable(
                name: "Document_types");

            migrationBuilder.RenameColumn(
                name: "Document_typeId",
                table: "Documents",
                newName: "DocumentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_Document_typeId",
                table: "Documents",
                newName: "IX_Documents_DocumentTypeId");

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.DocumentTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_DocumentTypes_DocumentTypeId",
                table: "Documents",
                column: "DocumentTypeId",
                principalTable: "DocumentTypes",
                principalColumn: "DocumentTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_DocumentTypes_DocumentTypeId",
                table: "Documents");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.RenameColumn(
                name: "DocumentTypeId",
                table: "Documents",
                newName: "Document_typeId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_DocumentTypeId",
                table: "Documents",
                newName: "IX_Documents_Document_typeId");

            migrationBuilder.CreateTable(
                name: "Document_types",
                columns: table => new
                {
                    Document_typeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_types", x => x.Document_typeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Document_types_Document_typeId",
                table: "Documents",
                column: "Document_typeId",
                principalTable: "Document_types",
                principalColumn: "Document_typeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
