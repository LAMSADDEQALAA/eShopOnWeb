using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microsoft.eShopWeb.Infrastructure.Identity.Migrations
{
    public partial class InitialIdentityModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NFT_user_ApplicationUserId",
                table: "NFT");

            migrationBuilder.DropForeignKey(
                name: "FK_role_claim_role_RoleId",
                table: "role_claim");

            migrationBuilder.DropForeignKey(
                name: "FK_user_Company_CompanyId",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_user_Language_LanguageId",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_user_claim_user_UserId",
                table: "user_claim");

            migrationBuilder.DropForeignKey(
                name: "FK_user_login_user_UserId",
                table: "user_login");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_role_RoleId",
                table: "user_role");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_user_UserId",
                table: "user_role");

            migrationBuilder.DropForeignKey(
                name: "FK_user_token_user_UserId",
                table: "user_token");

            migrationBuilder.DropForeignKey(
                name: "FK_Watch_user_ApplicationUserId",
                table: "Watch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_token",
                table: "user_token");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_role",
                table: "user_role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_login",
                table: "user_login");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_claim",
                table: "user_claim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_role_claim",
                table: "role_claim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_role",
                table: "role");

            migrationBuilder.RenameTable(
                name: "user_token",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "user_role",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "user_login",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "user_claim",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "role_claim",
                newName: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "role",
                newName: "Roles");

            migrationBuilder.RenameIndex(
                name: "IX_user_role_RoleId",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_user_login_UserId",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_user_claim_UserId",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_user_LanguageId",
                table: "Users",
                newName: "IX_Users_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_user_CompanyId",
                table: "Users",
                newName: "IX_Users_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_role_claim_RoleId",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NFT_Users_ApplicationUserId",
                table: "NFT",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
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
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Watch_Users_ApplicationUserId",
                table: "Watch",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NFT_Users_ApplicationUserId",
                table: "NFT");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Company_CompanyId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Language_LanguageId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Watch_Users_ApplicationUserId",
                table: "Watch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "user_token");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "user_role");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "user_login");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "user_claim");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "role");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "role_claim");

            migrationBuilder.RenameIndex(
                name: "IX_Users_LanguageId",
                table: "user",
                newName: "IX_user_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CompanyId",
                table: "user",
                newName: "IX_user_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                table: "user_role",
                newName: "IX_user_role_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "user_login",
                newName: "IX_user_login_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                table: "user_claim",
                newName: "IX_user_claim_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "role_claim",
                newName: "IX_role_claim_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_token",
                table: "user_token",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_role",
                table: "user_role",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_login",
                table: "user_login",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_claim",
                table: "user_claim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_role",
                table: "role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_role_claim",
                table: "role_claim",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NFT_user_ApplicationUserId",
                table: "NFT",
                column: "ApplicationUserId",
                principalTable: "user",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_role_claim_role_RoleId",
                table: "role_claim",
                column: "RoleId",
                principalTable: "role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_Company_CompanyId",
                table: "user",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_Language_LanguageId",
                table: "user",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_claim_user_UserId",
                table: "user_claim",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_login_user_UserId",
                table: "user_login",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_role_RoleId",
                table: "user_role",
                column: "RoleId",
                principalTable: "role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_user_UserId",
                table: "user_role",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_token_user_UserId",
                table: "user_token",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Watch_user_ApplicationUserId",
                table: "Watch",
                column: "ApplicationUserId",
                principalTable: "user",
                principalColumn: "Id");
        }
    }
}
