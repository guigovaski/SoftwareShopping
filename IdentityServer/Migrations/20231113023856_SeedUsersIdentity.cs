using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityServer.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1eb0dd9a-adc6-46ff-9ea1-882b46d2ea59", "51ec3737-b25a-4ea9-8baa-d225898f81d7", "Common", "COMMON" },
                    { "2bc904e0-3e4e-4582-99b1-9a4b6b84c426", "22c70d26-e1c3-44b4-a173-11aa9c1657a8", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "59b645ad-1955-4e3f-8abe-8e07d0a56639", 2, "d9e89e51-e4c5-4634-a5b4-ea8dcf0f0927", "generic@email.com", true, "Guilherme", "Govaski", false, null, null, "GUIGOVASKI", "AQAAAAEAACcQAAAAEIwK2EXpcU7eEjmLy5riJbXvneM1Pe+LQ8h2GNeQQYK+gk8najN8vOhpInN4Ig29TA==", "+5541999999999", false, "ae038048-1af2-4107-822b-7ee87acdc295", false, "guigovaski" },
                    { "dc47b963-63dc-4fea-8e31-47f005d3c7bf", 2, "f29fd714-3446-406e-8333-a20f3a2735ca", "generic2@email.com", true, "Stephany", "Melo", false, null, null, "STEMELO", "AQAAAAEAACcQAAAAEJv+W5Gfj8abdnGVNYK27S+IViNsQZoqi3ynWiIr+GeMy2ceoj4r463M4hBdLy6VvA==", "+5541888888888", false, "43b05130-2302-4441-ba49-b23d0079c506", false, "stemelo" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { -6, "name", "Stephany Melo", "dc47b963-63dc-4fea-8e31-47f005d3c7bf" },
                    { -5, "role", "Common", "dc47b963-63dc-4fea-8e31-47f005d3c7bf" },
                    { -4, "email", "generic2@email.com", "dc47b963-63dc-4fea-8e31-47f005d3c7bf" },
                    { -3, "name", "Guilherme Govaski", "59b645ad-1955-4e3f-8abe-8e07d0a56639" },
                    { -2, "role", "Admin", "59b645ad-1955-4e3f-8abe-8e07d0a56639" },
                    { -1, "email", "generic@email.com", "59b645ad-1955-4e3f-8abe-8e07d0a56639" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2bc904e0-3e4e-4582-99b1-9a4b6b84c426", "59b645ad-1955-4e3f-8abe-8e07d0a56639" },
                    { "1eb0dd9a-adc6-46ff-9ea1-882b46d2ea59", "dc47b963-63dc-4fea-8e31-47f005d3c7bf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2bc904e0-3e4e-4582-99b1-9a4b6b84c426", "59b645ad-1955-4e3f-8abe-8e07d0a56639" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1eb0dd9a-adc6-46ff-9ea1-882b46d2ea59", "dc47b963-63dc-4fea-8e31-47f005d3c7bf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1eb0dd9a-adc6-46ff-9ea1-882b46d2ea59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bc904e0-3e4e-4582-99b1-9a4b6b84c426");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59b645ad-1955-4e3f-8abe-8e07d0a56639");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc47b963-63dc-4fea-8e31-47f005d3c7bf");
        }
    }
}
